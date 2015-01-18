using System;
using System.IO;
using System.Collections.Generic;

namespace pwAPI
{
	public class CELPrecinct
	{
		public int m_idDstInst { get; set; }
		public int m_idSrcInst { get; set; }
		public int m_iPriority { get; set; }
		//public VECTOR3 m_vCityPos { get; set; }
		public int m_idDomain { get; set; }
		public bool m_bPKProtect { get; set; }
		public float m_fLeft { get; set; }
		public float m_fTop { get; set; }
		public float m_fRight { get; set; }
		//public float m_fBottom { get; set; }
		public int m_iPointsCnt { get; set; }
		public List<VECTOR3> m_aPoints { get; set; }

		public CELPrecinct (BinaryReader br)
		{
			if (m_aPoints == null)
				m_aPoints = new List<VECTOR3> ();
				m_iPointsCnt = br.ReadInt32();
				m_idDstInst = br.ReadInt32();
				m_idSrcInst = br.ReadInt32();
				m_iPriority = br.ReadInt32();
				//m_vCityPos = new VECTOR3(br);
				m_idDomain = br.ReadInt32();
				m_bPKProtect = br.ReadBoolean();
				m_fLeft = br.ReadSingle();
				m_fTop = br.ReadSingle();
				m_fRight = br.ReadSingle();
				//m_fBottom = br.ReadSingle();
				for (int i = 0; i < m_iPointsCnt; i++)
					m_aPoints.Add(new VECTOR3(br));
		}
		public void Write(BinaryWriter bw) {
			bw.Write(m_aPoints.Count);
			bw.Write(m_idDstInst);
			bw.Write(m_idSrcInst);
			bw.Write(m_iPriority);
			//m_vCityPos.Save(bw);
			bw.Write(m_idDomain);
			bw.Write(m_bPKProtect);
			bw.Write(m_fLeft);
			bw.Write(m_fTop);
			bw.Write(m_fRight);
			//bw.Write(m_fBottom);
			for (int i = 0; i < m_aPoints.Count; i++)
				m_aPoints[i].Write(bw);
		}
		}
	public class VECTOR3
	{
		public override string ToString() {
			return string.Format("{0}", "Vector");
		}
		public float x { get; set; }
		public float y { get; set; }
		public float z { get; set; }

		public VECTOR3(BinaryReader br) {
			x = br.ReadSingle();
			y = br.ReadSingle();
			z = br.ReadSingle();
		}

		public void Write(BinaryWriter bw) {
			bw.Write(x);
			bw.Write(y);
			bw.Write(z);
		}

		public VECTOR3() {

		}

		public VECTOR3 Clone() {
			using (MemoryStream ms = new MemoryStream()) {
				using (BinaryReader br = new BinaryReader(ms)) {
					using (BinaryWriter bw = new BinaryWriter(ms)) {
						Write(bw);
						br.BaseStream.Seek(0, SeekOrigin.Begin);
						return new VECTOR3(br);
					}
				}
			}
		}
	}
}