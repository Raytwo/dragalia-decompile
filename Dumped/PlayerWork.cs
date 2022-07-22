using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DPData;
using Dpr.BallDeco;
using Dpr.Battle.Logic;
using Dpr.Box;
using Dpr.Contest;
using Dpr.EvScript;
using Dpr.Item;
using Dpr.Message;
using Dpr.UI;
using Pml;
using Pml.PokePara;
using SmartPoint.Components;
using UnityEngine;

public class PlayerWork : PlayerPrefsProvider<PlayerWork>
{
	public enum LoadResult
	{
		SUCCESS,
		NOT_EXIST,
		CORRUPTED,
		FAILED
	}

	[Serializable]
	[StructLayout(0, CharSet = CharSet.Unicode)]
	public struct SaveData
	{
		public const int CURRENT_VERSION_1C = 28;

		public const int CURRENT_VERSION_20 = 32;

		public const int CURRENT_VERSION_21 = 33;

		public const int CURRENT_VERSION_22 = 34;

		public const int CURRENT_VERSION_23 = 35;

		public const int CURRENT_VERSION_24 = 36;

		public const int CURRENT_VERSION_25 = 37;

		public const int CURRENT_VERSION_26 = 38;

		public const int CURRENT_VERSION_27 = 39;

		public const int CURRENT_VERSION_28 = 40;

		public const int CURRENT_VERSION_29 = 41;

		public const int CURRENT_VERSION_2A = 42;

		public const int CURRENT_VERSION_2B = 43;

		public const int CURRENT_VERSION_2C = 44;

		public const int CURRENT_VERSION = 44;

		public const int LAUNCH_VERSION = 37;

		public static readonly int[] BINARY_SIZE;

		public const int SAVEDATA_HASH_ADDR = 956440;

		public const int SAVEDATA_HASH_SIZE = 16;

		public const int GMS_WORK_ADDR = 643132;

		public const int GMS_WORK_SIZE = 201476;

		public int version;

		public int[] intValues;

		public bool[] boolValues;

		public bool[] systemFlags;

		public string rivalName;

		public ZoneID zoneID;

		public float timeScale;

		public SaveItem[] saveItem;

		public SaveUgItem[] saveUgItem;

		public ushort[] saveItemShortcut;

		public SavePokeParty playerParty;

		public SaveBoxData boxData;

		[SerializeField]
		public SaveBoxTrayData[] boxTray;

		public PLAYER_DATA playerData;

		public ZUKAN_WORK zukanData;

		public TR_BATTLE_DATA[] tr_battleData;

		public TOPMENU_WORK topMenuData;

		public _FIELDOBJ_SAVE fieldObj_Save;

		public RECORD_ARRAY record;

		public ENC_SV_DATA enc_sv_data;

		public PLAYER_SAVE_DATA player_save_data;

		public SaveBallDecoData ballDecoData;

		public SaveSealData[] saveSeal;

		public _RANDOM_GROUP randomGroup;

		public FieldGimmickSaveData fieldGimmickSaveData;

		public KinomiGrowSaveData kinomiGrowSaveData;

		public PoffinSaveData poffinSaveData;

		public BTLTOWER_SAVEWORK btlTowerSave;

		public SYSTEMDATA systemData;

		public POKETCH_DATA poketchData;

		public AzukariyaData azukariyaData;

		public _DENDOU_SAVEDATA dendoudata;

		public BadgeSaveData badgeSaveData;

		public BoukenNote boukenNote;

		public TV_DATA tvData;

		public UgSaveData ugSaveData;

		public GMS_DATA gmsdata;

		public PLAYER_NETWORK_DATA networkdata;

		public UnionSaveData unionSaveData;

		public CON_PHOTO_LANG_DATA contstPhotoLangData;

		public ZUKAN_PERSONAL_RND_DATA zukanPersonalRndData;

		public CON_PHOTO_EXT_DATA[] contestPhotoExtData;

		public GMS_POINT_HISTORY_EXT_DATA[] gmsPointExtData;

		public UgCountRecord ugCountRecord;

		public ReBuffnameData reBuffNameData;

		public byte[] saveDataHash;

		public RECORD_ADD_DATA recodeAddData;

		public MysteryGiftSaveData mysteryGiftSaveData;

		public POKETCH_POKETORE_COUNT_ARRAY poketoreCountArray;

		public PLAYREPORT_DATA playReportData;

		public MT_DATA mtData;

		public DENDOU_SAVE_ADD dendouSaveAdd;
	}

