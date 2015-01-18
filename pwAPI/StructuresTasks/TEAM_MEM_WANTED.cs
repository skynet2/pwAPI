using System;
using System.IO;

namespace JQEditor.Classes
{
    public class TEAM_MEM_WANTED
    {
        public int m_ulLevelMin;
        public int m_ulLevelMax;
        public int m_ulRace;
        public int m_ulOccupation;
        public int m_ulGender;
        public int m_ulMinCount;
        public int m_ulMaxCount;
        public int m_ulTask;
        public int m_iForce;

        internal static TEAM_MEM_WANTED Read(BinaryReader br)
        {
            TEAM_MEM_WANTED reader = new TEAM_MEM_WANTED();
            reader.m_ulLevelMin = br.ReadInt32();
            reader.m_ulLevelMax = br.ReadInt32();
            reader.m_ulRace = br.ReadInt32();
            reader.m_ulOccupation = br.ReadInt32();
            reader.m_ulGender = br.ReadInt32();
            reader.m_ulMinCount = br.ReadInt32();
            reader.m_ulMaxCount = br.ReadInt32();
            reader.m_ulTask = br.ReadInt32();
            reader.m_iForce = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, TEAM_MEM_WANTED writer)
        {
            bw.Write(writer.m_ulLevelMin);
            bw.Write(writer.m_ulLevelMax);
            bw.Write(writer.m_ulRace);
            bw.Write(writer.m_ulOccupation);
            bw.Write(writer.m_ulGender);
            bw.Write(writer.m_ulMinCount);
            bw.Write(writer.m_ulMaxCount);
            bw.Write(writer.m_ulTask);
            bw.Write(writer.m_iForce);
        }
    }
}