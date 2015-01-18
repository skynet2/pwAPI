using System;
using System.IO;

namespace JQEditor.Classes
{
    public class COMPARE_KEY_VALUE
    {
        public int nLeftType;
        public int lLeftNum;
        public int nCompOper;
        public int nRightType;
        public int lRightNum;

        internal static COMPARE_KEY_VALUE Read(BinaryReader br)
        {
            COMPARE_KEY_VALUE reader = new COMPARE_KEY_VALUE();
            reader.nLeftType = br.ReadInt32();
            reader.lLeftNum = br.ReadInt32();
            reader.nCompOper = br.ReadInt32();
            reader.nRightType = br.ReadInt32();
            reader.lRightNum = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, COMPARE_KEY_VALUE writer)
        {
            bw.Write(writer.nLeftType);
            bw.Write(writer.lLeftNum);
            bw.Write(writer.nCompOper);
            bw.Write(writer.nRightType);
            bw.Write(writer.lRightNum);
        }
    }
}