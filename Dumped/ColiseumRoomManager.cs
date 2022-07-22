using System;
using System.Collections;
using System.Collections.Generic;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using Effect;
using UnityEngine;
using XLSXContent;

public class ColiseumRoomManager : NetUseManager<ColiseumRoomManager>
{
	public enum UNION_ERRORSTATE
	{
		NONE,
		NETWORK_ERROR
	}

	public enum ColiseumState
	{
		INIT,
		WAIT,
		STANDBY,
		BATTLE,
		LEAVE
	}

	public const int SESSION_PLAYER_MAX_COUNT_COMMUNITY = 2;

	public const int SESSION_PLAYER_MAX_COUNT_GLOBAL = 16;

	private const string UNION_MASTER_PATH = "unionroom/masterdata";

	private const string CHARACTER_DATATABLE_PATH = "UnionCharacterTable";

	private const string NPC_COLOR_DATATABLE = "UnionNpcColorTable";

	private const string UNION_DEBUG_PATH = "unionroom/debug";

	private const string DEBUG_UI_PATH = "UNION_TestWindow";

	private const string DEBUG_UI_ONLINE_STATUS_PATH = "OnlineDebugUIWindow";

	private const int POSITION_DATA_MAX_SIZE = 12;

	private const float GURUGURU_HEIGHT_UP = 10f;

	private const string UNION_FRONT_DESK_CONTROLLER = "FdController";

	private static readonly ZoneID[] enableZones;

	private UnionCharacterTable.SheetSheet1[] _characterTable;

	private UnionNpcColorTable.SheetSheet1[] _npcColorTable;

	private NetJoinData netJoinData;

	private PosData[] posDataList;

	private int posDataIndex;

	public UnionStateController stateController;

	private ColiseumState coliseumState;

	private UNION_ERRORSTATE errorState;

	private bool canLeave;

	private Coroutine waitConnect;

	public ZoneID returnZoneID;

	public int locatorIndex;

	public Vector3 returnPosition;

	protected GameObject _testUI;

	private GameObject batteStateDataWindow;

	private UnionOnlineDebugWindow onlineStateDataWindow;

	public GameObject fdControllerObject;

	public ColiseumFrontDeskStateController coliseumFrontController;

	public GameObject npcObj;

	private GameObject startPointObject;

	private GameObject startLandObj;

	private UnionStartPointCollision pointCollision;

	private ColiseumMessage msgWindow;

	private FieldCharacterEntity frontDeskEntity;

	private List<BattleReadyPoint> battleReadyPoints;

	private int readyPointIndex;

	private bool isEnableInput;

	private int[] macthPlayerIndexList;

	private ColiseumTransitionController transitionController;

	private Action _startFade;

	private EffectData waitEffectBlue;

	private EffectData waitEffectRed;

	private EffectData readyEffectBlue;

	private EffectData readyEffectRed;

	private BattleMatchingManager battleMatchingManager;

	private FieldPlayerEntity player => null;

	public bool isBattle => default(bool);

	protected override IEnumerator Start()
	{
		return null;
	}

	public override void SetMatchingParam(MatchingParam matchingParam)
	{
	}

	public void SetBatteleRule(int ruleId)
	{
	}

	protected override void Init()
	{
	}

	protected override void MyUpdate(float deltaTime)
	{
	}

	protected override void OnDestroy()
	{
	}

	public void SetZoneData(ZoneID zoneId, int locIndex, Vector2Int gridPos)
	{
	}

	private void SetUp()
	{
	}

	private void Clear()
	{
	}

	private void CreateWarpCollision()
	{
	}

	private void LandStartPoint()
	{
	}

	private void CreateFrontDesk()
	{
	}

	private void StartGuruGuruJoinAnimation()
	{
	}

	public void StartGuruGuruLeaveAnimation()
	{
	}

	public void LeaveUnion()
	{
	}

	public void TransitionUnionInit()
	{
	}

	public void ReturnBattle()
	{
	}

	private void ReturnBattleMatching()
	{
	}

	private void CreateBattleMatchingManager()
	{
	}

	protected override void OnSessionEvent(SessionEventData eventData)
	{
	}

	private void JoinOtherPlayer(int stationIndex)
	{
	}

	private void LeaveMine()
	{
	}

	private void LeaveOtherPlayer(int index)
	{
	}

	private void GamingError()
	{
	}

	private void Crush()
	{
	}

	private void Resume()
	{
	}

	private void NetworkError()
	{
	}

	private bool IsNetworkError()
	{
		return default(bool);
	}

	private void OpenSystemErrorMessage(ErrorAppletResult errorAppletResult)
	{
	}

	public void ClearSession()
	{
	}

	protected override void OnReceiveData(INetData netData)
	{
	}

	protected override void SetNetData(INetData netData)
	{
	}

	protected override IEnumerator LoadAsset()
	{
		return null;
	}

	private void SendJoinData(int stationIndex)
	{
	}

	private void SendPosData()
	{
	}

	private void SendOpcStateData(int stationIndex)
	{
	}

	public void SendRequestData(int stationIndex, byte id)
	{
	}

	private void SendPokeData(int stationIndex)
	{
	}

	private void SendJoin()
	{
	}

	private void SendLeave()
	{
	}

	private void SendStanbyPointData(bool isJoin)
	{
	}

	private void SendBattle()
	{
	}

	private void RecivePokeData(NetTradePokeData netTradePokeData)
	{
	}

	private void ReciveColiseumJoin(NetDataColiseumJoinDataData data)
	{
	}

	private void ReciveColiseumLeave(NetDataColiseumLeaveData data)
	{
	}

	private void ReciveColiseumStanby(NetDataColiseumStanbyPointData data)
	{
	}

	private void AddMember(int pointIndex, int stationIndex)
	{
	}

	private void RemoveMember(int pointIndex, int stationIndex)
	{
	}

	private void SetNpcTalkBit()
	{
	}

	private void SetUpColiseum()
	{
	}

	private void ResetMacthPlayer()
	{
	}

	private void CreateBattleReadyPoint()
	{
	}

	private void SetBattleReadyPos(int index, GameObject obj)
	{
	}

	private void CheckAllPlayerReadyOk()
	{
	}

	private void BattleStart()
	{
	}

	private void OnReadyWait()
	{
	}

	private void OnLeaveEnd()
	{
	}

	private void ControllPlayer(int hitColNum)
	{
	}

	private void LeaveControllPlayer()
	{
	}
}
