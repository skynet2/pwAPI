using System;
using System.IO;

namespace JQEditor.Classes
{
    public class AWARD_RATIO_SCALE
    {
        public int m_ulScales;
        public float[] m_Ratios;
        public AWARD_DATA[] m_Awards;

        internal static AWARD_RATIO_SCALE Read(BinaryReader br, int version)
        {
            AWARD_RATIO_SCALE reader = new AWARD_RATIO_SCALE();
            reader.m_ulScales = br.ReadInt32();
            reader.m_Ratios = new float[5];
            for (int i = 0; i < reader.m_Ratios.Length; ++i)
                reader.m_Ratios[i] = br.ReadSingle();
            reader.m_Awards = new AWARD_DATA[reader.m_ulScales];
            for (int i = 0; i < reader.m_Awards.Length; ++i)
                reader.m_Awards[i] = AWARD_DATA.Read(br, version);
            return reader;
        }

        internal static void Write(BinaryWriter bw, int version, AWARD_RATIO_SCALE writer)
        {
            bw.Write(writer.m_ulScales);
            for (int i = 0; i < writer.m_Ratios.Length; ++i)
                bw.Write(writer.m_Ratios[i]);
            for (int i = 0; i < writer.m_Awards.Length; ++i)
                AWARD_DATA.Write(bw, version, writer.m_Awards[i]);
        }
    }
}