using System;
using System.IO;

namespace JQEditor.Classes
{
    public class MONSTER_WANTED
    {
        public int m_ulMonsterTemplId;
        public int m_ulMonsterNum;
        public int m_ulDropItemId;
        public int m_ulDropItemCount;
        public bool m_bDropCmnItem;
        public float m_fDropProb;
        public bool m_bKillerLev;
        public int m_iDPH;
        public int m_iDPS;

        internal static MONSTER_WANTED Read(BinaryReader br)
        {
            MONSTER_WANTED reader = new MONSTER_WANTED();
            reader.m_ulMonsterTemplId = br.ReadInt32();
            reader.m_ulMonsterNum = br.ReadInt32();
            reader.m_ulDropItemId = br.ReadInt32();
            reader.m_ulDropItemCount = br.ReadInt32();
            reader.m_bDropCmnItem = br.ReadBoolean();
            reader.m_fDropProb = br.ReadSingle();
            reader.m_bKillerLev = br.ReadBoolean();
            reader.m_iDPH = br.ReadInt32();
            reader.m_iDPS = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, MONSTER_WANTED writer)
        {
            bw.Write(writer.m_ulMonsterTemplId);
            bw.Write(writer.m_ulMonsterNum);
            bw.Write(writer.m_ulDropItemId);
            bw.Write(writer.m_ulDropItemCount);
            bw.Write(writer.m_bDropCmnItem);
            bw.Write(writer.m_fDropProb);
            bw.Write(writer.m_bKillerLev);
            bw.Write(writer.m_iDPH);
            bw.Write(writer.m_iDPS);
        }
    }
}