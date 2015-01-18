using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;

namespace pwAPI
{
	public class ElementReader
	{
		public Dictionary<string,Item[]> _items;
		private BinaryReader _br;
		private List<ConfigList> _confList;
		// SAVERS
		private Dictionary<byte,List<byte[]>> _somevals;

		public ElementReader (string configPath,string elementPath)
		{
			_confList = ConfigList.ParseList (configPath);
			_items = new Dictionary<string, Item[]>();
			_br = new BinaryReader (File.OpenRead(elementPath));
			_somevals = new Dictionary<byte, List<byte[]>>();
			List<byte[]> bb = new List<byte[]> ();
			bb.Add(_br.ReadBytes(8));
			_somevals.Add(0,bb);

			for (int i = 0; i < _confList.Count; i++) 
			{
				switch (i) {
				case 20:
					_somevals.Add(Convert.ToByte(i),offset20());
					_items.Add(_confList[i]._name,list(i));
					break;
				case 58:
					_somevals.Add(Convert.ToByte(i),list58());
					break;
					case 100:
					_somevals.Add(Convert.ToByte(i),offset100());
					list(i);
					break;
				default:
					_items.Add(_confList[i]._name,list(i));
					break;
				}
			}
			Console.WriteLine(Process.GetCurrentProcess().WorkingSet64);
			Console.WriteLine((GC.GetTotalMemory(true) / 1024f) / 1024f);
			_br.Dispose ();
			Console.WriteLine ("Readed");
	}
		private Item[] list(int i) {
			int count = _br.ReadInt32 ();
			Item[] items = new Item[count];
			for (int z = 0; z < count; z++)
				items [z] = Item.ParseItem(_confList [i],_br);
			return items;
				                    }
		private List<byte[]> offset100() {
			List<byte[]> off100 = new List<byte[]>();
			off100.Add(_br.ReadBytes(4));
			int count = _br.ReadInt32();
			off100.Add(IntToByte(count));
			off100.Add(_br.ReadBytes(count));
			return off100;
		}
		private List<byte[]> list58() {
			List<byte[]> list59 = new List<byte[]>();
			Console.WriteLine ("POS : " + _br.BaseStream.Position);
			int count = _br.ReadInt32();
			list59.Add(IntToByte(count));
			for (int i = 0; i < count; i++)
			{
				list59.Add(_br.ReadBytes(132));
				int count2 = _br.ReadInt32();
				list59.Add(IntToByte(count2));
				for (int i2 = 0; i2 < count2; i2++)
				{
					list59.Add(_br.ReadBytes(8));
					int l = _br.ReadInt32();
					list59.Add (IntToByte(l));
					list59.Add(_br.ReadBytes(l * 2));
					int count3 = _br.ReadInt32();
					list59.Add(IntToByte(count3));
					list59.Add(_br.ReadBytes(count3 * 136));
				}
			}
			return list59;
		}
		private static byte[] IntToByte(int val)
		{
			byte[] intBytes = BitConverter.GetBytes(val);
			Array.Reverse(intBytes);
			byte[] result = intBytes;
			return result;	}
		private List<byte[]> offset20() {
			List<byte[]> off20 = new List<byte[]>();
			off20.Add(_br.ReadBytes(4));
			int count = _br.ReadInt32();
			_br.BaseStream.Position -= 4;
			off20.Add(_br.ReadBytes(count + 8));
			          return off20;
		}
}
}