	public enum WarpType
	{
		None,
		Zenmetsu,
		Teleport,
		Ananuke,
		Sorawotobu
	}

	[SerializeField]
	private SaveData _saveData;

	[NonSerialized]
	private ZoneID _transitionZoneID;

	[NonSerialized]
	private int _locatorIndex;

	[NonSerialized]
	private LOCATION_WORK? _transitionLocation;

	[NonSerialized]
	private bool _isBattling;

	[NonSerialized]
	private bool _isContest;

	[NonSerialized]
	private bool _isSealPreview;

	[NonSerialized]
	private bool _isEvolveDemo;

	[NonSerialized]
	private bool _isHatchDemo;

	[NonSerialized]
	private bool _isMass;

	[NonSerialized]
	private bool _isEncount;

	[NonSerialized]
	private bool _isDigFossil;

	[NonSerialized]
	private bool _isGMS;

	[NonSerialized]
	private LoadResult _loadResult;

	[NonSerialized]
	private BATTLE_SETUP_PARAM _battleSetupParam;

	[NonSerialized]
	private PokeParty _playerParty;

	[NonSerialized]
	private PokemonParam _capturedPokemon;

	[NonSerialized]
	private List<EvolveDemoTools.Param> _evolveRequets;

	[NonSerialized]
	private byte[] _writeSrcBuffer;

	[NonSerialized]
	private bool _isMainSave;

	[NonSerialized]
	private bool _isBackupSave;

	private static bool _isPlayerInputActive;

	public static bool _isPlayerInputActive_ContactEvent;

	public static bool IsFieldKuruKuruStart;

	public static bool IsFieldFallStart;

	public static bool IsToUg;

	public static bool IsFromUg;

	public static bool ReserveZoneChangeNaminoriEnd;

	public const int InputNormal = 0;

	public const int InputLR = 1;

	public const int InputUD = 2;

	public const int InputCross = 3;

	public static List<WazaNo> UsedFieldWazaInArea;

	private bool _autosaveCoroutineIsBusy;

	private bool _autosaveWindowCoroutineIsBusy;

	private AutoSaveWindow _autosaveWindow;

	private float _autosaveWindowCloseOpenTime;

	private static bool isNeedFixPokemonExp;

	public static int playerID => default(int);

	public static string userName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool playerSex
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static MessageEnumData.GenderID playerGenderId => default(MessageEnumData.GenderID);

	public static int playerFashion
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static string rivalName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static ZoneID zoneID
	{
		get
		{
			return default(ZoneID);
		}
		set
		{
		}
	}

	public static bool NoSavePlayerPos
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static Vector2Int grid => default(Vector2Int);

	public static float height => default(float);

	public static float rotation => default(float);

	public static ZoneID transitionZoneID
	{
		get
		{
			return default(ZoneID);
		}
		set
		{
		}
	}

	public static int locatorIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static LOCATION_WORK? transitionLocation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static bool isBattling
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isContest
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isSealPreview
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isEvolveDemo
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isHatchDemo
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isDigFossil
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isGMS
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isMass
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool isEncount
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static int colorID
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static byte badge
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public static MessageEnumData.MsgLangId msgLangID
	{
		get
		{
			return default(MessageEnumData.MsgLangId);
		}
		set
		{
		}
	}

	public static int cassetVersion
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static bool isKanji
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static BTLTOWER_SAVEWORK btlTowerSave
	{
		get
		{
			return default(BTLTOWER_SAVEWORK);
		}
		set
		{
		}
	}

	public static bool bicycleGear
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static byte bicycleColor
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public static BATTLE_SETUP_PARAM battleSetupParam => null;

	public static PokeParty playerParty => null;

