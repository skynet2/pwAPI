using System;
using System.IO;

namespace JQEditor.Classes
{
    public class task_tm
    {
        public int year;
        public int month;
        public int day;
        public int hour;
        public int min;
        public int wday;

        internal static task_tm Read(BinaryReader br)
        {
            task_tm reader = new task_tm();
            reader.year = br.ReadInt32();
            reader.month = br.ReadInt32();
            reader.day = br.ReadInt32();
            reader.hour = br.ReadInt32();
            reader.min = br.ReadInt32();
            reader.wday = br.ReadInt32();
            return reader;
        }

        internal static void Write(BinaryWriter bw, task_tm writer)
        {
            bw.Write(writer.year);
            bw.Write(writer.month);
            bw.Write(writer.day);
            bw.Write(writer.hour);
            bw.Write(writer.min);
            bw.Write(writer.wday);
        }
    }
}