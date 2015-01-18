using System;
using System.IO;

namespace JQEditor.Classes
{
    public class TITLE_AWARD
    {
        public int m_ulTitleID;
        public int m_lPeriod;

        internal static TITLE_AWARD Read(BinaryReader br)
        {
            TITLE_AWARD reader = new TITLE_AWARD();
            reader.m_ulTitleID = br.ReadInt32();
            reader.m_lPeriod = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, TITLE_AWARD writer)
        {
            bw.Write(writer.m_ulTitleID);
            bw.Write(writer.m_lPeriod);
        }
    }
}