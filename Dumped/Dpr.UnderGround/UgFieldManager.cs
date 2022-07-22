using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DPData;
using Dpr.Field.Walking;
using Dpr.Message;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Dpr.UI;
using Effect;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UnderGround;

public class UgFieldManager : MonoBehaviour
{
	public enum NowZoneType
	{
		Way,
		SecretBase,
		Kakurega
	}

	private enum EntryType
	{
		FirstEnter,
		NotZoneChange,
		ZoneChange,
		DigReturn,
		SaveReturn,
		_Error
	}

	public class DigData
	{
		private UgFieldManager mng;

		public bool PrevSceneisDigFossil;

		public List<DigPointModel> DigPoints => null;

		public List<SecretBaseModel> SecretBases => null;

		public DigData(UgFieldManager mng)
		{
		}
	}

	[Serializable]
	public class DigPointModel : MiniMapUIModelBase
	{
		public int StationIndex;

		public GameObject cube;

		public Transform EffectTra;

		public EffectInstance effIns;

		public bool isKirakiraNow;

		private static readonly Vector3[] directs;

		private static readonly Vector2Int[] offsets;

		public DigPointModel(int x, int y, int staionIndex)
		{
		}

		public Vector2Int GetEffOffset()
		{
			return default(Vector2Int);
		}

		public Vector3 GetPosition()
		{
			return default(Vector3);
		}

		public void SetActive(bool isActive)
		{
		}

		public void Destroy()
		{
		}

		public void KiraKira(float startDelay)
		{
		}
	}

	public abstract class MiniMapUIModelBase
	{
		public Vector2Int gridPos;

		public Image image;

		public bool isFriends;

		public void ToOverAllSizeUI()
		{
		}

		public void ToAroundSizeUI()
		{
		}
	}

	[Serializable]
	public class SecretBaseModel : MiniMapUIModelBase
	{
		public int StationIndex;

		public GameObject go;

		public UgSecretBase data;

		public SecretBaseModel(UgSecretBase secretBase, bool isFriends, GameObject go, int stationIndex)
		{
		}

		public bool IsCollide()
		{
			return default(bool);
		}
	}

	[SerializeField]
	private int d_stationIndex;

	[SerializeField]
	private int d_digGroupID;

	public static UgFieldManager Instance;

	public static bool isFallEnter;

	public bool isUgExiting;

	public bool isErrorDialogVisible;

	public Action OnCloseErrorDialog;

	private bool IsClosableMessage;

	private Action OnFinishMsg;

	private Action OnFinishBusy;

	private Action OnCreateOtherSecretBase;

	private bool IsBase;

	public bool isLoadedOrVisit;

	private UgNetworkManager ugNetManager;

	public float KousekiBonusTime;

	public byte KousekiCount;

	public byte BonusCount;

	public const int KOUSEKI_BONUS_START_NUM = 40;

	private const string UG_MSG_FILE = "dlp_underground";

	private const string YOBIKAKE = "DLP_underground_615";

	private const string BIG_MAP = "DLP_underground_430";

	private const string BIG_MAP_MESSAGE = "DLP_underground_431";

	private const string GOTO_GROUND = "DLP_underground_370";

	private const string GOTO_GROUND_MESSAGE = "DLP_underground_296";

	private const string CANCEL = "DLP_underground_371";

	private const string DIG_START_MESSAGE = "DLP_underground_263";

	private const string DRILL_USE_MESSAGE = "DLP_underground_471";

	private const string DRILL_USE_HIKKOSHI = "DLP_underground_280";

	private const string DRILL_TOO_NEAR = "DLP_underground_472";

	private const string DRILL_SAME_POS = "DLP_underground_473";

	private const string DRILL_TOO_NARROW = "DLP_underground_474";

	private const string ENTER_BASE = "DLP_underground_285";

	private const string ENTER_BASE_FRIEND = "DLP_underground_475";

	public StatueEffectRawData ugStatueEffectData;

	public static bool isDebug_RarePoke;

	public static bool isForceRareColor;

	private static readonly string[] Y_MENU_LABEL;

	private static readonly string[] Y_MENU_LABEL_ONLINE;

	private UgFieldDataManager dataMng;

	public static DigData digData;

	private static List<DigPointModel> DigPoints;

	[SerializeField]
	private UgMiniMapComponent miniMap;

	private ZoneID prevZoneID;

	private NowZoneType nowZoneType;

	private WalkingAIManager walkingManager;

	public FieldObjectEntity NpcEntity;

	public StatueBuff statueBuff;

	public UgSecretBase nowBaseModel;

	private int nowBasePlayerIndex;

