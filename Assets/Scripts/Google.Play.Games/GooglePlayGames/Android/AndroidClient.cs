using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.Android
{
	public class AndroidClient : IPlayGamesClient
	{
		private enum AuthState
		{
			Unauthenticated = 0,
			Authenticated = 1
		}

		private readonly object GameServicesLock;

		private readonly object AuthStateLock;

		private static readonly string PlayGamesSdkClassName;

		private ISavedGameClient mSavedGameClient;

		private IEventsClient mEventsClient;

		private Player mUser;

		private AuthState mAuthState;

		private IUserProfile[] mFriends;

		private LoadFriendsStatus mLastLoadFriendsStatus;

		private AndroidJavaClass mGamesClass;

		private static string TasksClassName;

		private AndroidJavaObject mFriendsResolutionException;

		private readonly int mLeaderboardMaxResults;

		private readonly int mFriendsMaxResults;

		internal AndroidClient()
		{
		}

		private static void InitializeSdk()
		{
		}

		public void Authenticate(Action<SignInStatus> callback)
		{
		}

		public void ManuallyAuthenticate(Action<SignInStatus> callback)
		{
		}

		private void Authenticate(bool isAutoSignIn, Action<SignInStatus> callback)
		{
		}

		private void SignInOnResult(bool isAuthenticated, Action<SignInStatus> callback)
		{
		}

		public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback)
		{
		}

		public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback)
		{
		}

		private AuthResponse ToAuthResponse(AndroidJavaObject result)
		{
			return null;
		}

		private AndroidJavaObject getJavaScopeEnum(AuthScope scope)
		{
			return null;
		}

		public void RequestRecallAccessToken(Action<RecallAccess> callback)
		{
		}

		private static Action<T> AsOnGameThreadCallback<T>(Action<T> callback)
		{
			return null;
		}

		private static void InvokeCallbackOnGameThread(Action callback)
		{
		}

		private static void InvokeCallbackOnGameThread<T>(Action<T> callback, T data)
		{
		}

		private static Action<T1, T2> AsOnGameThreadCallback<T1, T2>(Action<T1, T2> toInvokeOnGameThread)
		{
			return null;
		}

		private static void InvokeCallbackOnGameThread<T1, T2>(Action<T1, T2> callback, T1 t1, T2 t2)
		{
		}

		public bool IsAuthenticated()
		{
			return false;
		}

		public void LoadFriends(Action<bool> callback)
		{
		}

		private void LoadAllFriends(int pageSize, bool forceReload, bool loadMore, Action<bool> callback)
		{
		}

		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		private void LoadFriendsPaginated(int pageSize, bool isLoadMore, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		private static bool IsApiException(AndroidJavaObject exception)
		{
			return false;
		}

		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		public void ShowCompareProfileWithAlternativeNameHintsUI(string playerId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		public IUserProfile[] GetFriends()
		{
			return null;
		}

		public string GetUserId()
		{
			return null;
		}

		public string GetUserDisplayName()
		{
			return null;
		}

		public string GetUserImageUrl()
		{
			return null;
		}

		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		public void LoadUsers(string[] userIds, Action<IUserProfile[]> callback)
		{
		}

		public void LoadAchievements(Action<Achievement[]> callback)
		{
		}

		public void UnlockAchievement(string achId, Action<bool> callback)
		{
		}

		public void RevealAchievement(string achId, Action<bool> callback)
		{
		}

		public void IncrementAchievement(string achId, int steps, Action<bool> callback)
		{
		}

		public void SetStepsAtLeast(string achId, int steps, Action<bool> callback)
		{
		}

		public void ShowAchievementsUI(Action<UIStatus> callback)
		{
		}

		public int LeaderboardMaxResults()
		{
			return 0;
		}

		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
		}

		private LeaderboardScoreData CreateLeaderboardScoreData(string leaderboardId, LeaderboardCollection collection, LeaderboardTimeSpan timespan, ResponseStatus status, AndroidJavaObject leaderboardScoresJava)
		{
			return null;
		}

		public void SubmitScore(string leaderboardId, long score, Action<bool> callback)
		{
		}

		public void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> callback)
		{
		}

		public ISavedGameClient GetSavedGameClient()
		{
			return null;
		}

		public IEventsClient GetEventsClient()
		{
			return null;
		}

		private AndroidJavaObject getAchievementsClient()
		{
			return null;
		}

		private AndroidJavaObject getPlayersClient()
		{
			return null;
		}

		private AndroidJavaObject getLeaderboardsClient()
		{
			return null;
		}

		private AndroidJavaObject getPlayerStatsClient()
		{
			return null;
		}

		private AndroidJavaObject getGamesSignInClient()
		{
			return null;
		}

		private AndroidJavaObject getRecallClient()
		{
			return null;
		}
	}
}
