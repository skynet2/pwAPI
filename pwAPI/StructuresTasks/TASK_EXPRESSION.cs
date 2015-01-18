using System;
using System.IO;

namespace JQEditor.Classes
{
    public class TASK_EXPRESSION
    {
        public int[] type;
        public float[] value;

        internal static TASK_EXPRESSION Read(BinaryReader br)
        {
            TASK_EXPRESSION reader = new TASK_EXPRESSION();
            reader.type = new int[64];
            reader.value = new float[64];
            for (int i = 0; i < reader.type.Length; ++i)
            {
                reader.type[i] = br.ReadInt32();
                reader.value[i] = br.ReadSingle();
            }
            return reader;
        }

        internal static void Write(BinaryWriter bw, TASK_EXPRESSION writer)
        {
            for (int i = 0; i < writer.type.Length; ++i)
            {
                bw.Write(writer.type[i]);
                bw.Write(writer.value[i]);
            }
        }
    }
}