	public static PokemonParam capturedPokemon
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static MonsNo capturedMonsNo
	{
		[CompilerGenerated]
		get
		{
			return default(MonsNo);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static int capturedBallCountTvTopic
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

	public static List<EvolveDemoTools.Param> evolveRequets => null;

	public static bool encountEnable
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool isDebugDash => default(bool);

	public static bool isDebugWalk
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool isDebugPlayerVisible
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool isDebugBattleTextView
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static PLAYER_DATA playerData => default(PLAYER_DATA);

	public static MYSTATUS playerStatus => default(MYSTATUS);

	public static CONFIG config => default(CONFIG);

	public static CONTEST_DATA contestData => default(CONTEST_DATA);

	public static CON_PHOTO_LANG_DATA contestPhotoLangData => default(CON_PHOTO_LANG_DATA);

	public static CON_PHOTO_EXT_DATA[] contestPhotoExtData => null;

	public static GMS_DATA gmsData => default(GMS_DATA);

	public static GMS_POINT_HISTORY_EXT_DATA[] gmsExtData => null;

	public static PLAYER_NETWORK_DATA networkData => default(PLAYER_NETWORK_DATA);

	public static ZUKAN_WORK zukan
	{
		get
		{
			return default(ZUKAN_WORK);
		}
		set
		{
		}
	}

	public static bool isPlayerInputActive
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static uint uniqueID
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public static DefaultPokeType defaultPokeType
	{
		get
		{
			return default(DefaultPokeType);
		}
		set
		{
		}
	}

	public static MonsNo defaultPokeNo => default(MonsNo);

	public static DefaultPokeType rivalPokeType => default(DefaultPokeType);

	public static MonsNo rivalPokeNo => default(MonsNo);

	public static DefaultPokeType supportPokeType => default(DefaultPokeType);

	public static MonsNo supportPokeNo => default(MonsNo);

	public static TR_BATTLE_DATA[] tr_battleData
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static TOPMENU_WORK topMenu
	{
		get
		{
			return default(TOPMENU_WORK);
		}
		set
		{
		}
	}

	public static _FIELDOBJ_SAVE fieldObjSave
	{
		get
		{
			return default(_FIELDOBJ_SAVE);
		}
		set
		{
		}
	}

	public static RECORD_ARRAY record
	{
		get
		{
			return default(RECORD_ARRAY);
		}
		set
		{
		}
	}

	public static RECORD_ADD_DATA recordAddData
	{
		get
		{
			return default(RECORD_ADD_DATA);
		}
		set
		{
		}
	}

	public static string FieldWorpLinkName
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static string FieldWorpLabel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool isDebugNpcVisble
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool isDebugNpcPokeVisble
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static MonsNo DebugEncountMonsNo
	{
		[CompilerGenerated]
		get
		{
			return default(MonsNo);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static SYS_WEATHER FieldWeather
	{
		[CompilerGenerated]
		get
		{
			return default(SYS_WEATHER);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static ENC_SV_DATA Enc_SV_Data
	{
		get
		{
			return default(ENC_SV_DATA);
		}
		set
		{
		}
	}

	public static byte BtlSearcherCharge
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public static int HoneyLastTreeIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static HONEY_DATA[] HoneyData => null;

	public static long HoneyLastUpdateMinutes
	{
		get
		{
			return default(long);
		}
		set
		{
		}
	}

	public static int WalkEncountCount
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static PLAYER_SAVE_DATA PlayerSaveData
	{
		get
		{
			return default(PLAYER_SAVE_DATA);
		}
		set
		{
		}
	}

	public static float WalkCount
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static DoubleSlot DoubleSlot => default(DoubleSlot);

	public static _RANDOM_GROUP RandomGroup
	{
		get
		{
			return default(_RANDOM_GROUP);
		}
		set
		{
		}
	}

	public static int[] GimmickGearRotate
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static KinomiGrow[] KinomiGrows => null;

	public static long KinomiGrowLastUpdateMinutes
	{
		get
		{
			return default(long);
		}
		set
		{
		}
	}

	public static DayOfWeek Week => default(DayOfWeek);

	public static int DebugWeek
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

	public static int FieldInputMode
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

	public static bool IsZenmetuFlag
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool IsNeedUnloadOnFieldConnector
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static WarpType Warp
	{
		[CompilerGenerated]
		get
		{
			return default(WarpType);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool Telescope
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool TelescopeReturn
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static UgSaveData ugSaveData
	{
		get
		{
			return default(UgSaveData);
		}
		set
		{
		}
	}

	public static int ReturnZoneID
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static int ReturnUgZoneID
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static Vector3 UgReturnPos
	{
		get
		{
			return default(Vector3);
		}
		set
		{
		}
	}

	public static UGRecord UgRecord => default(UGRecord);

	public static UgCountRecord UgCountRecord => default(UgCountRecord);

	public static PoffinSaveData poffinSaveData => default(PoffinSaveData);

	public static int CookingCount
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static bool FieldCacheFlag
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static int SafariBallNum
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

	public static int SafariStepCount
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

	public static List<MonsNo> SafariCaptureMonsNo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static int IsCpuBoostMode
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

	public static ItemInfo UsedFieldItem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static WazaNo UsedFieldWazaNo
	{
		[CompilerGenerated]
		get
		{
			return default(WazaNo);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static int UsedFieldWazaTemotiNo
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

	public static bool Kiribarai
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public static bool Flash
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static SYSTEMDATA SystemData
	{
		get
		{
			return default(SYSTEMDATA);
		}
		set
		{
		}
	}

	public static bool PoketchOpen
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static POKETCH_DATA PoketchData
	{
		get
		{
			return default(POKETCH_DATA);
		}
		set
		{
		}
	}

	public static uint PoketchPedometer
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public static int TureWalkMemberIndex
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static AzukariyaData AzukariyaData => default(AzukariyaData);

	public static bool IsMovePokemon => default(bool);

	public static int MovePokemonIndex
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

	public static bool IsD26Key
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static _DENDOU_SAVEDATA dendoudata
	{
		get
		{
			return default(_DENDOU_SAVEDATA);
		}
		set
		{
		}
	}

	public static BadgeSaveData BadgeData
	{
		get
		{
			return default(BadgeSaveData);
		}
		set
		{
		}
	}

	public static int natuki_walkcnt
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public static BoukenNote boukenNote
	{
		get
		{
			return default(BoukenNote);
		}
		set
		{
		}
	}

	public static TV_DATA tvData
	{
		get
		{
			return default(TV_DATA);
		}
		set
		{
		}
	}

	public static UnionSaveData unionSaveData
	{
		get
		{
			return default(UnionSaveData);
		}
		set
		{
		}
	}

	public static MysteryGiftSaveData MysteryGiftData
	{
		get
		{
			return default(MysteryGiftSaveData);
		}
		set
		{
		}
	}

	public static ZUKAN_PERSONAL_RND_DATA zukanPersonalRndData
	{
		get
		{
			return default(ZUKAN_PERSONAL_RND_DATA);
		}
		set
		{
		}
	}

	public static POKETCH_POKETORE_COUNT_ARRAY poketoreCountArray
	{
		get
		{
			return default(POKETCH_POKETORE_COUNT_ARRAY);
		}
		set
		{
		}
	}

	public static DENDOU_SAVE_ADD dendouSaveAdd
	{
		get
		{
			return default(DENDOU_SAVE_ADD);
		}
		set
		{
		}
	}

	public static ReBuffnameData reBuffNameData
	{
		get
		{
			return default(ReBuffnameData);
		}
		set
		{
		}
	}

	public static PLAYREPORT_DATA playReportData
	{
		get
		{
			return default(PLAYREPORT_DATA);
		}
		set
		{
		}
	}

	public static PLAYREPORT_DATA playReportDataRef => default(PLAYREPORT_DATA);

	protected override void Initialization()
	{
	}

	private void ToBytes<T>(T obj, ref byte[] bytes)
	{
	}

	private void LoadBytes<T>(byte[] bytes, ref T obj)
	{
	}

	protected override bool CustomLoadOperation()
	{
		return default(bool);
	}

	protected override bool CustomSaveOperation()
	{
		return default(bool);
	}

	protected override bool CustomLoadAsyncOperation()
	{
		return default(bool);
	}

	private void OnPostLoadAsync(bool result)
	{
	}

	protected override bool CustomSaveAsyncOperation()
	{
		return default(bool);
	}

	protected override void OnPostLoad()
	{
	}

	private static void OnPostLoad_NeedMD()
	{
	}

	protected override void OnPreSave()
	{
	}

	public static void DataSave(bool isAsync = false, bool writeMain = true, bool writeBackup = false)
	{
	}

	public static void SaveAsync(bool writeMain = true, bool writeBackup = false)
	{
	}

	public static void DataLoad(bool isAsync = false, bool fromBackup = false)
	{
	}

	public static void LoadAsync(bool fromBackup = false)
	{
	}

	public static bool IsSaveSystemBusy()
	{
		return default(bool);
	}

	public static bool ExistBackUpData()
	{
		return default(bool);
	}

	public static int GetInt(EvWork.WORK_INDEX index)
	{
		return default(int);
	}

	public static void SetInt(EvWork.WORK_INDEX index, int value)
	{
	}

	public static bool GetBool(EvWork.FLAG_INDEX index)
	{
		return default(bool);
	}

	public static void SetBool(EvWork.FLAG_INDEX index, bool value)
	{
	}

	public static bool GetSytemFlag(EvWork.SYSFLAG_INDEX index)
	{
		return default(bool);
	}

	public static void SetSytemFlag(EvWork.SYSFLAG_INDEX index, bool value)
	{
	}

	public static void SetTransitionZone(ZoneID zoneID, int index = 0)
	{
	}

	public static void SetWarp(WarpType warp)
	{
	}

	public static void SetWarpSorawotobu(ZoneID zoneId, int locatorIndex)
	{
	}

	public static void SetPlayerPosData(FieldPlayerEntity player)
	{
	}

	public static void SetPlayerGrid(Vector2Int vec)
	{
	}

	public static void SetPlayerHeight(float height)
	{
	}

	public static void SetPlayerRotation(float rot)
	{
	}

	public static void SetMoney(int value)
	{
	}

	public static int GetMoney()
	{
		return default(int);
	}

	public static void SetItem(int itemno, SaveItem value)
	{
	}

	public static SaveItem GetItem(int itemno)
	{
		return default(SaveItem);
	}

	public static void SetUgItem(int ugItemNo, SaveUgItem value)
	{
	}

	public static SaveUgItem GetUgItem(int ugItemNo)
	{
		return default(SaveUgItem);
	}

	public static void SetItemShortcut(int id, ushort itemNo)
	{
	}

	public static ushort GetItemShortcut(int id)
	{
		return default(ushort);
	}

	public static int GetItemShortcutId(ushort itemNo)
	{
		return default(int);
	}

	public static int GetItemShortcutRegisteredCount()
	{
		return default(int);
	}

	public static SaveBoxData GetBoxData()
	{
		return default(SaveBoxData);
	}

	public static SaveBoxTrayData GetBoxTray(int tray)
	{
		return default(SaveBoxTrayData);
	}

	public static SaveBallDecoData GetBallDecoData()
	{
		return default(SaveBallDecoData);
	}

	public static SaveSealData GetSealData(int id)
	{
		return default(SaveSealData);
	}

	public static SaveSealData SetSealData(int id, SaveSealData value)
	{
		return default(SaveSealData);
	}

	public static void SetFormNormal()
	{
	}

	public static bool IsFormNormal()
	{
		return default(bool);
	}

	public static void SetFormBicycle()
	{
	}

	public static bool IsFormBicycle()
	{
		return default(bool);
	}

	public static void SetFormSwim()
	{
	}

	public static bool IsFormSwim()
	{
		return default(bool);
	}

	public static bool GetGakusyuusoutiFlag()
	{
		return default(bool);
	}

	public static uint GenerateUniqueId()
	{
		return default(uint);
	}

	public static void CreateAlpha1Party(PokeParty party)
	{
	}

	public static void DebugResetWork()
	{
	}

	public static void GetDateTime(out int year, out int month, out int day)
	{
	}

	public static void SetPlayerStatus(int selectIndex = 4, [Optional] string name)
	{
	}

	public static void SetPlayerStatus(bool sex, int colorId, [Optional] string name)
	{
	}

	public static CON_PHOTO_DATA GetPhotoDataByCategoryID(CategoryID categoryID)
	{
		return default(CON_PHOTO_DATA);
	}

	public static void SetPhotoDataByCategoryID(CategoryID categoryID, CON_PHOTO_DATA newData)
	{
	}

	public static MessageEnumData.MsgLangId GetPhotoLangIdByCategoryID(CategoryID categoryID)
	{
		return default(MessageEnumData.MsgLangId);
	}

	public static int GetTrainerRank()
	{
		return default(int);
	}

	public static bool IsEasyInput()
	{
		return default(bool);
	}

	public static bool VerifySaveData(byte[] byteArray)
	{
		return default(bool);
	}

	private void makeSaveDataHash(ref byte[] buf)
	{
	}

	public static LoadResult GetLoadResult()
	{
		return default(LoadResult);
	}

	private static void TakeOverOldVersion()
	{
	}

	public static void AutoSave(bool mainsave, bool backup)
	{
	}

	public static IEnumerator AutoSaveCoroutine(bool mainsave, bool backup)
	{
		return null;
	}

	private IEnumerator AutoSaveWindowAnime()
	{
		return null;
	}

	private static void CheckMoveAfterSaveGrid(ref Vector2Int pos)
	{
	}

	public static bool IsMyPokemon(CoreParam poke)
	{
		return default(bool);
	}

	private static void FixPokemonExpAll()
	{
	}

	private static bool FixPokemonExp(PokemonParam pp)
	{
		return default(bool);
	}
}
