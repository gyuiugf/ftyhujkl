using System.Collections;
using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class Asn1Node : IAsn1Node
	{
		public class TagTextMask
		{
			public const uint SHOW_OFFSET = 1u;

			public const uint SHOW_DATA = 2u;

			public const uint USE_HEX_OFFSET = 4u;

			public const uint SHOW_TAG_NUMBER = 8u;

			public const uint SHOW_PATH = 16u;
		}

		private byte tag;

		private long dataOffset;

		private long dataLength;

		private long lengthFieldBytes;

		private byte[] data;

		private ArrayList childNodeList;

		private byte unusedBits;

		private long deepness;

		private string path;

		private const int indentStep = 3;

		private Asn1Node parentNode;

		private bool requireRecalculatePar;

		private bool isIndefiniteLength;

		private bool parseEncapsulatedData;

		public const int defaultLineLen = 80;

		public const int minLineLen = 60;

		private const int k_EndOfStream = -1;

		private const int k_InvalidIndeterminateContentLength = -1;

		private const int k_IndefiniteLengthFooterSize = 2;

		public const int TagLength = 1;

		public const int BitStringUnusedFiledLength = 1;

		public bool IsIndefiniteLength
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public byte Tag
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		public byte MaskedTag => 0;

		public bool IsEmptyData => false;

		public long ChildNodeCount => 0L;

		public string TagName => null;

		public Asn1Node ParentNode => null;

		public string Path => null;

		public long DataLength => 0L;

		public long LengthFieldBytes => 0L;

		public byte[] Data
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long Deepness => 0L;

		public long DataOffset => 0L;

		public byte UnusedBits
		{
			get
			{
				return 0;
			}
			set
			{
			}
		}

		protected bool RequireRecalculatePar
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		public bool ParseEncapsulatedData
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private Asn1Node(Asn1Node parentNode, long dataOffset)
		{
		}

		private void Init()
		{
		}

		private string GetHexPrintingStr(Asn1Node startNode, string baseLine, string lStr, int lineLen)
		{
			return null;
		}

		private string FormatLineString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		private string FormatLineHexString(string lStr, int indent, int lineLen, string msg)
		{
			return null;
		}

		public Asn1Node()
		{
		}

		public Asn1Node Clone()
		{
			return null;
		}

		public bool LoadData(byte[] byteData)
		{
			return false;
		}

		public static long GetDescendantNodeCount(Asn1Node node)
		{
			return 0L;
		}

		public bool LoadData(Stream xdata)
		{
			return false;
		}

		public byte[] GetRawData()
		{
			return null;
		}

		public bool SaveData(Stream xdata)
		{
			return false;
		}

		public void ClearAll()
		{
		}

		public void AddChild(Asn1Node xdata)
		{
		}

		public int InsertChild(Asn1Node xdata, int index)
		{
			return 0;
		}

		public int InsertChild(Asn1Node xdata, Asn1Node indexNode)
		{
			return 0;
		}

		public int InsertChildAfter(Asn1Node xdata, Asn1Node indexNode)
		{
			return 0;
		}

		public int InsertChildAfter(Asn1Node xdata, int index)
		{
			return 0;
		}

		public Asn1Node RemoveChild(int index)
		{
			return null;
		}

		private Asn1Node GetLastChild()
		{
			return null;
		}

		public Asn1Node RemoveChild(Asn1Node node)
		{
			return null;
		}

		public Asn1Node GetChildNode(int index)
		{
			return null;
		}

		public string GetText(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		public string GetDataStr(bool pureHexMode)
		{
			return null;
		}

		public string GetLabel(uint mask)
		{
			return null;
		}

		public Asn1Node GetDescendantNodeByPath(string nodePath)
		{
			return null;
		}

		public static Asn1Node GetDecendantNodeByOid(string oid, Asn1Node startNode)
		{
			return null;
		}

		protected void RecalculateTreePar()
		{
		}

		protected static long ResetBranchDataLength(Asn1Node node)
		{
			return 0L;
		}

		protected static void ResetDataLengthFieldWidth(Asn1Node node)
		{
		}

		protected void ResetChildNodePar(Asn1Node xNode, long subOffset)
		{
		}

		protected string GetListStr(Asn1Node startNode, int lineLen)
		{
			return null;
		}

		protected string GetIndentStr(Asn1Node startNode)
		{
			return null;
		}

		protected bool GeneralDecode(Stream xdata)
		{
			return false;
		}

		private bool AreTagsOk()
		{
			return false;
		}

		private bool GeneralDecodeKnownLengthWithChecks(Stream xdata, long start, long nodeMaxLen)
		{
			return false;
		}

		private bool IsGeneralStreamLengthOk(Stream xdata, long start, long nodeMaxLen)
		{
			return false;
		}

		private bool GeneralDecodeKnownLength(Stream xdata)
		{
			return false;
		}

		private void ReadStreamDataDefiniteLength(Stream xdata, int length)
		{
		}

		private bool GeneralDecodeIndefiniteLength(Stream xdata, long nodeMaxLen)
		{
			return false;
		}

		private bool ReadStreamDataIndefiniteLength(Stream xdata, long nodeMaxLen)
		{
			return false;
		}

		private long MeasureContentLength(Stream xdata)
		{
			return 0L;
		}

		private void ReadMeasuredLengthDataFromStart(Stream xdata, long startPosition, long length)
		{
		}

		protected bool ListDecode(Stream xdata)
		{
			return false;
		}

		private bool ListDecodeKnownLengthWithChecks(Stream xdata, long start, long childNodeMaxLen)
		{
			return false;
		}

		private bool IsListStreamLengthOk(Stream xdata, long childNodeMaxLen)
		{
			return false;
		}

		private bool ListDecodeKnownLength(Stream xdata, long start)
		{
			return false;
		}

		private long CalculateListEncodeFieldBytesAndOffset(Stream xdata, long start)
		{
			return 0L;
		}

		private bool HandleBitStringTag(Stream xdata, ref long offset)
		{
			return false;
		}

		private bool ListDecodeKnownLengthInternal(Stream xdata, long offset)
		{
			return false;
		}

		private Stream CreateAndPrepareListDecodeMemoryStreamKnownLength(Stream xdata)
		{
			return null;
		}

		private bool ListDecodeChildNodesWithKnownLength(Stream secData, long offset)
		{
			return false;
		}

		private bool CreateAndAddChildNode(Stream secData, ref long offset)
		{
			return false;
		}

		private bool ListDecodeIndefiniteLength(Stream xdata, long start, long childNodeMaxLen)
		{
			return false;
		}

		private bool ListDecodeIndefiniteLengthInternal(Stream xdata, long offset, long childNodeMaxLen)
		{
			return false;
		}

		private bool ReadNextChildNodeOrEndFooterOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen)
		{
			return false;
		}

		private Asn1EndOfIndefiniteLengthNodeType DetectEndOfIndefiniteListContents(Stream xdata)
		{
			return default(Asn1EndOfIndefiniteLengthNodeType);
		}

		private bool ReadNextChildNodeOfIndefiniteListClearIfInvalid(Stream xdata, ref long offset, long childNodeMaxLen)
		{
			return false;
		}

		protected void SetData(byte[] xdata)
		{
		}

		protected bool InternalLoadData(Stream xdata)
		{
			return false;
		}
	}
}
