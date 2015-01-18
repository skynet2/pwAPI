using System;
using System.IO;

namespace JQEditor.Classes
{
    public class AWARD_ITEMS_SCALE
    {
        public int m_ulScales;
        public int m_ulItemId;
        public int[] m_Counts;
        public AWARD_DATA[] m_Awards;

        internal static AWARD_ITEMS_SCALE Read(BinaryReader br, int version)
        {
            AWARD_ITEMS_SCALE reader = new AWARD_ITEMS_SCALE();
            reader.m_ulScales = br.ReadInt32();
            reader.m_ulItemId = br.ReadInt32();
            reader.m_Counts = new int[5];
            for (int i = 0; i < reader.m_Counts.Length; ++i)
                reader.m_Counts[i] = br.ReadInt32();
            reader.m_Awards = new AWARD_DATA[reader.m_ulScales];
            for (int i = 0; i < reader.m_Awards.Length; ++i)
                reader.m_Awards[i] = AWARD_DATA.Read(br, version);
            return reader;
        }

        internal static void Write(BinaryWriter bw, int version, AWARD_ITEMS_SCALE writer)
        {
            bw.Write(writer.m_ulScales);
            bw.Write(writer.m_ulItemId);
            for (int i = 0; i < writer.m_Counts.Length; ++i)
                bw.Write(writer.m_Counts[i]);
            for (int i = 0; i < writer.m_Awards.Length; ++i)
                AWARD_DATA.Write(bw, version, writer.m_Awards[i]);
        }
    }
}