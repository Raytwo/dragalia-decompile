using System;
using System.Collections;
using System.Runtime.InteropServices;
using DPData;
using Dpr.Message;
using Dpr.NetworkUtils;
using UnityEngine;

public static class UnionWork
{
	public enum LeaveState
	{
		LEAVE,
		RESTART
	}

	public enum ILCA_NET_ERROR_LEVEL
	{
		LIGHT_ERROR,
		HEAVY_ERROR_ONE,
		HEAVY_ERROR_TWO,
		NONE
	}

	public enum BoxState
	{
		NONE,
		INVALID_DATA,
		ERROR_SERVER,
		ERROR_MINE,
		ERROR_OTHER,
		CANCEL,
		CANCEL_SELECT,
		CLOSE
	}

	public enum CommunicationState
	{
		NONE,
		BATTLE,
		TRADE,
		RECODE,
		GREETING,
		BALL_DECO,
		COMMUNICATION
	}

	public struct TvRecodePersonalityData
	{
		public bool isEmpty;

		public int BranchData;

		public TV_STR_DATA PlayerName;
	}

	public struct TvRecodeBallDecorationData
	{
		public bool isEmpty;

		public int BranchData;

		public int Trainer;
	}

	public struct TvRecodeKasekihoriData
	{
		public bool isEmpty;

		public int BranchData;

		public int ItemNo;

		public TV_STR_DATA PlayerName;
	}

	public struct TvRecodeStatueData
	{
		public bool isEmpty;

		public int BranchData;

		public int StatueCount;

		public TV_STR_DATA PlayerName;
	}

	public struct TvRecodeFashionData
	{
		public bool isEmpty;

		public int BranchData;

		public int Style;

		public int PlaceNo;

		public TV_STR_DATA PlayerName;
	}

	public struct TvRecodeData
	{
		public TvRecodePersonalityData tvRecodePersonalityData;

		public TvRecodeBallDecorationData tvRecodeBallDecorationData;

		public TvRecodeKasekihoriData tvRecodeKasekihoriData;

		public TvRecodeStatueData tvRecodeStatueData;

		public TvRecodeFashionData tvRecodeFashionData;
	}

	public static byte COMMUNITY_MAX_PLAYER_NUM;

	public static byte GLOBAL_MAX_PLAYER_NUM;

	public static byte COLISEUM_MAX_PLAYER_NUM_NOT_MULTI;

	public static byte COLISEUM_MAX_PLAYER_NUM_MULTI;

	public static Vector3 startPos;

	public static Vector3 startPosGlobal;

	public static Vector3 startPosColiseum;

	public static Vector3 fallStartPos;

	public const int PENARTY_COUNTER = 30;

	public const float GURUGURU_HEIGHT_UP = 10f;

	public const int DEFAULT_LOCATOR_INDEX = 1;

	public static Vector2Int RETURN_DEFAULT_GRID_POSITION;

	public static bool isGaming;

	public static int tvRecodeTopicCount;

	public const int matchMemberMax = 5;

	public static int hostIndex;

	public static BattleModeID battleMode;

	public static OpcState.OnlineState targetOpcState;

	private static BoxState boxState;

	public static ZoneID returnZoneID;

	public static Vector3 position;

	public static Vector2Int returnGridPos;

	public static ZoneID ymenuReturnZoneID;

	public static float ymenuReturnHeight;

	public static Vector2Int ymenuReturnGridPos;

	public static CommunicationState communicationState;

	private static bool isRecruiment;

	private static bool isTalking;

	private static bool isMatchWait;

	public static int nowTargetStationIndex;

	public static int nowTargetCassetVersion;

	public const float MaxPenaltyTime = 1800f;

	private static float PenaltyTime;

	public static FieldPlayerEntity player => null;

	public static void SetBoxState(BoxState state)
	{
	}

	public static void SetCommunicationState(CommunicationState state)
	{
	}

	public static void SetCommunicationState(OpcState.OnlineState opcState)
	{
	}

	public static CommunicationState GetCommunicationState()
	{
		return default(CommunicationState);
	}

	public static BoxState GetBoxState()
	{
		return default(BoxState);
	}

	public static void SetZoneID(ZoneID zone)
	{
	}

	public static ZoneID GetZoneID()
	{
		return default(ZoneID);
	}

	public static void SetReturnPosition(Vector3 pos)
	{
	}

	public static void SetReturnGridPosition(Vector2Int gridPos)
	{
	}

	public static void SetIsYmenu(bool flag)
	{
	}

	public static bool GetIsYmenu()
	{
		return default(bool);
	}

	public static void SetYmenuZoneID(ZoneID zone)
	{
	}

	public static ZoneID GetYmenuZoneID()
	{
		return default(ZoneID);
	}

	public static void SetYmenuGridPosition(Vector2Int gridPos)
	{
	}

