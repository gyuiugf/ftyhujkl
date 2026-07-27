using System;

namespace UnityEngine.Purchasing.UseCases.Interfaces
{
	internal interface IRefreshAppReceiptUseCase
	{
		void RefreshAppReceipt(Action<string> successCallback, Action<string> errorCallback);

		void SetRefreshAppReceipt(bool refreshAppReceipt);
	}
}
