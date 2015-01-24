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
            HashSet<string> stylesPaths;
            HashSet<string> weaponsPaths;
            HashSet<string> flyPaths;
            var ggpw = new ElementReader(@"C:\work\PW_1.5.1_v101.cfg", @"C:\work\elements.data");
            var epic = new ElementReader(@"C:\work\PW_1.5.1_v101.cfg", @"C:\Epic Perfect World\element\info\info.pck");
		    var china = new ElementReader(@"C:\work\PW_1.5.2_v127.cfg", @"C:\chinaPW\element\data\elements.data");
            Utils.ElementUtils.AddUniqStyles(ggpw, epic, out stylesPaths, out weaponsPaths);
            Utils.ElementUtils.AddUniqStyles(ggpw,china, out stylesPaths, out weaponsPaths);
            ggpw.Save(@"C:\work\elements_f.data",true);
			Console.ReadKey ();
		}
	}
}
