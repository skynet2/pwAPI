using System;
using System.IO;
using System.Text;

namespace pwAPI
{
	public class TasksExtensions
	{
		public static string ReadTaskChar(BinaryReader br, int lth, int key, int ofs = 0)
		{
			byte[] data = br.ReadBytes(lth);
			if (lth % 2 != 0 || data == null) return null;
			string DecypheredString = string.Empty;
			byte[] keyB = BitConverter.GetBytes((short)key);
			for (int i = 0; i < lth; i += 2)
			{
				char w = Encoding.Unicode.GetChars(new byte[] { (byte)(data[ofs + i] ^ keyB[i % 2]), (byte)(data[ofs + i + 1] ^ keyB[i % 2 + 1]) })[0];
				if (w != (char)0x00) DecypheredString += w; else break;
			}
			return DecypheredString;
		}
		public static void WriteTaskChar(BinaryWriter bw, string data, int maxLength, int key)
		{
			byte[] CypheredData = new byte[2 * maxLength];
			byte[] keyB = BitConverter.GetBytes((short)key);
			byte[] dataB = Encoding.Unicode.GetBytes(data);
			int num = data.Length;
			for (int i = 0; i < data.Length && i < maxLength - 1; i++)
			{
				CypheredData[2 * i] = (byte)(dataB[2 * i] ^ keyB[(2 * i) % 2]);
				CypheredData[2 * i + 1] = (byte)(dataB[2 * i + 1] ^ keyB[(2 * i) % 2 + 1]);
				if (data[i] == 0x00)
				{
					num = i + 1;
					break;
				}
			}
			for (; num < maxLength; num++)
			{
				CypheredData[2 * num] = keyB[(2 * num) % 2];
				CypheredData[2 * num + 1] = keyB[(2 * num) % 2 + 1];
			}
			bw.Write(CypheredData);
		}
		public static string Decrypt(int key, byte[] text)
		{
			string result = "";
			byte[] dbyte = new byte[2];
			for (int i = 0; i < text.Length; i += 2)
			{
				dbyte = BitConverter.GetBytes((short)key);
				dbyte[0] ^= text[i];
				dbyte[1] ^= text[i + 1];
				result += BitConverter.ToChar(dbyte, 0);
			}
			return result.TrimEnd(new char[] { '\0' });
		}
		public static byte[] Encrypt(int key, string text, int length, bool appendZero)
		{
			byte[] result;

			if (appendZero)
				result = new byte[length + 2];
			else
				result = new byte[length];

			byte[] dbyte = new byte[2];

			for (int i = 0; i < result.Length; i += 2)
			{
				dbyte = BitConverter.GetBytes((short)key);
				result[i] = dbyte[0];
				result[i + 1] = dbyte[1];

				if (i / 2 < text.Length)
				{
					dbyte = BitConverter.GetBytes(text[i / 2]);
					result[i] ^= dbyte[0];
					result[i + 1] ^= dbyte[1];
				}
			}
			return result;
		}
		public static string ByteArrayToHexString(byte[] value)
		{
			return BitConverter.ToString(value);
		}
		public static byte[] HexStringToByteArray(string value)
		{
			char[] chArray = new char[1]
			{
				'-'
			};
			string[] strArray = value.Split(chArray);
			byte[] numArray = new byte[strArray.Length];
			for (int i = 0; i < strArray.Length; ++i)
				numArray[i] = Convert.ToByte(strArray[i], 16);
			return numArray;
		}
		public static string ByteArrayToGbkString(byte[] text)
		{
			Encoding encoding = Encoding.GetEncoding("GBK");
			char[] chArray = new char[1]
			{
				char.MinValue
			};
			return encoding.GetString(text).Split(chArray)[0];
		}
		public static byte[] GbkStringToByteArray(string text, int length)
		{
			Encoding encoding = Encoding.GetEncoding("GBK");
			byte[] numArray1 = new byte[length];
			byte[] bytes = encoding.GetBytes(text);
			if (numArray1.Length > bytes.Length)
			{
				Array.Copy((Array)bytes, (Array)numArray1, bytes.Length);
			}
			else
			{
				byte[] numArray2 = bytes;
				byte[] numArray3 = numArray1;
				int length1 = numArray3.Length;
				Array.Copy((Array)numArray2, (Array)numArray3, length1);
			}
			return numArray1;
		}
		public static string ByteArrayToUnicodeString(byte[] text)
		{
			Encoding encoding = Encoding.GetEncoding("Unicode");
			char[] chArray = new char[1]
			{
				char.MinValue
			};
			return encoding.GetString(text).Split(chArray)[0];
		}
		public static byte[] UnicodeStringToByteArray(string text, int length)
		{
			Encoding encoding = Encoding.GetEncoding("Unicode");
			byte[] numArray1 = new byte[length];
			byte[] bytes = encoding.GetBytes(text);
			if (numArray1.Length > bytes.Length)
			{
				Array.Copy((Array)bytes, (Array)numArray1, bytes.Length);
			}
			else
			{
				byte[] numArray2 = bytes;
				byte[] numArray3 = numArray1;
				int length1 = numArray3.Length;
				Array.Copy((Array)numArray2, (Array)numArray3, length1);
			}
			return numArray1;
		}
	}
	}

