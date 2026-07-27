using Google.Play.Common.Internal;

namespace Google.Play.Review.Internal
{
	internal class ReviewAsyncOperation<TResult> : PlayAsyncOperationImpl<TResult, ReviewErrorCode>
	{
		public override bool IsSuccessful => false;
	}
}
