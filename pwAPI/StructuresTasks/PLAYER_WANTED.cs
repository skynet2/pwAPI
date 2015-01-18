using System;
using System.IO;

namespace JQEditor.Classes
{
    public class PLAYER_WANTED
    {
        public int m_ulPlayerNum;
        public int m_ulDropItemId;
        public int m_ulDropItemCount;
        public bool m_bDropCmnItem;
        public float m_fDropProb;
        public Kill_Player_Requirements m_Requirements;

        internal static PLAYER_WANTED Read(BinaryReader br)
        {
            PLAYER_WANTED reader = new PLAYER_WANTED();
            reader.m_ulPlayerNum = br.ReadInt32();
            reader.m_ulDropItemId = br.ReadInt32();
            reader.m_ulDropItemCount = br.ReadInt32();
            reader.m_bDropCmnItem = br.ReadBoolean();
            reader.m_fDropProb = br.ReadSingle();
            reader.m_Requirements = Kill_Player_Requirements.Read(br);
            return reader;
        }

        internal static void Write(BinaryWriter bw, PLAYER_WANTED writer)
        {
            bw.Write(writer.m_ulPlayerNum);
            bw.Write(writer.m_ulDropItemId);
            bw.Write(writer.m_ulDropItemCount);
            bw.Write(writer.m_bDropCmnItem);
            bw.Write(writer.m_fDropProb);
            Kill_Player_Requirements.Write(bw, writer.m_Requirements);
        }
    }
}