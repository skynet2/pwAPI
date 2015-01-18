using System;
using System.IO;

namespace JQEditor.Classes
{
    public class MONSTERS_SUMMONED
    {
        public int m_ulMonsterTemplId;
        public int m_ulMonsterNum;
        public float m_fSummonProb;
        public int m_lPeriod;

        internal static MONSTERS_SUMMONED Read(BinaryReader br)
        {
            MONSTERS_SUMMONED reader = new MONSTERS_SUMMONED();
            reader.m_ulMonsterTemplId = br.ReadInt32();
            reader.m_ulMonsterNum = br.ReadInt32();
            reader.m_fSummonProb = br.ReadSingle();
            reader.m_lPeriod = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, MONSTERS_SUMMONED writer)
        {
            bw.Write(writer.m_ulMonsterTemplId);
            bw.Write(writer.m_ulMonsterNum);
            bw.Write(writer.m_fSummonProb);
            bw.Write(writer.m_lPeriod);
        }
    }
}