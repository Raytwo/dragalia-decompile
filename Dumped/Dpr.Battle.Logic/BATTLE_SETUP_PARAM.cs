using System.Runtime.CompilerServices;
using Dpr.BallDeco;
using Pml;
using Pml.PokePara;

namespace Dpr.Battle.Logic;

public class BATTLE_SETUP_PARAM
{
	public BtlCompetitor competitor;

	public BtlRule rule;

	public RaidBattleParam raidBattleParam;

	public BTL_FIELD_SITUATION fieldSituation;

	public BattleEffectComponentData btlEffComponent;

	public EvolveSituation evolveSituation;

	public BtlCommMode commMode;

	public BtlMultiMode multiMode;

	public byte commPos;

	public BtlRecordDataMode recordDataMode;

	public MiseaiData[] miseaiData;

	public int[] stations;

	public bool isPlayerRatingDisplay;

	public bool isLiveRecSendEnable;

	public PokeParty[] party;

	public PartyDesc[] partyDesc;

	public MyStatus[] playerStatus;

	public ushort[] playerRating;

	public CapsuleData[][] ballDecoDesc;

	public BSP_TRAINER_DATA[] tr_data;

	public bool bGakusyuSouti;

	public ushort LimitTimeGame;

	public ushort LimitTimeClient;

	public ushort LimitTimeCommand;

	public bool bEnableTimeStop;

	public SHOOTER_ITEM_BIT_WORK shooterBitWork;

	public bool reduceHighLevelCaptureRate;

	public byte maxFollowPokeLevel;

	public byte captureLevelCap;

	public byte expLevelCap;

	public ushort commNetIDBit;

	public uint btl_status_flag;

	public uint wildPokeAiBitFlag;

	public float moneyRate;

	public byte forceQuitTurnCount;

	public bool bSkyBattle;

	public bool bSakasaBattle;

	public bool bMustCapture;

	public bool bNoGainBattle;

	public int safariBallNum;

	public bool bVoiceChat;

	public BATTLE_CONVENTION_INFO[] conventionInfo;

	public int getMoney;

	public BtlResult result;

	public byte fairyGymResult;

	public bool honooGymResult_wonByPlayer;

	public byte capturedPokeIdx;

	public byte capturedClientID;

	public byte commServerVer;

	public int commError;

	public bool isDisplayedCommError;

	public unsafe byte* recBuffer;

	public uint recDataSize;

	public ulong recRandSeed;

	public BattleRecordHeader recHeader;

	public BATTLE_KENTEI_RESULT kenteiResult;

	public bool cmdIllegalFlag;

	public bool recPlayCompleteFlag;

	public bool WifiBadNameFlag;

	public bool isDisconnectOccur;

	public bool isWatchMember;

	public bool[] fightPokeIndex;

	public bool[] turnedLvUpPokeIndex;

	public PokeResult[] pokeResult;

	public byte[][] party_state;

	public uint[] restHPRatio;

	public BATTLE_PGL_RECORD_SET PGL_Record;

	public BATTLE_TVNAVI_DATA tvNaviData;

	public PokeMemoryResult pokeMemoryResult;

	public int throwBallNum
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Clear()
	{
	}
}
