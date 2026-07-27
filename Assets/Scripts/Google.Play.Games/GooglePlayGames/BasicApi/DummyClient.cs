using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	public class DummyClient : IPlayGamesClient
	{
		public void Authenticate(Action<SignInStatus> callback)
		{
		}

		public void ManuallyAuthenticate(Action<SignInStatus> callback)
		{
		}

		public bool IsAuthenticated()
		{
			return false;
		}

		public void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback)
		{
		}

		public void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback)
		{
		}

		public void RequestRecallAccessToken(Action<RecallAccess> callback)
		{
		}

		public string GetUserId()
		{
			return null;
		}

		public void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback)
		{
		}

		public string GetUserDisplayName()
		{
			return null;
		}

		public string GetUserImageUrl()
		{
			return null;
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

		public void AskForLoadFriendsResolution(Action<UIStatus> callback)
		{
		}

		public LoadFriendsStatus GetLastLoadFriendsStatus()
		{
			return default(LoadFriendsStatus);
		}

		public void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback)
		{
		}

		public void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback)
		{
		}

		public void ShowCompareProfileWithAlternativeNameHintsUI(string userId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback)
		{
		}

		public void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback)
		{
		}

		public void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback)
		{
		}

		public int LeaderboardMaxResults()
		{
			return 0;
		}

		public void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback)
		{
		}

		public void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback)
		{
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

		public void LoadFriends(Action<bool> callback)
		{
		}

		public IUserProfile[] GetFriends()
		{
			return null;
		}

		private static void LogUsage()
		{
		}
	}
}
