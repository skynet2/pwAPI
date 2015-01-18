using System;
using System.IO;

namespace JQEditor.Classes
{
    public class ZONE_VERT
    {
        public float x;
        public float y;
        public float z;

        internal static ZONE_VERT Read(BinaryReader br)
        {
            ZONE_VERT reader = new ZONE_VERT();
            reader.x = br.ReadSingle();
            reader.y = br.ReadSingle();
            reader.z = br.ReadSingle();
            return reader;
        }

        internal static void Write(BinaryWriter bw, ZONE_VERT writer)
        {
            bw.Write(writer.x);
            bw.Write(writer.y);
            bw.Write(writer.z);
        }
    }
}