	public static Vector2Int GetYmenuGridPosition()
	{
		return default(Vector2Int);
	}

	public static void SetYmenuHeight(float height)
	{
	}

	public static float GetYmenuHeight()
	{
		return default(float);
	}

	public static void SetIsGaming(bool flag)
	{
	}

	public static bool GetIsGaming()
	{
		return default(bool);
	}

	public static void SetIsTalk(bool flag)
	{
	}

	public static bool GetIsTalk()
	{
		return default(bool);
	}

	public static void SetIsRecruiment(bool flag)
	{
	}

	public static bool GetIsRecruiment()
	{
		return default(bool);
	}

	public static void SetBattleMode(BattleModeID battleModeID)
	{
	}

	public static BattleModeID GetBattleMode()
	{
		return default(BattleModeID);
	}

	public static void SetIsMatchWait(bool flag)
	{
	}

	public static bool GetIsMatchWait()
	{
		return default(bool);
	}

	public static void SetHostIndex(int index)
	{
	}

	public static int GetHostIndex()
	{
		return default(int);
	}

	public static float GetReadyPosX(int pointIndex)
	{
		return default(float);
	}

	public static float GetReadyPosZ(int pointIndex)
	{
		return default(float);
	}

	public static void SetTargetOpcState(OpcState.OnlineState state)
	{
	}

	public static OpcState.OnlineState GetTargetOpcState()
	{
		return default(OpcState.OnlineState);
	}

	public static int GetMyStationIndex()
	{
		return default(int);
	}

	public static string CreateSpeakerName(string userName, MessageEnumData.MsgLangId langId, int cassetVersion)
	{
		return null;
	}

	public static TvRecodeData GetNetRecodeData(TvWork.RecordData recordData)
	{
		return default(TvRecodeData);
	}

	public static TvWork.RecordData GetNetRecodeData(TvRecodeData recordData)
	{
		return null;
	}

	public static TvWork.RecordData GetTvRecodeData(NetDataRecodeData netDataRecode)
	{
		return null;
	}

	public static void SetInitNpcTalk(bool initNpcTalk)
	{
	}

	public static void SetPenartyCounter(int penartyCounter)
	{
	}

	public static void SetPenartyTime()
	{
	}

	public static bool CheckDateTime()
	{
		return default(bool);
	}

	public static PLAYER_NETWORK_DATA GetNetworkData()
	{
		return default(PLAYER_NETWORK_DATA);
	}

	public static void SetNetWorkData(PLAYER_NETWORK_DATA data)
	{
	}

	private static void SettingFallParam()
	{
	}

	public static void UnionSave()
	{
	}

	public static int GetLangId(byte langByte)
	{
		return default(int);
	}

	public static void LoadBattleRuleSelectUI()
	{
	}

	public static void UnloadBattleRuleSelectUI()
	{
	}

	public static bool CheckIsOpenUIWindow()
	{
		return default(bool);
	}

	public static bool CheckNetworkState()
	{
		return default(bool);
	}

	public static IEnumerator WaitNetworkSessionStateGaming(Action<bool> messegeEnabledFunc, [Optional] Action startFunc, [Optional] Action endFunc, [Optional] Action errorFunc)
	{
		return null;
	}

	public static void StartFadeOut()
	{
	}

	public static void StartFadeIn()
	{
	}

	public static IEnumerator StartFadeOutCallBack(Action fadeOutEnd)
	{
		return null;
	}

	public static IEnumerator Fade([Optional] Action fadeOutEnd, [Optional] Action fadeInEnd)
	{
		return null;
	}

	public static IEnumerator ReStartUnion(Action start, Action clear)
	{
		return null;
	}

	public static void Leave(Action animEndFunc)
	{
	}

	public static void StartGuruGuruJoinAnimation([Optional] Action fallEndFinc)
	{
	}

	public static void StartGuruGuruLeaveAnimation([Optional] Action risingEndFinc)
	{
	}

	public static IEnumerator StartHeight(int height, float upSpeed)
	{
		return null;
	}

	public static IEnumerator LerpLeave(Action animEndFunc)
	{
		return null;
	}

	public static void SetUpKeyGuideUI()
	{
	}

	public static void CloseKeyGuideUI()
	{
	}

	public static void ShowDebugTextSessionEvent(SessionEventData sessionEvent)
	{
	}

	public static void ShowDebugTextSessionStatus()
	{
	}

	public static void PlayeSE(uint seId)
	{
	}

	public static void SetPenaltyTime()
	{
	}

	public static bool IsPenalty()
	{
		return default(bool);
	}

	public static void ResetPenalty()
	{
	}

	public static void UpdatePenaltyTime(float deltatime)
	{
	}

	public static float GetPenaltyTime()
	{
		return default(float);
	}
}
