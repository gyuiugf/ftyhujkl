using System;
using System.Collections.Generic;
using GooglePlayGames.BasicApi.Events;
using GooglePlayGames.BasicApi.SavedGame;
using UnityEngine.SocialPlatforms;

namespace GooglePlayGames.BasicApi
{
	public interface IPlayGamesClient
	{
		void Authenticate(Action<SignInStatus> callback);

		void ManuallyAuthenticate(Action<SignInStatus> callback);

		bool IsAuthenticated();

		void RequestServerSideAccess(bool forceRefreshToken, Action<string> callback);

		void RequestServerSideAccess(bool forceRefreshToken, List<AuthScope> scopes, Action<AuthResponse> callback);

		void RequestRecallAccessToken(Action<RecallAccess> callback);

		string GetUserId();

		void LoadFriends(Action<bool> callback);

		string GetUserDisplayName();

		string GetUserImageUrl();

		void GetPlayerStats(Action<CommonStatusCodes, PlayerStats> callback);

		void LoadUsers(string[] userIds, Action<IUserProfile[]> callback);

		void LoadAchievements(Action<Achievement[]> callback);

		void UnlockAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		void RevealAchievement(string achievementId, Action<bool> successOrFailureCalllback);

		void IncrementAchievement(string achievementId, int steps, Action<bool> successOrFailureCalllback);

		void SetStepsAtLeast(string achId, int steps, Action<bool> callback);

		void ShowAchievementsUI(Action<UIStatus> callback);

		void AskForLoadFriendsResolution(Action<UIStatus> callback);

		LoadFriendsStatus GetLastLoadFriendsStatus();

		void ShowCompareProfileWithAlternativeNameHintsUI(string otherUserId, string otherPlayerInGameName, string currentPlayerInGameName, Action<UIStatus> callback);

		void GetFriendsListVisibility(bool forceReload, Action<FriendsListVisibilityStatus> callback);

		void LoadFriends(int pageSize, bool forceReload, Action<LoadFriendsStatus> callback);

		void LoadMoreFriends(int pageSize, Action<LoadFriendsStatus> callback);

		void ShowLeaderboardUI(string leaderboardId, LeaderboardTimeSpan span, Action<UIStatus> callback);

		void LoadScores(string leaderboardId, LeaderboardStart start, int rowCount, LeaderboardCollection collection, LeaderboardTimeSpan timeSpan, Action<LeaderboardScoreData> callback);

		void LoadMoreScores(ScorePageToken token, int rowCount, Action<LeaderboardScoreData> callback);

		int LeaderboardMaxResults();

		void SubmitScore(string leaderboardId, long score, Action<bool> successOrFailureCalllback);

		void SubmitScore(string leaderboardId, long score, string metadata, Action<bool> successOrFailureCalllback);

		ISavedGameClient GetSavedGameClient();

		IEventsClient GetEventsClient();

		IUserProfile[] GetFriends();
	}
}
