using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Util
	{
		private static char[] hexDigits;

		private const string PemStartStr = "-----BEGIN";

		private const string PemEndStr = "-----END";

		public static bool IsAsn1EncodedHexStr(string dataStr)
		{
			return false;
		}

		public static string FormatString(string inStr, int lineLen, int groupLen)
		{
			return null;
		}

		public static string GenStr(int len, char xch)
		{
			return null;
		}

		public static long BytesToLong(byte[] bytes)
		{
			return 0L;
		}

		public static string BytesToString(byte[] bytes)
		{
			return null;
		}

		public static byte[] StringToBytes(string msg)
		{
			return null;
		}

		public static bool IsEqual(byte[] source, byte[] target)
		{
			return false;
		}

		public static string ToHexString(byte[] bytes)
		{
			return null;
		}

		public static bool IsValidHexDigits(char ch)
		{
			return false;
		}

		public static byte GetHexDigitsVal(char ch)
		{
			return 0;
		}

		public static byte[] HexStrToBytes(string hexStr)
		{
			return null;
		}

		public static bool IsHexStr(string hexStr)
		{
			return false;
		}

		public static bool IsPemFormated(string pemStr)
		{
			return false;
		}

		public static bool IsPemFormatedFile(string fileName)
		{
			return false;
		}

		public static Stream PemToStream(string pemStr)
		{
			return null;
		}

		public static byte[] PemToBytes(string pemStr)
		{
			return null;
		}

		public static string BytesToPem(byte[] data)
		{
			return null;
		}

		public static string GetPemFileHeader(string fileName)
		{
			return null;
		}

		public static string GetPemHeader(string pemStr)
		{
			return null;
		}

		public static string BytesToPem(byte[] data, string pemHeader)
		{
			return null;
		}

		public static int BitPrecision(ulong ivalue)
		{
			return 0;
		}

		public static int BytePrecision(ulong value)
		{
			return 0;
		}

		public static int DERLengthEncode(Stream xdata, ulong length)
		{
			return 0;
		}

		public static long DerLengthDecode(Stream bt, ref bool isIndefiniteLength)
		{
			return 0L;
		}

		public static string GetTagName(byte tag)
		{
			return null;
		}

		private Asn1Util()
		{
		}
	}
}
