using System.IO;

namespace LipingShare.LCLib.Asn1Processor
{
	internal class RelativeOid : Oid
	{
		public override void Encode(Stream bt, string oidStr)
		{
		}

		public override string Decode(Stream bt)
		{
			return null;
		}
	}
}
