using UnityEngine.Purchasing.UseCases.Interfaces;
using UnityEngine.Scripting;

namespace UnityEngine.Purchasing.UseCases
{
	internal class AppReceiptUseCase : IAppReceiptUseCase
	{
		private readonly IAppleAppReceiptViewer m_AppleAppReceiptViewer;

		[Preserve]
		internal AppReceiptUseCase(IAppleAppReceiptViewer appleAppReceiptViewer)
		{
		}

		public string? AppReceipt()
		{
			return null;
		}
	}
}
