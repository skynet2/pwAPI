using System;
using System.IO;

namespace JQEditor.Classes
{
    public class AWARD_PQ_RANKING
    {
        public bool m_bAwardByProf;
        public int m_ulRankingAwardNum;
        public RANKING_AWARD[] m_RankingAward;

        internal static AWARD_PQ_RANKING Read(BinaryReader br, int value)
        {
            AWARD_PQ_RANKING reader = new AWARD_PQ_RANKING();
            reader.m_bAwardByProf = br.ReadBoolean();
            reader.m_RankingAward = new RANKING_AWARD[value];
            for (int i = 0; i < reader.m_RankingAward.Length; ++i)
                reader.m_RankingAward[i] = RANKING_AWARD.Read(br);
            return reader;
        }

        internal static void Write(BinaryWriter bw, AWARD_PQ_RANKING writer)
        {
            bw.Write(writer.m_bAwardByProf);
            for (int i = 0; i < writer.m_RankingAward.Length; ++i)
                RANKING_AWARD.Write(bw, writer.m_RankingAward[i]);
        }
    }
}