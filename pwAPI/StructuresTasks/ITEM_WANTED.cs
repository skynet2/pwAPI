using System;
using System.IO;

namespace JQEditor.Classes
{
    public class ITEM_WANTED
    {
        public int m_ulItemTemplId;
        public bool m_bCommonItem;
        public int m_ulItemNum;
        public float m_fProb;
        public int m_lPeriod;

        internal static ITEM_WANTED Read(BinaryReader br)
        {
            ITEM_WANTED reader = new ITEM_WANTED();
            reader.m_ulItemTemplId = br.ReadInt32();
            reader.m_bCommonItem = br.ReadBoolean();
            reader.m_ulItemNum = br.ReadInt32();
            reader.m_fProb = br.ReadSingle();
            reader.m_lPeriod = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, ITEM_WANTED writer)
        {
            bw.Write(writer.m_ulItemTemplId);
            bw.Write(writer.m_bCommonItem);
            bw.Write(writer.m_ulItemNum);
            bw.Write(writer.m_fProb);
            bw.Write(writer.m_lPeriod);
        }
    }
}