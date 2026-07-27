using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Firebase.RemoteConfig
{
	public struct ConfigValue
	{
		internal static Regex booleanTruePattern;

		internal static Regex booleanFalsePattern;

		public bool BooleanValue => false;

		public IEnumerable<byte> ByteArrayValue => null;

		public double DoubleValue => 0.0;

		public long LongValue => 0L;

		public string StringValue => null;

		internal byte[] Data { get; set; }

		public ValueSource Source { get; internal set; }

		internal ConfigValue(byte[] data, ValueSource source)
		{
			Data = null;
			Source = default(ValueSource);
		}
	}
}
