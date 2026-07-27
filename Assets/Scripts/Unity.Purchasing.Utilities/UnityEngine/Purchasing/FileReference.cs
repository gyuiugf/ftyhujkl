using Uniject;

namespace UnityEngine.Purchasing
{
	internal class FileReference
	{
		private readonly string m_FilePath;

		private readonly ILogger m_Logger;

		internal static FileReference CreateInstance(string filename, ILogger logger, IUtil util)
		{
			return null;
		}

		internal FileReference(string filePath, ILogger logger)
		{
		}

		internal void Save(string payload)
		{
		}

		internal string Load()
		{
			return null;
		}

		internal void Delete()
		{
		}
	}
}
