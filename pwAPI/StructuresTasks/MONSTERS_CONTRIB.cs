using System;
using System.IO;

namespace JQEditor.Classes
{
    public class MONSTERS_CONTRIB
    {
        public int m_ulMonsterTemplId;
        public int m_iWholeContrib;
        public int m_iShareContrib;
        public int m_iPersonalWholeContrib;

        internal static MONSTERS_CONTRIB Read(BinaryReader br)
        {
            MONSTERS_CONTRIB reader = new MONSTERS_CONTRIB();
            reader.m_ulMonsterTemplId = br.ReadInt32();
            reader.m_iWholeContrib = br.ReadInt32();
            reader.m_iShareContrib = br.ReadInt32();
            reader.m_iPersonalWholeContrib = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, MONSTERS_CONTRIB writer)
        {
            bw.Write(writer.m_ulMonsterTemplId);
            bw.Write(writer.m_iWholeContrib);
            bw.Write(writer.m_iShareContrib);
            bw.Write(writer.m_iPersonalWholeContrib);
        }
    }
}