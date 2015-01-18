using System;
using System.IO;

namespace JQEditor.Classes
{
    public class AWARD_ITEMS_CAND
    {
        public int m_ulAwardItems;
        public int m_ulAwardCmnItems;
        public int m_ulAwardTskItems;
        public ITEM_WANTED[] m_AwardItems;
        public bool m_bRandChoose;

        internal static AWARD_ITEMS_CAND Read(BinaryReader br)
        {
            AWARD_ITEMS_CAND reader = new AWARD_ITEMS_CAND();
            reader.m_bRandChoose = br.ReadBoolean();
            reader.m_ulAwardItems = br.ReadInt32();
            reader.m_AwardItems = new ITEM_WANTED[reader.m_ulAwardItems];
            for (int i = 0; i < reader.m_AwardItems.Length; ++i)
                reader.m_AwardItems[i] = ITEM_WANTED.Read(br);
            return reader;
        }

        internal static void Write(BinaryWriter bw, AWARD_ITEMS_CAND writer)
        {
            bw.Write(writer.m_bRandChoose);
            bw.Write(writer.m_ulAwardItems);
            for (int i = 0; i < writer.m_AwardItems.Length; ++i)
                ITEM_WANTED.Write(bw, writer.m_AwardItems[i]);
        }
    }
}