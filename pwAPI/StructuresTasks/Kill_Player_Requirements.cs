using System;
using System.IO;

namespace JQEditor.Classes
{
    public class Kill_Player_Requirements
    {
        public int m_ulOccupations;
        public int m_iMinLevel;
        public int m_iMaxLevel;
        public int m_iGender;
        public int m_iForce;

        internal static Kill_Player_Requirements Read(BinaryReader br)
        {
            Kill_Player_Requirements reader = new Kill_Player_Requirements();
            reader.m_ulOccupations = br.ReadInt32();
            reader.m_iMinLevel = br.ReadInt32();
            reader.m_iMaxLevel = br.ReadInt32();
            reader.m_iGender = br.ReadInt32();
            reader.m_iForce = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, Kill_Player_Requirements writer)
        {
            bw.Write(writer.m_ulOccupations);
            bw.Write(writer.m_iMinLevel);
            bw.Write(writer.m_iMaxLevel);
            bw.Write(writer.m_iGender);
            bw.Write(writer.m_iForce);
        }
    }
}