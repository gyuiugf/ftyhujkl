using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Parser
	{
		private byte[] rawData;

		private Asn1Node rootNode;

		private bool ParseEncapsulatedData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public byte[] RawData => null;

		public Asn1Node RootNode => null;

		public void LoadData(string fileName)
		{
		}

		public void LoadPemData(string fileName)
		{
		}

		public void LoadData(Stream stream)
		{
		}

		public void SaveData(string fileName)
		{
		}

		public Asn1Node GetNodeByPath(string nodePath)
		{
			return null;
		}

		public Asn1Node GetNodeByOid(string oid)
		{
			return null;
		}

		public static string GetNodeTextHeader(int lineLen)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static string GetNodeText(Asn1Node node, int lineLen)
		{
			return null;
		}
	}
}
