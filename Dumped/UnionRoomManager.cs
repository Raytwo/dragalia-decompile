using System;
using System.Collections;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using UnityEngine;
using XLSXContent;

public class UnionRoomManager : NetUseManager<UnionRoomManager>
{
	public enum UNION_ERRORSTATE
	{
		NONE,
		NETWORK_ERROR
	}

	private const string UNION_MASTER_PATH = "unionroom/masterdata";

	private const string CHARACTER_DATATABLE_PATH = "UnionCharacterTable";

	private const string NPC_COLOR_DATATABLE = "UnionNpcColorTable";

	private const string UNION_BATTLE_DISPLAY_PATH = "unionroom/ui";

	private const string BATTLE_RULE_WINDOW_PATH = "UNION_BattleRuleWindow";

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

	public ZoneID returnZoneID;

	public int locatorIndex;

	public Vector3 returnPosition;

	protected GameObject battleRuleDisplayUiObj;

	private GameObject batteStateDataWindow;

	public GameObject fdControllerObject;

	public UnionFrontDeskStateController unionFrontController;

	private GameObject startPointObject;

	private GameObject startLandObj;

	private UnionStartPointCollision pointCollision;

	private UnionTradeManager tradeManager;

	private BattleMatchingManager battleMatchingManager;

	private UnionBaseMsgWindow msgWindow;

	private FieldCharacterEntity frontDeskEntity;

	private bool isError;

	private bool canLeave;

	private bool isLeaving;

	private bool isCancelStock;

	private const float STATE_UPDATE_INTERVAL = 2f;

	private float stateUpdateTime;

	private OpcState.OnlineState nowTalkReserveState;

	private NetCharacterStateData stateData;

	private FieldPlayerEntity player => null;

	public bool isBattle => default(bool);

	protected override IEnumerator Start()
	{
		return null;
	}

	public override void SetMatchingParam(MatchingParam matchingParam)
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

	private void SSGaminWaitMessage(bool isSSGaming)
	{
	}

	private void SetupLeave()
	{
	}

	private void LandStartPoint()
	{
	}

	private void CreateFrontDesk()
	{
	}

	public void LeaveUnion()
	{
	}

	public void TransitionUnionInit()
	{
	}

	private void CreateTradeManager()
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

	private void LeaveMine()
	{
	}

	private void LeaveOtherPlayer(int index)
	{
	}

	private void GamingError()
	{
	}

	private void BattleRuleCancel()
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

	private void TradeErrorDialog()
	{
	}

	private void OpenErrorDialog(ErrorCodeID errorId, Action<ErrorAppletResult> onClosedAct)
	{
	}

	private void OpenSystemErrorMessage(ErrorAppletResult errorAppletResult)
	{
	}

	private bool IsCheckCommunicationState()
	{
		return default(bool);
	}

	private void LeaveCommunicationPlayer(int stationIndex)
	{
	}

	public void SessionStart()
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

	private void SendOpcStateDataAll()
	{
	}

	public void SendRequestData(int stationIndex, byte id)
	{
	}

	private void SendIsTransitionAfter()
	{
	}

	private void SendStandbyPlayerData(int stationIndex)
	{
	}

	private void SendIsMatchWait(int stationIndex)
	{
	}

	private void SendPokeData(int stationIndex)
	{
	}

	private void SendBattleRuleData(int stationIndex)
	{
	}

	private void RecivePokeData(NetTradePokeData netTradePokeData)
	{
	}

	private void StartTalk(UnionOpcController controller, bool IsRecruitment, bool IsTargetCanTalk, OpcState.OnlineState onlineState = OpcState.OnlineState.NONE)
	{
	}

	private int GetAvaterId()
	{
		return default(int);
	}

	private Vector3 GetStartPos()
	{
		return default(Vector3);
	}

	public void OpenTargetTranerCard(TranerData tranerData, int stationIndex)
	{
	}

	public void OpenBallDecoWindow(NetDataAttachSealNetData data)
	{
	}

	private void SetNpcTalkBit()
	{
	}

	public UnionTradeManager.TargetTranerParam GetTargetTranerParam()
	{
		return null;
	}
}