	private UgNetworkManager.UgOnlinePlayerData nowBasePlayerData;

	public UgSecretBase EffectiveBase;

	public List<SecretBaseModel> SecretBases;

	public UgStationID_to_DigFossilIDList ugDigGroupList;

	private bool isDigCancel;

	private int targetStationIndex;

	private Action OnLeaveTargetPlayer;

	public static bool isEnableInput;

	public Action OnDestroyCallBack;

	public Action OnZoneChangeCallBack;

	public static bool isStartLeave;

	public static bool isGuruGuruAnimEnd;

	private float OnZoneChangeTime;

	private bool isDebugDraw;

	[SerializeField]
	private float duration;

	[SerializeField]
	private float searchSize;

	[SerializeField]
	private float searchDist;

	[SerializeField]
	private float TalkDistance;

	private List<Vector2Int> buffPosList;

	private bool isSearching;

	private Transform _dummy;

	public int Button02;

	public int Button04;

	private ContextMenuWindow contextMenu;

	private bool isContextMenuOpend;

	public int Button03;

	private Action OnComplete;

	private FieldObjectMove move;

	private FieldObjectRotateYaw rot;

	public int Button01;

	public int Button05;

	public int Button06;

	public UgNPCTalkModel NpcTalkModel;

	private bool[] results;

	private static readonly Vector3[] eightDirect;

	public int button111;

	public int Button001;

	public int button01;

	public int button02;

	public int button03;

	public int Button010;

	private int myStationIndex => default(int);

	public bool isKousekiBonus => default(bool);

	private bool IsKousekiFull => default(bool);

	public UgMiniMapComponent Minimap => null;

	public UgNetworkManager.UgOnlinePlayerData nowBasePlayerInfo => null;

	public bool isOtherBase => default(bool);

	public static bool isOnline => default(bool);

	public static bool isJoinOther => default(bool);

	public int effectiveBasePlayerIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static bool isInstantiated => default(bool);

	private Transform dummy => null;

	public bool IsContextMenuOpend => default(bool);

	public UgFieldDataManager GetDataMng()
	{
		return null;
	}

	private void InputUpdate(float deltaTime)
	{
	}

	private void Update()
	{
	}

	public bool IsBusy()
	{
		return default(bool);
	}

	private void SceneEndCheck()
	{
	}

	public void ErrorDialogCheck()
	{
	}

	private void ShowErrorDialog(bool PrevInputActive)
	{
	}

	private void MsgFinishCheck(float deltaTime)
	{
	}

	private void CloseMsgWindows()
	{
	}

	public void OnZoneChange()
	{
	}

	public void CreateDigPoints(int stationIndex)
	{
	}

	public void DeleteAllDigPoints()
	{
	}

	private void OnZoneChangeAfter(ZoneID zoneID)
	{
	}

	private void MyUpdate(float deltaTime)
	{
	}

	private void Awake()
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void StartSession()
	{
	}

	private void OnEmoticonDeside(int index)
	{
	}

	private void OnDestroy()
	{
	}

	public void ToAroundMapMode()
	{
	}

	public void ToAllOverMapMode()
	{
	}

	private void DebugDrawPokeRate()
	{
	}

	private void DebugKasekihoriDraw()
	{
	}

	private EntryType CheckEntryType(ZoneID zoneID, bool isLoaded)
	{
		return default(EntryType);
	}

	private void CheckWall()
	{
	}

	private void CreateDigPointGameObject(DigPointModel model)
	{
	}

	private DigPointModel CreateDigPointModel(UgDigFossilePosGroup fossilPosData)
	{
		return null;
	}

	private bool isNear(Vector2Int pos1, Vector2Int pos2)
	{
		return default(bool);
	}

	public void SearchDigPoint()
	{
	}

	public void KiraKira()
	{
	}

	private bool CheckDigPoint(DIR wallDIR)
	{
		return default(bool);
	}

	public void DigCancelCheck(float deltaTime)
	{
	}

	private bool CheckSecretBase(Vector2Int grid)
	{
		return default(bool);
	}

	private Vector2Int? GetWallGridPos()
	{
		return null;
	}

	public static void PlayerStop()
	{
	}

	private void OpenCreateHoleSelector(DIR wallDir, Vector2Int grid)
	{
	}

	public GameObject HoleInstantiate(DIR wallDir, Vector3 pos)
	{
		return null;
	}

	private void PlayHoleEffect(Vector3 pos, Quaternion rot)
	{
	}

	public Vector2Int GetReturnUGPos()
	{
		return default(Vector2Int);
	}

