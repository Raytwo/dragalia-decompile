using System;
using System.Collections;
using System.Collections.Generic;
using DPData;
using Dpr.Message;
using Dpr.NetworkUtils;
using Dpr.SubContents;
using INL1;
using UnityEngine;

public class UgNetworkManager : NetUseManager<UgNetworkManager>
{
	public class UgOnlinePlayerData
	{
		public ZoneID nowZoneID;

		public Vector3 position;

		public ZoneData secretBaseInfo;

		public PlayerNameData playerNameData;

		public OpcState.OnlineState onlineState;

		public bool isNaminori;

		public bool isJoinTonarihori;

		public bool isEnteredSecretBase;

		public bool isNull => default(bool);

		public void Clear()
		{
		}
	}

	public const int SESSION_PLAYER_MAX_COUNT = 8;

	private PosData[] posDataList;

	private int posDataIndex;

	[SerializeField]
	private int Debug_Minute;

	[SerializeField]
	private int Debug_Sec;

	[SerializeField]
	private int Debug_KousekiNum;

	public static IlcaNetSessionNetworkType connectType;

	public static MatchingType matchingType;

	public static string password;

	public bool isJustJoin;

	private int MyStationIndex;

	private bool IsDigTableReady;

	private List<int> IgnoreSendList;

	public Action<INetData> OnReceiveDigFossilNetData;

	public Action<int> OnDigEndOtherPlayer;

	public Action<int> OnLeaveOther;

	public int digFossileMainPlayerStationIndex;

	public Action<bool> OnDigFossilJoinPermission;

	private int DigJoinMemberCount;

	public Action<NetSecretBaseData> OnSecretBaseEnter;

	public List<(int, Vector2Int)> tonarihoriList;

	public bool isMainKasekihori;

	public List<UgOnlinePlayerData> ugOnlinePlayerDatas;

	private bool isSwim;

	private NetDigAttackData netDigAttackData;

	private NetUgJoinData netJoinData;

	private NetSecretBaseData netSecretBaseData;

	private NetSecretBaseInfo netSecretBaseInfo;

	private NetSecretBaseUpdate netSecretBaseUpdate;

	private NetDigData netDigData;

	private NetDigJoinData netDigJoinData;

	private NetJoinDigPermission netJoinDigPermission;

	private NetDigEndData netDigEndData;

	private NetDigJoinMemberCount netDigJoinMemberCount;

	private NetRequestData netReqData;

	private NetCharacterStateData netStateData;

	private NetPlayerNameData netPlayerNameData;

	private NetPosData netPosData;

	private NetPosZoneData netPosZoneData;

	private NetZoneData netZoneData;

	private NetKousekiAdd netKousekiAdd;

	private NetBonusStart netBonusStart;

	private NetRemainBonusTime netRemainBonusTime;

	private NetKousekiCount netKousekiCount;

	private NetNaminoriData netNaminoriData;

	private NetDigTableData netDigTableData;

	private OpcState.OnlineState ReserveState;

	[SerializeField]
	private int _Debug_SecBase_StationIdx;

	public int Button01;

	public int Button02;

	public int Button06;

	private bool isKousekiBonus => default(bool);

	private float KousekiBonusTime
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	private byte KousekiCount
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	private int BonusTimeMinute => default(int);

	private int BonusTimeSec => default(int);

	private bool IsKousekiFull => default(bool);

	private bool isOtherScene => default(bool);

	public void OnZoneChange()
	{
	}

	private void RemoveNotSameZoneCharacters()
	{
	}

	protected override void OnSessionEvent(SessionEventData eventData)
	{
	}

	public void OnCrash()
	{
	}

	protected override IEnumerator Start()
	{
		return null;
	}

	protected override void MyUpdate(float deltaTime)
	{
	}

	private void OnLeaveOtherPlayer(int stationIndex, bool useExitEffect)
	{
	}

	protected override void OnDestroy()
	{
	}

	public override void SetMatchingParam(MatchingParam matchingParam)
	{
	}

	protected override void Init()
	{
	}

	public void SetAndSendMyPlayerState(OpcState.OnlineState state)
	{
	}

	public void SetMyEmoticon(OpcState.OnlineState state)
	{
	}

	public OpcState.OnlineState GetMyPlayerState()
	{
		return default(OpcState.OnlineState);
	}

	public void DeleteAllOpcCharacter()
	{
	}

	public List<OpcController> GetTargetStateOpc(OpcState.OnlineState state)
	{
		return null;
	}

