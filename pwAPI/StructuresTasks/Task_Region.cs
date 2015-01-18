using System;
using System.IO;

namespace JQEditor.Classes
{
    public class Task_Region
    {
        public ZONE_VERT zvMin;
        public ZONE_VERT zvMax;

        internal static Task_Region Read(BinaryReader br)
        {
            Task_Region reader = new Task_Region();
            reader.zvMin = ZONE_VERT.Read(br);
            reader.zvMax = ZONE_VERT.Read(br);
            return reader;
        }

        internal static void Write(BinaryWriter bw, Task_Region writer)
        {
            ZONE_VERT.Write(bw, writer.zvMin);
            ZONE_VERT.Write(bw, writer.zvMax);
        }
    }
}