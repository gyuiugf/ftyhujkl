using UnityEngine.Purchasing.Extension;
using UnityEngine.Purchasing.Interfaces;

namespace UnityEngine.Purchasing
{
	internal interface IGooglePlayStore : IStore
	{
		void SetChangeSubscriptionCallback(IGooglePlayChangeSubscriptionCallback changeSubscriptionCallback);

		void ChangeSubscription(ProductDefinition product, Order currentOrder, GooglePlayReplacementMode? desiredReplacementMode);

		void OnPause(bool isPaused);

		IGooglePurchase GetGooglePurchase(string purchaseToken);
	}
}
