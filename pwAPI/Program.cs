using System;
using System.IO;
using System.Collections.Generic;
using pwAPI.Readers;

namespace pwAPI
{
	class MainClass
	{
		public static void Main ()
		{
            var rus = new ElementReader(@"C:\work\PW_1.5.1_v101.cfg", @"C:\work\elements.data");
		    var china = new ElementReader(@"C:\work\PW_1.5.2_v127.cfg", @"C:\chinaPW\element\data\elements.data");
		    Utils.ElementUtils.AddUniqFly(rus, china);
            Utils.ElementUtils.AddUniqStyles(rus,china);
            rus.Save(@"C:\work\elements+china.data");
            //var epic = new ElementReader(@"C:\work\PW_1.5.1_v101.cfg", @"C:\Epic Perfect World\element\info\info.pck");
            //Utils.ElementUtils.AddUniqFly(rus,epic);
		    //Utils.ElementUtils.AddUniqStyles(rus, epic);
            //rus.Save(@"C:\work\elements+epic.data");
           // var shop = new GShopReader(@"C:\work\gshop1.data");
		    //Utils.GShopUtils.CleanUp(shop,rus);
            //Utils.GShopUtils.AddWeapons(shop, rus);
            //Utils.GShopUtils.AddStyles(shop, rus);
            //shop.Save(@"C:\work\gshop2.data");
            //Utils.GShopUtils.AddStyles(shop, rus);
            //shop.Save(@"C:\work\gshop103.data");
			Console.ReadKey ();
		}
	}
}
