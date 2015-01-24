using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Ionic.Zip;
using Ionic.Zlib;
using pwAPI.StructuresElement;
using pwAPI.Utils;

namespace pwAPI.Readers
{
	public class ElementReader
	{
		public Dictionary<string,Item[]> Items;
		private readonly BinaryReader _br;
		private readonly List<ConfigList> _confList;
		public HashSet<int> ExistingId;
	    private string _path;
		// SAVERS
		private readonly Dictionary<byte,List<byte[]>> _somevals;

		public ElementReader (string configPath, string elementPath)
		{
		    _path = elementPath;
			_confList = ConfigList.ParseList (configPath);
			Items = new Dictionary<string, Item[]> ();
			_br = new BinaryReader (File.OpenRead (elementPath));
			_somevals = new Dictionary<byte, List<byte[]>> ();
		    var bb = new List<byte[]> {_br.ReadBytes(8)};
		    _somevals.Add (0, bb);

			for (var i = 0; i < _confList.Count; i++) {
				switch (i) {
				case 20:
					_somevals.Add (Convert.ToByte (i), Offset20 ());
					Items.Add (_confList [i].Name, List (i));
					break;
				case 58:
					_somevals.Add (Convert.ToByte (i), List58 ());
					break;
				case 100:
					_somevals.Add (Convert.ToByte (i), Offset100 ());
					Items.Add (_confList [i].Name, List (i));
					break;
				default:
					Items.Add (_confList [i].Name, List (i));
					break;
				}
			}
			Console.WriteLine (Process.GetCurrentProcess ().WorkingSet64);
			Console.WriteLine ((GC.GetTotalMemory (true) / 1024f) / 1024f);
			_br.Dispose ();
			Console.WriteLine ("Readed");
		}

		public int GetFreeId ()
		{
			if (ExistingId == null)
				ElementUtils.GetExsistingIDs (this);
			var ra = new Random ();
			int id;
			do {
				id = ra.Next (0, 55000);
			} while(ExistingId.Contains(id));
			ExistingId.Add (id);
			return id;
		}

		public Item[] GetListById (int id)
		{
			return Items [GetListKey (id)];
		}

		private string GetListKey (int id)
		{
			for (int i = 0; i < this.Items.Keys.Count; i++) {
				string key = this.Items.Keys.ElementAt (i);
				int list = int.Parse (key.Split (' ') [0]);
				if (list == id)
					return key;
			}
			return null;
		}

		private Item[] List (int i)
		{
			var count = _br.ReadInt32 ();
			var items = new Item[count];
			for (var z = 0; z < count; z++)
				items [z] = Item.ParseItem (_confList [i], _br);
			return items;
		}

		private List<byte[]> Offset100 ()
		{
		    var off100 = new List<byte[]> {_br.ReadBytes(4)};
		    var count = _br.ReadInt32 ();
			off100.Add (IntToByte (count));
			off100.Add (_br.ReadBytes (count));
			return off100;
		}

		private List<byte[]> List58 ()
		{
			var count = _br.ReadInt32 ();
		    var list59 = new List<byte[]> {IntToByte(count)};
		    for (int i = 0; i < count; i++) {
				list59.Add (_br.ReadBytes (132));
				int count2 = _br.ReadInt32 ();
				list59.Add (IntToByte (count2));
				for (var i2 = 0; i2 < count2; i2++) {
					list59.Add (_br.ReadBytes (8));
					var l = _br.ReadInt32 ();
					list59.Add (IntToByte (l));
					list59.Add (_br.ReadBytes (l * 2));
					var count3 = _br.ReadInt32 ();
					list59.Add (IntToByte (count3));
					list59.Add (_br.ReadBytes (count3 * 136));
				}
			}
			return list59;
		}

	    public Item GetFirstInList(int listID)
	    {
	        return GetListById(listID)[0];
	    }
		public void AddItem (string key, Item newItem)
		{
			var arr = new Item[Items [key].Length + 1];
		    newItem.GetByKey("ID");
			Array.Copy (Items [key], arr, Items [key].Length);
			arr [arr.Length - 1] = newItem;
			Items [key] = arr;
		}

	    public Item FindInList(int listID, int id)
	    {
	        foreach (var it in GetListById(listID).Where(it => it.GetByKey("ID") == id))
	            return it;
	        return null;
	    }

	    public int AddItem (int id, Item newItem,bool print = false)
		{
            if (ExistingId == null)
                ElementUtils.GetExsistingIDs(this);
			var key = GetListKey (id);
            if(ExistingId.Contains(newItem.GetByKey("ID"))) 
                newItem.SetByKey("ID",GetFreeId());
            if(print) PrintInfo(newItem);
			AddItem (key, newItem);
	        return newItem.GetByKey("ID");
		}

	    private static void PrintInfo(Item i)
	    {
	        Console.WriteLine("ID {0}{1} Name {2}",i.GetByKey("ID"),Environment.NewLine,
                UtilsIO.NormalizeString(i.GetByKey("Name")));
	    }
		public Item GetItem (string key, int pos)
		{
			return UtilsIO.DeepClone (Items [key] [pos]);
		}

		private static byte[] IntToByte (int val)
		{
			return BitConverter.GetBytes (val);;
		}

		private List<byte[]> Offset20 ()
		{
		    var off20 = new List<byte[]> {_br.ReadBytes(4)};
		    int count = _br.ReadInt32 ();
			_br.BaseStream.Position -= 4;
			off20.Add (_br.ReadBytes (count + 8));
			return off20;
		}
        
		public void Save (String newPath = null,bool zip = false)
		{
		    if (newPath == null) newPath = _path;
			var bw = new BinaryWriter (File.OpenWrite (newPath));
			WriteList (bw, _somevals [0]);
		    var l58 = _confList[58];
			_confList.Remove(l58);
			for (int i = 0; i < Items.Keys.Count; i++) {
				if (i == 20) {
					WriteList (bw, _somevals [20]);
				}
				if (i == 58) {
					WriteList (bw, _somevals [58]);
				}
				if (i == 99) {
					WriteList (bw, _somevals [100]);
				}
				var keys = Items.Keys;
				var currentKey = keys.ElementAt (i);
				bw.Write (Items [currentKey].Length);
				foreach (var item in Items[currentKey])
					item.Save (bw, _confList [i]);

			}
            _confList.Insert(58,l58);
            if(!zip)
                return;
		    using (var file = new ZipFile(_path+".zip"))
		    {
		        file.CompressionLevel = CompressionLevel.BestCompression;
		        file.ParallelDeflateThreshold = -1;
		        file.AddFile(_path);
                file.Save();
		    }

		}

		private static void WriteList (BinaryWriter bw, List<byte[]> ls)
		{
			foreach (var bb in ls)
				bw.Write (bb);
		}
	}
}