	public float GetReturnYawAngle()
	{
		return default(float);
	}

	public ZoneID GetSecBaseReturnZoneID()
	{
		return default(ZoneID);
	}

	private void YmenuHandler(int selectIndex)
	{
	}

	private void OpenCustomMenu()
	{
	}

	private void OpenGotoGroundSelector()
	{
	}

	private MsgWindowParam CreateMsgWindowParam(string msgFileName, string labelName)
	{
		return null;
	}

	public void GotoSecretBase(SecretBaseModel sbModel)
	{
	}

	private ZoneID GetSecretBaseZone(ZoneID zone, int expansionStatus)
	{
		return default(ZoneID);
	}

	private void SetSecretBasePlayerNameData(PlayerNameData nameData)
	{
	}

	private void CreateSecretBase(UgSecretBase secretBase)
	{
	}

	private void Anahori(UgSecretBase secretBase, Vector3 secBasePos)
	{
	}

	private Vector3 GetHoleCreatePosition(UgSecretBase secretBase)
	{
		return default(Vector3);
	}

	private float GetAngle(Vector3 targetPos, DIR wallDIR)
	{
		return default(float);
	}

	private float GetHoleCreateAngle(UgSecretBase secretBase)
	{
		return default(float);
	}

	public SecretBaseModel CreateSecretBase_Immidiate(UgSecretBase secretBase, int stationIndex)
	{
		return null;
	}

	public void DeleteTargetSecretBase(int stationIndex)
	{
	}

	private void DeleteSecretBase(SecretBaseModel model, bool immidiate)
	{
	}

	public void DeleteAllSecretBase()
	{
	}

	public bool GetNowSecretBaseEffective()
	{
		return default(bool);
	}

	public void SetEffectiveBase(UgSecretBase ugSecretBase)
	{
	}

	public bool IsUseTargetSecretBase(int stationIndex)
	{
		return default(bool);
	}

	public void EffectiveMyBase()
	{
	}

	public bool IsHaveSecretBase()
	{
		return default(bool);
	}

	private bool IsSecretBaseSameArea()
	{
		return default(bool);
	}

	public bool IsSameArea(ZoneID zoneID)
	{
		return default(bool);
	}

	public int GetAreaIDfromZoneID(ZoneID zoneID)
	{
		return default(int);
	}

	public void CreateReturnPoint()
	{
	}

	public void MoveTargetPos(Vector3 pos, float angle, Action onComplete)
	{
	}

	private void MoveUpdate(float deltaTime)
	{
	}

	public void SetMoveController()
	{
	}

	public void DeleteMoveController()
	{
	}

	public void CreateHyouta()
	{
	}

	public Vector2Int GetNpcRandomPos(ZoneID zoneID)
	{
		return default(Vector2Int);
	}

	public void CreateNPC(ZoneID zoneID)
	{
	}

	public void DeleteNpc()
	{
	}

	public static int GetNPCTalkCount()
	{
		return default(int);
	}

	public static void AddNPCTalkCount()
	{
	}

	private void D_GetNPCTalkCount()
	{
	}

	private void D_AddNPCTalkCount()
	{
	}

	private void D_ResetNPCTalkCount()
	{
	}

	public static void ResetNPCTalkCount()
	{
	}

	public void NPCTalk()
	{
	}

	public void DebugCheckWalls()
	{
	}

	private bool CheckAroundWalls()
	{
		return default(bool);
	}

	private Vector3 GetAdjustPos()
	{
		return default(Vector3);
	}

	private bool CheckResults(int[] index)
	{
		return default(bool);
	}

	private void DebugOnZoneChange()
	{
	}

	public void CreateSecretBaseRandom(int stationIndex)
	{
	}

	public void DebugCreateTonarihori()
	{
	}

	private void CreateTonarihoriGrids(Vector2Int mainPoint)
	{
	}

	public void CreateOtherTonariHori(NetDigData netDigData)
	{
	}

	private void ReplayTonarihoriEffect()
	{
	}

	public void DeleteTargetTonarihori(int stationIndex)
	{
	}

	private void SetLeaveCheckTarget(int stationIndex)
	{
	}

	private void ClearLeaveCheckTarget()
	{
	}

	private void OnLeaveOther(int LeavePlayerStationIndex)
	{
	}

	public void TEST()
	{
	}

	public void SAVE_POKE()
	{
	}

	public void LOAD_POKE()
	{
	}

	public bool AddKousekiCount(int num)
	{
		return default(bool);
	}

	public void UpdateKousekiUI()
	{
	}

	public void StartKousekiBonus(float RemainTime = 300f)
	{
	}
}
