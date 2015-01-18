using System;
using System.IO;

namespace JQEditor.Classes
{
    public class RANKING_AWARD
    {
        public int m_iRankingStart;
        public int m_iRankingEnd;
        public bool m_bCommonItem;
        public int m_ulAwardItemId;
        public int m_ulAwardItemNum;
        public int m_lPeriod;

        internal static RANKING_AWARD Read(BinaryReader br)
        {
            RANKING_AWARD reader = new RANKING_AWARD();
            reader.m_iRankingStart = br.ReadInt32();
            reader.m_iRankingEnd = br.ReadInt32();
            reader.m_bCommonItem = br.ReadBoolean();
            reader.m_ulAwardItemId = br.ReadInt32();
            reader.m_ulAwardItemNum = br.ReadInt32();
            reader.m_lPeriod = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, RANKING_AWARD writer)
        {
            bw.Write(writer.m_iRankingStart);
            bw.Write(writer.m_iRankingEnd);
            bw.Write(writer.m_bCommonItem);
            bw.Write(writer.m_ulAwardItemId);
            bw.Write(writer.m_ulAwardItemNum);
            bw.Write(writer.m_lPeriod);
        }
    }
}