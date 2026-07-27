using System.Collections.Generic;

namespace Firebase.Analytics
{
	public class Parameter
	{
		internal string Name { get; set; }

		internal object Value { get; set; }

		public Parameter(string parameterName, string parameterValue)
		{
		}

		public Parameter(string parameterName, long parameterValue)
		{
		}

		public Parameter(string parameterName, double parameterValue)
		{
		}

		public Parameter(string parameterName, IDictionary<string, object> parameterValue)
		{
		}

		public Parameter(string parameterName, IEnumerable<IDictionary<string, object>> parameterValue)
		{
		}
	}
}