	public void SendSecretBaseInfo(ZoneID zoneID)
	{
	}

	private void SendSecretBaseInfo(int stationIndex)
	{
	}

	private void SendMyJoinData(int stationIndex)
	{
	}

	private void SendReqData(int stationIndex, string dataType)
	{
	}

	public void SendOnZoneChange()
	{
	}

	private void SendZondeData(int stationIndex)
	{
	}

	public void SendOnJoinNewPlayer(SessionEventData eventData)
	{
	}

	public void SendOnOtherPlayerToSameZone(int stationIndex)
	{
	}

	public void SendSameZone(bool isSendForce = false)
	{
	}

	public void SendOtherZone()
	{
	}

	public void SendOnPlayDigFossil(Vector2Int mainPos, DigPos digPos1, DigPos digPos2)
	{
	}

	public void SendUpdateDigFossil(int stationIndex = -1)
	{
	}

	public void SendOnJoinDigFossil(int stationIndex, Vector2Int gridPos)
	{
	}

	public void SendJoinDigPermission(int stationIndex, bool isOK)
	{
	}

	public void SendDigJoinMemberCount()
	{
	}

	public void SendOnFinishDigFossil()
	{
	}

	public void SendDigAttack(Vector2 position, bool isHammer)
	{
	}

	public void SendOnEnterSecretBase(int stationIndex)
	{
	}

	public void SendMySecretBaseData(int stationIndex)
	{
	}

	public void SendMySecretBaseUpdateNotice()
	{
	}

	public void SendKousekiAdd(int num)
	{
	}

	public void SendStartKousekiBonus()
	{
	}

	public void SendRemainBonusTime(int stationIndex)
	{
	}

	public void SendKousekiNum(int stationIndex)
	{
	}

	private void SendStateData(int stationIndex)
	{
	}

	private void SendPlayerNameData(int stationIndex)
	{
	}

	public void SendToSameZonePlayers<T>(ANetData<T> netData, bool isReliable = true) where T : struct
	{
	}

	public void SendToOtherZonePlayers<T>(ANetData<T> netData, bool isReliable) where T : struct
	{
	}

	protected override void OnReceiveData(INetData netData)
	{
	}

	private void OnReceiveJoinData(INetData netData)
	{
	}

	private void OnReceiveStateData(INetData netData)
	{
	}

	private void OnReceiveZoneData(INetData netData)
	{
	}

	private void OnReceiveRequestData(INetData netData)
	{
	}

	private void OnReceiveSecretBase_Info(INetData netData)
	{
	}

	private void OnReceiveSecretBaseData(INetData netData)
	{
	}

	private void OnReceiveSecretBaseUpdate(INetData netData)
	{
	}

	private void OnReceiveNaminoriData(INetData netData)
	{
	}

	private void OnReceiveDigTableData(INetData netData)
	{
	}

	private void OnReceiveDigPointData(INetData netData)
	{
	}

	private void OnReceiveJoinDigPermission(NetJoinDigPermission permission)
	{
	}

	private void OnReceiveDigJoinData(INetData netData)
	{
	}

	private void OnReceivePlayerNameData(INetData netData)
	{
	}

	private void OnReceiveAddKouseki(INetData netData)
	{
	}

	private void OnReceiveBonusStart(INetData netData)
	{
	}

	private void OnReceiveRemainBonusTime(INetData netData)
	{
	}

	private void OnReceiveKousekiCount(INetData netData)
	{
	}

	public bool SetZoneID(int stationIndex, ZoneID zoneID)
	{
		return default(bool);
	}

	public void SetSecretBaseInfo(int stationIndex, ZoneData ugSecretBaseInfo)
	{
	}

	public void SetPlayerNameData(int stationIndex, NetPlayerName playerName)
	{
	}

	public void SetPlayerPosition(int stationIndex, Vector3 pos)
	{
	}

	protected override IEnumerator LoadAsset()
	{
		return null;
	}

	public void ClearTonarihoriList()
	{
	}

	private void MakeJoinData()
	{
	}

	private void OnCreateOpc(int stationIndex)
	{
	}

	private bool CheckJoinTonarihori(NetDigJoinData netData)
	{
		return default(bool);
	}

	public void SetReserveEmoticon()
	{
	}

	public void RedoEmoticon()
	{
	}

	private void Debug_OnReceiveSecretBase_Info()
	{
	}

	private void Debug_OnReceivePlayerNameData()
	{
	}

	private void Debug_OnReceiveDigPointData()
	{
	}
}
