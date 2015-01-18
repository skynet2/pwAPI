using System;
using System.Collections.Generic;
using System.Linq;
using pwAPI.Readers;
using pwAPI.StructuresElement;
using Type = pwAPI.Enums.Style.Type;

namespace pwAPI.Utils
{
	public class ElementUtils
	{
		public static void GetExsistingIDs (ElementReader element)
		{
			var ids = new HashSet<int> ();
			foreach (var key in element.Items.Keys) {
				if (key.Contains ("070")) 
					continue;
				foreach (var it in element.Items[key]) {
					ids.Add (it.GetByKey ("ID"));
				}
			}
			element.ExistingId = ids;
		}

	    private static Item AdvancedCopy(Item oldItem, Item newItem)
	    {
	         if (oldItem.Values.Length == newItem.Values.Length) return newItem;
	        var temp = UtilsIO.DeepClone(oldItem);
	        for (int i = 0; i < temp.Values.Length / 2; i++)
	        {
	            string key = temp.Values[i, 0];
	            temp.SetByKey(key,newItem.GetByKey(key));
	        }
	        return temp;
	    }

	    public static void AddUniqFly(ElementReader oldElem, ElementReader newElem)
	    {
            foreach (var newIt in newElem.GetListById(23))
            {
                var flag = oldElem.GetListById(23).All(oldIt => !newIt.GetByKey("file_model").Equals(oldIt.GetByKey("file_model")));
                if(flag)
                    oldElem.AddItem(23, AdvancedCopy(oldElem.GetListById(23)[0],newIt), true, true);
	        }
	    }
		public static void AddUniqStyles(ElementReader oldElem, ElementReader newElem)
		{
			foreach(var i in FindUniqStyles(oldElem,newElem))
			{
			    
				oldElem.AddItem (84, AdvancedCopy(oldElem.GetListById(84)[0], i),true,true);
			}
		}
        private static List<Item> FindUniqStyles(ElementReader oldElem, ElementReader newElem)
        {
            var result = new List<Item>();
            foreach (var newItem in newElem.GetListById(84))
            {
                var flag = true;
                foreach (var oldItem in oldElem.GetListById(84))
                {
                    if (newItem.GetByKey("id_major_type") != (int)Type.Weapon)
                    {
                        if (newItem.GetByKey("gender") == oldItem.GetByKey("gender") &&
                            newItem.GetByKey("realname") == oldItem.GetByKey("realname"))
                        {
                            flag = false;
                            break;
                        }
                    }
                    else if (newItem.GetByKey("file_model_right").Equals(oldItem.GetByKey("file_model_right")) ||
                             newItem.GetByKey("file_model_left").Equals(oldItem.GetByKey("file_model_left")))
                    {
                        flag = false;
                        break;
                    }
                }
                if (flag)
                    result.Add(newItem);
            }
            return result;
        }

		public static void Translate (ElementReader fromT, ElementReader toT)
		{
		    for (var i = 0; i < toT.Items.Keys.Count; i++)
		    {
		        foreach (var toItem in toT.GetListById(i))
		        {
		            var item = toItem;
		            foreach (var fromIt in fromT.GetListById(i).Where(fromIt => item.GetByKey("ID") == fromIt.GetByKey("ID")))
		            {
		                toItem.SetByKey("Name", fromIt.GetByKey("Name"));
                        break;
		            }
		        }
		    }
		}
	}
}

