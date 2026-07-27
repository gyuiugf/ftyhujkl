using System;

namespace UnityEngine.Purchasing
{
	[Serializable]
	public class LocalizedProductDescription
	{
		public TranslationLocale googleLocale;

		[SerializeField]
		private string title;

		[SerializeField]
		private string description;

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Description
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public LocalizedProductDescription Clone()
		{
			return null;
		}

		private static string EncodeNonLatinCharacters(string s)
		{
			return null;
		}

		private static string DecodeNonLatinCharacters(string s)
		{
			return null;
		}
	}
}
