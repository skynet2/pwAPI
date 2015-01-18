using System;
using System.IO;

namespace JQEditor.Classes
{
    public class AWARD_MONSTERS_SUMMONED
    {
        public int m_ulMonsterNum;
        public bool m_bRandChoose;
        public int m_ulSummonRadius;
        public bool m_bDeathDisappear;
        public MONSTERS_SUMMONED[] m_Monsters;

        internal static AWARD_MONSTERS_SUMMONED Read(BinaryReader br, int value)
        {
            AWARD_MONSTERS_SUMMONED reader = new AWARD_MONSTERS_SUMMONED();
            reader.m_bRandChoose = br.ReadBoolean();
            reader.m_ulSummonRadius = br.ReadInt32();
            reader.m_bDeathDisappear = br.ReadBoolean();
            reader.m_Monsters = new MONSTERS_SUMMONED[value];
            for (int i = 0; i < reader.m_Monsters.Length; ++i)
                reader.m_Monsters[i] = MONSTERS_SUMMONED.Read(br);
            return reader;
        }

        internal static void Write(BinaryWriter bw, AWARD_MONSTERS_SUMMONED writer)
        {
            bw.Write(writer.m_bRandChoose);
            bw.Write(writer.m_ulSummonRadius);
            bw.Write(writer.m_bDeathDisappear);
            for (int i = 0; i < writer.m_Monsters.Length; ++i)
                MONSTERS_SUMMONED.Write(bw, writer.m_Monsters[i]);
        }
    }
}