using System;
using Dpr.BallDeco;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using INL1;

namespace Dpr.Contest;

public class ContestMatchingNetwork
{
	private const int MAX_RETRY_COUNT = 3;

	private const float SEND_READY_SPAN = 3f;

	private NetPlayerInfo charaModelData;

	private CountDownNetData countDownData;

	private NoticeNetData noticeData;

	private SkillPointNetData skillPointData;

	private ChoiceNetData choiceData;

	private CategoryAndRankNetData categoryAndRankData;

	private ContestEntryNPCNetData entryNPCData;

	private ContestEntryPlayerNetData entryPlayerData;

	private ContestInfoNetData contestInfoData;

	private ScoreNetData scoreData;

	private LaunchSkillNetData launchSkillData;

	private ResultScoreNetData resultScoreData;

	private StationWaitFrameData waitFrameData;

	private NetworkManager networkManager;

	private WaitTimer repeatSendSpanTimer;

	private uint[] attributeValueArray;

	private uint[] attributeMinValueArray;

	private uint[] attributeMaxValueArray;

	private Action<byte, PacketReader> onRecievePacket;

	private Action<SessionEventData> onSessionEvent;

	private Action onFinishedSession;

	private ConnectType connectType;

	private MatchingType matchingType;

	private PlayerSkill playerSkill;

	private MultiContestStepID currentStepID;

	private string password;

	private int nowJoinMemberNum;

	private int myStationIndex;

	private int retryCount;

	private bool[] mainFlagArray;

	private bool[] subFlagArray;

	private bool bIsInitialize;

	public ConnectType ConnectType => default(ConnectType);

	public MatchingType MatchingType => default(MatchingType);

	public PlayerSkill PlayerSkill => default(PlayerSkill);

	public int MyStationIndex => default(int);

	public int JoinMemberNum => default(int);

	public void Initialize(Action<byte, PacketReader> onRecievePacket, Action<SessionEventData> onSessionEvent, Action onFinishedSession)
	{
	}

	public void Reset()
	{
	}

	public void OnFinalize()
	{
	}

	public void ReleaseReceivePacket()
	{
	}

	public void ReleaseSessionEvent()
	{
	}

	private void ReleaseNetworkCallback()
	{
	}

	public bool IsHost()
	{
		return default(bool);
	}

	public bool IsConnect()
	{
		return default(bool);
	}

	public bool CanPlayNetworkContest()
	{
		return default(bool);
	}

	public bool IsJoinedOtherPlayer()
	{
		return default(bool);
	}

	public bool IsGamerActive(int stationIndex)
	{
		return default(bool);
	}

	private void OnJoinMine()
	{
	}

	private void UpdateJoinMemberNum()
	{
	}

	public void SetEntryPlayerInfo(int playerIndex, PlayerType playerType)
	{
	}

	public void SetStepID(MultiContestStepID stepID)
	{
	}

	public bool GetMyMainFlag()
	{
		return default(bool);
	}

	public void SetMainFlag(int stationIndex, bool flag)
	{
	}

	public void SetAllMainFlag(bool flag)
	{
	}

	public bool IsAllMainFlagTrue(int memberNum)
	{
		return default(bool);
	}

	public bool GetSubFlagByStationIndex(int stationIndex)
	{
		return default(bool);
	}

	public bool GetMySubFlag()
	{
		return default(bool);
	}

	public void SetSubFlag(int stationIndex, bool flag)
	{
	}

	private void SetAllSubFlag(bool flag)
	{
	}

	public bool IsAllSubFlagTrue(int memberNum)
	{
		return default(bool);
	}

	private bool CheckPlayerIndex(int index)
	{
		return default(bool);
	}

	public void RepeatSendNotice(NoticeID noticeID, float deltaTime)
	{
	}

	public bool IsFinishWait(float deltaTime)
	{
		return default(bool);
	}

	public void ResetTimer()
	{
	}

	private void OnRecievePacket(PacketReader pr)
	{
	}

	private void OnSessionEvent(SessionEventData result)
	{
	}

	private void OnFinishedSession()
	{
	}

	public void SetSessionParam(ConnectType connectType, MatchingType matchingType, PlayerSkill playerSkill, string password)
	{
	}

	public void StartSession(Action<bool> onFinish)
	{
	}

	private void SetupSessionParam()
	{
	}

	public void RestartRequestAsync()
	{
	}

	private IlcaNetSessionNetworkType GetNetworkType()
	{
		return default(IlcaNetSessionNetworkType);
	}

	private void SettingSessionAttribute()
	{
	}

	public bool CloseSession()
	{
		return default(bool);
	}

	public void LeaveSession()
	{
	}

	public bool FinishSession()
	{
		return default(bool);
	}

	public void OnResumeGame()
	{
	}

	public void SendPlayerModelData(int stationIndex)
	{
	}

	public NetPlayerInfo ReceiveCharaModelData(PacketReader pr)
	{
		return null;
	}

	public void SendCountDownData(ushort timeCount)
	{
	}

	public CountDownNetData ReceiveCountDownData(PacketReader pr)
	{
		return null;
	}

	public void SendNoticeData(NoticeID noticeID)
	{
	}

	public void SendNoticeData(int stationIndex, NoticeID noticeID)
	{
	}

	public void SendNoticeDataToAll(NoticeID noticeID)
	{
	}

	public NoticeNetData ReceiveNoticeData(PacketReader pr)
	{
		return null;
	}

	public void SendChoiceData(int targetStationIndex)
	{
	}

	public ChoiceNetData ReceiveChoiceNetData(PacketReader pr)
	{
		return null;
	}

	public void SendSkillPointDataToHost()
	{
	}

	public SkillPointNetData ReceiveSkillPointData(PacketReader pr)
	{
		return null;
	}

	public void SendCategoryAndRankDataToAll(CategoryID categoryID, RankID rankID, int cassetVersion)
	{
	}

	public CategoryAndRankNetData ReceiveCategoryAndRankData(PacketReader pr)
	{
		return null;
	}

	public void SendEntryNPCDataToAll()
	{
	}

	public ContestEntryNPCNetData ReceiveEntryNPCData(PacketReader pr)
	{
		return null;
	}

	public void SendEntryPlayerDataToAll(int userEntryNumber, float wazaSeqMaxTime, AffixSealData[] sealDataArray)
	{
	}

	public ContestEntryPlayerNetData ReceiveEntryPlayerData(PacketReader pr)
	{
		return null;
	}

	public void SendContestDataToAll(byte stageRank)
	{
	}

	public ContestInfoNetData ReceiveContestData(PacketReader pr)
	{
		return null;
	}

	public void SendScoreDataToAll(int playerIndex, int danceScore, int tension)
	{
	}

	public ScoreNetData ReceiveScoreData(PacketReader pr)
	{
		return null;
	}

	public void SendLaunchSkillDataToAll(int playerIndex, float elapsedTime, float duration)
	{
	}

	public LaunchSkillNetData ReceiveLaunchSkillData(PacketReader pr)
	{
		return null;
	}

	public void SendResultScoreToAll(int playerIndex, int visualScore, int danceScore, int wazaScore)
	{
	}

	public ResultScoreNetData ReceiveResultScoreData(PacketReader pr)
	{
		return null;
	}

	public float SendWaitFrameData()
	{
		return default(float);
	}

	public float ReceiveWaitFrameData(PacketReader pr)
	{
		return default(float);
	}

	private void SendDataToStation<T>(ANetData<T> data, int index) where T : struct
	{
	}

	private void SendDataToAll<T>(ANetData<T> data) where T : struct
	{
	}
}
