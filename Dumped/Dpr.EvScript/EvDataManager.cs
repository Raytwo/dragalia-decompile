using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using Audio;
using DPData;
using Dpr.Battle.Logic;
using Dpr.Message;
using Dpr.MsgWindow;
using Dpr.Trainer;
using Dpr.UI;
using Effect;
using Pml;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using XLSXContent;

namespace Dpr.EvScript;

public class EvDataManager
{
	public class EntityParam
	{
		public string TalkLabel;

		public string ContactLabel;

		public int VanishFlagIndex;

		public bool IsContact;

		public EvWork.WORK_INDEX WorkIndex;

		public int WorkValue;

		public EntityType Type;

		public RectInt StopGridArea;

		public bool IsEventRunning;

		public int MoveCodeIndex;

		public bool Kairiki;

		public bool Iwakudaki;

		public bool Iaigiri;

		public bool Rockclimb;

		public int Dowsing;

		public bool SnowBall;

		public bool AzukariyaOldMan;

		public bool HoneyTree;

		public bool HeightIgnore;

		public Vector2 ContactSize;

		public bool IsContactCenter;

		public bool Sit;

		public int IdleAnimOverride;

		public int WalkAnimOverride;

		public TrainerID TrainerID;

		public int FieldObjectIndex;

		public int[] NearObject;

		public const int NearNone = -10;

		public float TalkRange;

		public bool isTalkHit;

		public float TalkAngle;

		public bool SaveObject;

		public ZoneID LocaitionZoneID;

		public bool IsObject;

		public Vector2 TalkSegment;

		public byte TalkBit;

		public int CharacterGraphicsIndex;

		public bool BattleReturnNotRotate;
	}

	public enum EntityType
	{
		Stop,
		Warp,
		Board,
		Npc
	}

	private enum CmpResult
	{
		MINUS,
		EQUAL,
		PLUS
	}

	private struct EvCallData
	{
		public int EventListIndex;

		public int LabelIndex;

		public int CommandIndex;
	}

	private struct PlaySeData
	{
		public string name;

		public AudioInstance AudioInstance;

		public uint playEventId;
	}

	public delegate void UpdateDelegate(float time);

	public delegate void EventEndDelegate();

	private struct WorpEventData
	{
		public FieldEventDoorEntity Entity;

		public int State;

		public float Time;
	}

	private enum COMMAND_USE_TIME
	{
		Week,
		Month,
		Day,
		Hour,
		Minute
	}

	private enum MsgWindowType
	{
		DEFAULT,
		NAME_PLATE,
		BOARD_TYPE_TOWN,
		BOARD_TYPE_ROAD,
		BOARD_TYPE_POST,
		BOARD_TYPE_INFO,
		ITEM,
		END
	}

	private enum MsgEndType
	{
		Input,
		Auto,
		Time,
		Manual
	}

	private struct MsgOpenParam
	{
		public string MsbtFile;

		public string Label;

		public int LabelIndex;

		public MsgWindowType WindowType;

		public bool Input;

		public string[] TrainerName;

		public MsgEndType EndType;

		public bool PlayTextFeedSe;
	}

	private enum BOARD
	{
		BOARD_REQ_WAIT,
		BOARD_REQ_ADD,
		BOARD_REQ_DOWN,
		BOARD_REQ_UP,
		BOARD_REQ_DEL,
		END
	}

	private enum TalkState
	{
		Init,
		EndWait,
		CloseWait
	}

	private enum HeroReqBit
	{
		Non = 0,
		Normal = 1,
		Banzai = 0x100
	}

	private enum CutInState
	{
		None,
		ResetForm,
		PostResetForm,
		Rotate,
		PoketchAnimeStart,
		WaitLoad,
		WaitCutIn,
		Sorawotobu_WaitPlayEffect,
		Sorawotobu_WaitPreCaptureInvisible,
		Sorawotobu_WaitNextCommand,
		PoketchAnimeEnd,
		End
	}

	private enum WazaOshieResult
	{
		OK,
		NG,
		Egg,
		Learned
	}

	private class LoadObjectData
	{
		public bool IsLoadFast;

		public int Distance;

		public bool IsCreated;

		public int AssetReqIndex;

		public string ObjectName;

		public PlaceData.SheetData PlaceData;

		public Vector2 Position;

		public float Height;

		public float Angle;

		public int MoveCode;

		public DIR MoveDirHead;

		public int MoveParam0;

		public int MoveParam1;

		public int MoveParam2;

		public int MoveLimitX;

		public int MoveLimitZ;

		public int Ev_Type;

		public int mv_old_dir;

		public int mv_dir;

		public bool useloadData;

		public int replaceGraphicIndex;
	}

	private class AssetReqOpeRef
	{
		public AssetRequestOperation ReqOpe;

		public int RefCount;

		public bool isEnd;
	}

	private class CreateWarp
	{
		public int index;

		public MapWarp.SheetData data;
	}

	private static EvDataManager _instanse;

	public static bool IsFirstInitializedAfterSaveDataLoad;

	private const string Path_Parsons = "persons/field/";

	private const string Path_Poke_Model = "pokemons/field/";

	private const int Graphic_Gimmick = 500;

	private const int Graphic_Poke = 10000;

	private const float HitMinSize = 3f;

	private const int Graphic_SekiZou = 1000;

	private const int Graphic_SekiZouMAX = 3000;

	private bool _isScriptLoad;

	private EvScriptData[] _eventList;

	private int _eventListIndex;

	private Stack<EvCallData> _callQueue;

	private Dictionary<string, int[]> _findAllLabel;

	private FieldObjectEntity _hit_object;

	private FieldObjectEntity _hit_object_sub;

	private Vector3 _hit_position;

	private CmpResult _cmp_flag;

	private AssetRequestOperation _scriptOperation;

	private AreaID _areaID;

	private const int WarpListLength = 30;

	private List<FieldEventEntity> _warpList;

	private MapWarp _warpData;

	private GameObject _warpRoot;

	private PlaySeData[] _se_datas;

	private PlaySeData[] _voice_datas;

	private Vector2Int _eventEndPosition;

	private string _posEventLabelReserve;

	private const int EntityParamLength = 50;

	private EntityParam[] _entityParamList;

	private GameObject _stopRoot;

	private bool _isInitFirstMap;

	private UpdateDelegate _updateDelegate;

	private EventEndDelegate _eventEndDelegate;

	private FieldEventDoorEntity _doorEntity;

	private WorpEventData _worpEventData;

	private Vector2Int _eqZoneWorpGrid;

	private bool _isEqZoneWorp;

	private FieldEventLiftEntity _liftEntity;

	private FieldTobariGymWallEntity _tobariGymWallEntity;

	private FieldNagisaGymGearEntity _nagisaGymGearEntity;

	private FieldNomoseGymSwitchEntity _nomoseGymSwitchEntity;

	private FieldEyePaintingEntity _eyePaintingEntity;

	private FieldEmbankmentEntity _embankmentEntity;

	private FieldMistPlate _mistPlate;

	private bool AzukariyaInitEventFlag;

	private int[] TvCommercials;

	private int TvCommercialsCurrentIndex;

	private string _callLabel_SceneChange;

	private string _callLabel_UpdateSP;

	private string _callLabel_AdjustHeroPos;

	private const int FieldObjectMoveCodesLength = 200;

	public List<FieldObjectMoveCode> FieldObjectMoveCodes;

	private bool _lateUpdateMoveCode;

	private bool _isCall_TrainerBtl;

	private EvCallData _battleReturnData;

	private FieldObjectEntity _battleReturnHitObject;

	private const int TRAINER_EYE_HITMAX = 2;

	private const int SCR_EYE_TR_TYPE_SINGLE = 0;

	private const int SCR_EYE_TR_TYPE_DOUBLE = 1;

	private const int SCR_EYE_TR_TYPE_TAG = 2;

	private FieldObjectMoveCode[] _eyeEncountTarget;

	private Balloon[] _eyeEncountBallon;

	private float _eyeEncountWait;

	private int _eyeEncountSeq;

	private int[] _talkTrinerIndex;

	public TrainerType Btl_TrainerType1;

	public TrainerType Btl_TrainerType2;

	private int _ugSeq;

	private Vector3 _ugEndPos;

	private Vector3 _ugHoleRot;

	private const float _fallSpd = 0.25f;

	private const float _fallOffset = 15f;

	private const float _fallRotSpd = 35f;

	private const float _fallDiveSpd = 15f;

	private const float _fallDiveAcce = 0.1f;

	private float _ugFallSpdCurrent;

	private int _ugDiveSeq;

	private float _ugDiveUpdateTime;

	private float _ugDiveRotTime;

	private float _ugDiveRotStart;

	private float _ugDiveRotEnd;

	private float _ugDiveJumpingTime;

	private const float _fromRotSpd = 50f;

	private const float _fromRotAcce = 4f;

	private const float _fromRotSpdMin = 10f;

	private int _ugFromSeq;

	private float _ugFromJumpTime;

	private float _ugFromRotSpdCurrent;

	private UgJumpPos.SheetData _ugNextJumpPos;

	private FieldToUgInvisibleObjects _toUgInvisibleObjects;

	private ZoneID _cacheZoneID_SceneChange;

	private bool _pendingInitScripts;

	public ZoneID SorawotobuZoneId;

	public int SorawotobuLocatorIndex;

	private EventCameraTable _evCameraTable;

	private TairyouHasseiPokeManager _tairyouHasseiMane;

	private bool _isFadeEventReturnInput;

	private float _cloudSpeed;

	private float _cloudTime;

	private const float _const_cloudTime = 5f;

	private const float _app_frame = 1f / 30f;

	private const int _WORK_TRUE = 1;

	private const int _WORK_FALSE = 0;

	private const string SEQ_SE_DP_SELECT = "UI_common_decide";

	private int _switch_work_index;

	private float _timeWait;

	private MsgWindowParam _msgWindowParam;

	private MsgWindowParam _msgWindowParamOther;

	private MsgOpenParam _msgOpenParam;

	private bool _isAutoMsg;

	private MSGSPEED _eMsgSpeed;

	private float _autoTime;

	private BOARD _boardState;

	private Dpr.MsgWindow.MsgWindow _msgWindow;

	private Dpr.MsgWindow.MsgWindow _msgWindowOther;

	private Coroutine _msgWindowCoroutine;

	private TalkState _talkStart;

	private EvCmdID.NAME _macroCmd;

	private EvCmdID.NAME _procCmd;

	private string _talkOpenMsbt;

	private string _talkOpenLabel;

	private float _turnEndFrame_Hero;

	private float _turnEndFrame_Obj;

	private float[] _turnTime;

	private Quaternion[] _turnEndQuaternion;

	private bool[] _turnDiffFlag;

	private float _deltatime;

	private string _mapChangeZoneID;

	private int _mapChangeIndex;

	private Quaternion _moveGridCenterStart;

	private Quaternion _moveGridCenterEnd;

	private bool _isOpenSubContentsMenu;

	private bool _isWaitCheckOnlineAccount;

	private string _custumWindow_msbt;

	private List<string> _custumWindow_Labels;

	private List<int> _custumWindow_RetIndex;

	private FieldEventEntity _selectDoorObject;

	private float _fadeSpeed;

	private HeroReqBit _heroReqBit;

	private DIR _heroMoveGridCenterFrontDir;

	private bool _heroMoveGridCenterFrontStat;

	private FieldObjectMove _fieldObjectMove;

	private FieldObjectRotateYaw _fieldObjectRotateYaw;

	private FieldFloatMove _fieldFloatMove;

	private int _hidenSequence;

	private Vector3 _takiTargetPosition;

	private Vector3 _rockClimbingEndPos;

	private Vector3 _rockClimbingStandPos;

	private bool _hidenEffectWait;

	private bool _rideBicycleReserve;

	private FieldEventLiftEntity _runEventLiftEntity;

	private int _liftSequence;

	private int _gearSequence;

	private int _waterSequence;

	private int _kinomiSequence;

	private float _kinomiSequenceTime;

	private EffectInstance _kinomiEffect;

	private int _warpSequence;

	private int _warpSpeedSequence;

	private float _warpSpeedSequenceTime;

	private int _scopeSequence;

	private int _azukariyaSequence;

	private int _pokelistSequence;

	private int _pokelistBox;

	private int _pokelistIndex;

	private int _trainSequence;

	private int _itemSequence;

	private int _btwrSequence;

	private bool _isOpenSpecialWin;

	private int _openSpecialWinLabelSelected;

	private TV_PROGRAM _currentTvProgram;

	private CutInState _cutinState;

	private const int TRMSG_FIGHT_START = 0;

	private const int TRMSG_FIGHT_LOSE = 1;

	private const int TRMSG_FIGHT_AFTER = 2;

	private const int TRMSG_FIGHT_START_1 = 3;

	private const int TRMSG_FIGHT_LOSE_1 = 4;

	private const int TRMSG_FIGHT_AFTER_1 = 5;

	private const int TRMSG_POKE_ONE_1 = 6;

	private const int TRMSG_FIGHT_START_2 = 7;

	private const int TRMSG_FIGHT_LOSE_2 = 8;

	private const int TRMSG_FIGHT_AFTER_2 = 9;

	private const int TRMSG_POKE_ONE_2 = 10;

	private const int TRMSG_FIGHT_NONE_DN = 11;

	private const int TRMSG_FIGHT_NONE_D = 12;

	private const int TRMSG_FIGHT_FIRST_DAMAGE = 13;

	private const int TRMSG_FIGHT_POKE_HP_HALF = 14;

	private const int TRMSG_FIGHT_POKE_LAST = 15;

	private const int TRMSG_FIGHT_POKE_LAST_HP_HALF = 16;

	private const int TRMSG_REVENGE_FIGHT_START = 17;

	private const int TRMSG_REVENGE_FIGHT_START_1 = 18;

	private const int TRMSG_REVENGE_FIGHT_START_2 = 19;

	private const int MUGEN_LOOP = 5000;

	private bool _isShopOpen;

	private int _bagSelectItemNo;

	private FloorWindow _floorWindow;

	private MoneyWindow _moneyWindow;

	private StringBuilder matchingPassword;

	private static Dictionary<int, MonsNo> KasekiFukugenTable;

	private int _openTownMapSeq;

	private bool _isOpenBtlTowerRecode;

	private int _softwareKeyboardSubState;

	private int _effSeq;

	private bool _pc_window_close;

	private int _dendou;

	private FieldAnimatorController[] _umaAnimatorCtr;

	private bool _isOpenCustomBallTrainer;

	private int _nicknamePlacementSequence;

	private EffectInstance[] _scriptEffects;

	private Coroutine[] _scriptScaleCorutine;

	private bool[] _scriptScaleVectol;

	private PokemonParam _temp_PokePara;

	private bool _isBattleTowerBtl;

	private bool _isBattleTowerWin;

	private Vector2 _playerMoveGridCenterAngle;

	private EvScriptData _evData;

	private EvData.Script _evScript;

	private EvData.Command _evCommand;

	private EvData.Aregment[] _evArg;

	private int btlsearchSeq;

	private AudioInstance btlserchAudio;

	private bool _isOpenHallOfFame;

	private const int RockClimbSequence_None = 0;

	private const int RockClimbSequence_JumpUp = 1;

	private const int RockClimbSequence_JumpLoop = 2;

	private const int RockClimbSequence_Climb = 3;

	private const int RockClimbSequence_EndJumpUp = 4;

	private const int RockClimbSequence_EndJumpLoop = 5;

	private const int RockClimbSequence_EndJumpEnd = 6;

	private Coroutine _cmdReportSaveCoroutine;

	private int _seqRankingView;

	private static (int, int, int)[] PokemonSizeTable;

	private bool _isOpenCertificate;

	private int returnSequenceID;

	public static bool EventCameraEnable;

	private bool _boukennootoTipsOpen;

	private const int FashionSeq_Reqest = 0;

	private const int FashionSeq_Wait = 1;

	private const int FashionSeq_End = 2;

	private const int FashionSeq_Error = 999;

	private int _fashionLoadSeq;

	private string _oldfashionAssetReqUri;

	private AssetRequestOperation _fashionAssetReqOp;

	private float _fashionYawAngle;

	private Vector3 _fashionWorldpos;

	private bool _isTraining;

	private bool _isOpenTraining;

	private const int LIGHT_FILED = 0;

	private const int LIGHT_CHAR = 1;

	private const int LIGHT_POKE = 2;

	private const int LIGHT_MAX = 3;

	private float[] _setlight_timer;

	private float[] _setlight_timer_limit;

	private float[] _start_lightIntensity;

	private float[] _end_lightIntensity;

	private bool[] _isRunningLight;

	public List<string> Debug_01_DebugLabel;

	public List<string> DebugSceneEventLabel;

	private const int FieldObjectEntityLength = 100;

	private const int FieldKinomiGrowEntityLength = 30;

	public List<FieldObjectEntity> _fieldObjectEntity;

	public List<FieldKinomiGrowEntity> _FieldKinomiGrowEntity;

	private List<AssetReqOpeRef> _AssetReqOpeList;

	private List<LoadObjectData> _loadObjectList;

	private int _loadObjectIndex;

	private Transform _loadObjectParent;

	private bool _nowInstantiate;

	private const int _PoolLength = 100;

	private Dictionary<int, GameObject> _poolLoadObjects;

	public static EvDataManager Instanse => null;

	public bool IsPosEventReserved => default(bool);

	public FieldObjectEntity _dummyPlayer
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FieldPokemonCenter PokemonCenter
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Telescope Telescope
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public TelescopeNagisa TelescopeNagisa
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FieldWazaCutIn FieldWazaCutIn
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public InterviewWork InterviewWork
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public FieldShip FieldShip
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public event Action<EntityParam> OnTalkStartCallBack
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public bool IsContactDoor()
	{
		return default(bool);
	}

	private EvDataManager()
	{
	}

	public void Destroy()
	{
	}

	public void SceneChangeRelease()
	{
	}

	public void CacheSceneChangeRelease()
	{
	}

	public bool UpdateStart()
	{
		return default(bool);
	}

	public void CallFieldWarpExitLabel()
	{
	}

	public void FieldZoneChange(bool walk = true)
	{
	}

	public void ResetVanishFlagObject()
	{
	}

	private void PendingInitScripts()
	{
	}

	private void WalkInit()
	{
	}

	private void MapJumpInit()
	{
	}

	public bool m_Update(float time)
	{
		return default(bool);
	}

	public bool m_LateUpdate(float time)
	{
		return default(bool);
	}

	private bool FindLabel(string label)
	{
		return default(bool);
	}

	private bool CheckSceneChangeLabel()
	{
		return default(bool);
	}

	private void SetBattleReturn()
	{
	}

	private bool CheckBattleReturnLabel()
	{
		return default(bool);
	}

	private bool CheckUpdateSPLabel()
	{
		return default(bool);
	}

	private bool CheckSafariEvent()
	{
		return default(bool);
	}

	public void SetSafariEndEventFromBattle(BtlResult btlResult)
	{
	}

	public void RetireSafari()
	{
	}

	public void SetSafariScopeEvent()
	{
	}

	public void SetSafariScopeEndEvent()
	{
	}

	public void SetNagisaScopeEvent()
	{
	}

	public void SetNagisaScopeEndEvent()
	{
	}

	public void UpdatePartyEggHatchingCount(int step)
	{
	}

	private int GetPartyEggHatchingValue(int step)
	{
		return default(int);
	}

	private bool CheckPartyEggHatching()
	{
		return default(bool);
	}

	private void EggHatchingEvent()
	{
	}

	private void UpdateWait(float time)
	{
	}

	public void OnOpenMenu()
	{
	}

	public void OnCloseMenu()
	{
	}

	public bool IsRunningEvent()
	{
		return default(bool);
	}

	public bool CheckPosEvent(out Vector3 outWorldPos, FieldPlayerEntity player)
	{
		return default(bool);
	}

	public EntityParam GetPosEventFromGrid(Vector2Int gridPos)
	{
		return null;
	}

	private bool IsPosEventOverWarp(ref Vector3 pos)
	{
		return default(bool);
	}

	private void PlayerInputActive(bool active, bool animation = true)
	{
	}

	private void SetEventListIndex(int idx)
	{
	}

	private void CloudScaleReset()
	{
	}

	private void SetCloudScaleStart()
	{
	}

	private void SetCloudScaleEnd()
	{
	}

	private void EnvironmentControllerCallBack(EnvironmentController controller, float deltaTime)
	{
	}

	public bool JumpLabel(string label, [Optional] EventEndDelegate callback)
	{
		return default(bool);
	}

	public bool CallLabel(string label)
	{
		return default(bool);
	}

	public bool ReturnEvData()
	{
		return default(bool);
	}

	private FieldCharacterEntity GetFieldCharacterEntity(string id)
	{
		return null;
	}

	private FieldObjectEntity Find_fieldObjectEntity(string id)
	{
		return null;
	}

	public FieldObjectEntity GetFieldObject(string id)
	{
		return null;
	}

	private FieldObjectEntity GetFieldObject(int id)
	{
		return null;
	}

	public FieldEventEntity GetFieldEventEntity(string id)
	{
		return null;
	}

	private bool IsMoveEnd(string id = "")
	{
		return default(bool);
	}

	private bool ScriptStartCheck(float time)
	{
		return default(bool);
	}

	public Vector3 CalcContactCheckPos()
	{
		return default(Vector3);
	}

	public bool CanContact(FieldObjectEntity obj, Vector3 playerpos)
	{
		return default(bool);
	}

	public bool CanContact2(FieldObjectEntity obj, Vector3 playerpos)
	{
		return default(bool);
	}

	public void ClearPlayerMoveVector()
	{
	}

	public bool RunObjectEvent(int idx, FieldObjectEntity obj, string label)
	{
		return default(bool);
	}

	private bool IsTalkBitMask(ref Vector2 target, ref Vector2 talkpont, byte mask)
	{
		return default(bool);
	}

	private bool IsHit(Vector3 traA, Vector3 traB, Vector2 rangB, bool center)
	{
		return default(bool);
	}

	private float PlayerDiffAngle(ref Vector2 diff)
	{
		return default(float);
	}

	private bool IsCircleHit(ref Vector2 v1, ref Vector2 v2, float range, out float outAngle)
	{
		return default(bool);
	}

	private bool IsCircleHit(ref Vector2 v1, ref Vector2 v2, float range)
	{
		return default(bool);
	}

	private bool WarpListCheck()
	{
		return default(bool);
	}

	private void EvCmdCmpMain(EvWork.WORK_INDEX r1, EvWork.WORK_INDEX r2)
	{
	}

	public void OnEventEnter(float deltaTime, FieldEventEntity eventEntity)
	{
	}

	public void OnEventStay(float deltaTime, FieldEventEntity eventEntity)
	{
	}

	public void OnEventLeave(float deltaTime, FieldEventEntity eventEntity)
	{
	}

	public void ResetGimmickEntityRef()
	{
	}

	public bool IsDowsingEnable(FieldObjectEntity entity)
	{
		return default(bool);
	}

	private bool WarpHit(FieldEventDoorEntity eventEntity)
	{
		return default(bool);
	}

	private void CorrectionEventEntityWait(float deltatime)
	{
	}

	private bool CorrectionDirCheck(FieldEventEntity eventEntity)
	{
		return default(bool);
	}

	private void CorrectionDirSegment(FieldEventEntity eventEntity, out Vector2 segStart, out Vector2 segEnd)
	{
	}

	private float CorrectionDirAngle(FieldEventEntity eventEntity)
	{
		return default(float);
	}

	private bool IsLiftHit(FieldEventLiftEntity liftEntity)
	{
		return default(bool);
	}

	private bool IsNagisaGymGearHit(FieldNagisaGymGearEntity gymGearEntity)
	{
		return default(bool);
	}

	private bool IsNomoseGymSwitchHit(FieldNomoseGymSwitchEntity gymSwitchEntity)
	{
		return default(bool);
	}

	private bool IsEyePaintingHit(FieldEyePaintingEntity eyePaintingEntity)
	{
		return default(bool);
	}

	private bool IsEmbankmentHit(FieldEmbankmentEntity embankmentEntity)
	{
		return default(bool);
	}

	private bool IsEventHit(FieldEventEntity eventEntity)
	{
		return default(bool);
	}

	private bool IsWorpHit(FieldEventEntity eventEntity)
	{
		return default(bool);
	}

	private void WarpUpdate(float time)
	{
	}

	private void WarpUpdateEnd()
	{
	}

	private void EqualZoneWarp(float time)
	{
	}

	public void SetWork(int index, int val)
	{
	}

	public void SetWork(EvWork.WORK_INDEX index, int val)
	{
	}

	public int GetWork(int index)
	{
		return default(int);
	}

	public int GetWork(EvWork.WORK_INDEX index)
	{
		return default(int);
	}

	public EvWork.FLAG_INDEX SetFlag(int index, bool val)
	{
		return default(EvWork.FLAG_INDEX);
	}

	public void SetFlag(EvWork.FLAG_INDEX index, bool val)
	{
	}

	public int GetFlag(EvWork.FLAG_INDEX index)
	{
		return default(int);
	}

	public int GetFlag(int index)
	{
		return default(int);
	}

	public void SetSysFlag(EvWork.SYSFLAG_INDEX index, bool val)
	{
	}

	public void SetSysFlag(int index, bool val)
	{
	}

	public int GetSysFlag(EvWork.SYSFLAG_INDEX index)
	{
		return default(int);
	}

	public int GetSysFlag(int index)
	{
		return default(int);
	}

	public int GetArgInt(EvData.Aregment arg)
	{
		return default(int);
	}

	public float GetArgFloat(EvData.Aregment arg)
	{
		return default(float);
	}

	public string GetArgString(EvScriptData ev, EvData.Aregment arg)
	{
		return null;
	}

	public int GetBadgeCount()
	{
		return default(int);
	}

	private string GetTrainerMsg(int tr_id, int kind)
	{
		return null;
	}

	private string GetTrainerRevengeMsg(int tr_id, int kind)
	{
		return null;
	}

	private bool PlaySe(string name)
	{
		return default(bool);
	}

	private bool PlayVoice(string name)
	{
		return default(bool);
	}

	private bool StopSe(string name)
	{
		return default(bool);
	}

	private bool StopVoice(string name)
	{
		return default(bool);
	}

	private bool IsPlayingSe(string name = "")
	{
		return default(bool);
	}

	private bool IsPlayingVoice(string name = "")
	{
		return default(bool);
	}

	public void PlayVoice(int monsNo, int formNo, int voiceType)
	{
	}

	public void PlayVoiceUI(int monsNo, int formNo, int voiceType)
	{
	}

	private void SpLabel_Init(ZoneID id)
	{
	}

	private void SpLabel_Obj(ZoneID id)
	{
	}

	public void SpLabel_Scene(ZoneID id)
	{
	}

	private void SpLabel_Flag(ZoneID id)
	{
	}

	public void Jump_InitScr()
	{
	}

	private void FindTrainerIndex(int index, TrainerID id)
	{
	}

	private TrainerTable.SheetTrainerData GetTrainer(int index)
	{
		return null;
	}

	private TrainerTable.SheetTrainerType GetTrainerType(TrainerType id)
	{
		return null;
	}

	private void BattleTrainer(TrainerID enemy1, TrainerID enemy2 = TrainerID.NONE, TrainerID partner = TrainerID.NONE)
	{
	}

	public void ForceEyeEncount(TrainerID trainerID)
	{
	}

	public bool TrainerEyeCheck(ref Vector3 moveVector, ref Vector2 hitpos)
	{
		return default(bool);
	}

	private void OnEyeCallBack(FieldObjectMoveCode mvobj)
	{
	}

	private void EyeTrainerSetUp(float time)
	{
	}

	private bool EyeEncount(FieldObjectMoveCode mvobj, float time)
	{
		return default(bool);
	}

	private bool EyeEncountTagTrainer(FieldObjectMoveCode mvobj1, FieldObjectMoveCode mvobj2, float time)
	{
		return default(bool);
	}

	private void UG_GuruGuruHole(float time)
	{
	}

	public bool isUpdateDelegate()
	{
		return default(bool);
	}

	private void ARRIVEDATA_SetArriveFlag(ZoneID id)
	{
	}

	private bool IsPlayingUgEnterOrExit()
	{
		return default(bool);
	}

	public void UG_EnterOrExit()
	{
	}

	public bool IsCanGotoUG()
	{
		return default(bool);
	}

	public bool CheckPlaceData()
	{
		return default(bool);
	}

	private UgJumpPos.SheetData GetUgJumpPosData(int MatrixID)
	{
		return null;
	}

	private void GotoOnTheGround()
	{
	}

	private void SetupUgHolePosRot(GameObject ugObject)
	{
	}

	private void GotoUnderGround()
	{
	}

	private void FromUnderGround()
	{
	}

	public void PlayerRising(float deltaTime)
	{
	}

	public void PlayerFall(float deltaTime)
	{
	}

	private void UG_HoleDive(float time)
	{
	}

	private void UG_From(float time)
	{
	}

	private void StartAdjustHeroPos(float deltaTime, string label)
	{
	}

	private bool CheckUpdateAdjustHeroPos(float deltaTime)
	{
		return default(bool);
	}

	private void UpdateAdjustHeroPos(float deltaTime)
	{
	}

	public bool CheckEventObjectGrid(int x, int y, float height)
	{
		return default(bool);
	}

	private static bool CheckEventObjectGridCore(FieldObjectEntity entity, int x, int y, float height)
	{
		return default(bool);
	}

	private void EntityMoveCodeCheck()
	{
	}

	private bool SetNearIndex(ref EntityParam param, int index)
	{
		return default(bool);
	}

	public void SetBtlSearchEndEvent(UpdateDelegate degate)
	{
	}

	public void EndSpray()
	{
	}

	private void ChkFadeInput()
	{
	}

	private void SetCommandUseTime()
	{
	}

	private int GetCommandUseTime(COMMAND_USE_TIME use)
	{
		return default(int);
	}

	private void VariableReset()
	{
	}

	private void EventEnd()
	{
	}

	private bool OpenTalk(MsgOpenParam msgparam)
	{
		return default(bool);
	}

	private MessageMsgFile GetMSBTFile(string msbtfilename)
	{
		return null;
	}

	private IEnumerator OpenMsgFile(MsgOpenParam msgparam)
	{
		return null;
	}

	private void CloseMsg()
	{
	}

	private bool CommandEquals(string eq, int val1, int val2)
	{
		return default(bool);
	}

	private bool IfJump_Call(bool jump, string eq, string label)
	{
		return default(bool);
	}

	private string ReEQType(string eq)
	{
		return null;
	}

	private bool Cmd_TalkMsg(EvScriptData ev, bool index = false)
	{
		return default(bool);
	}

	private bool Cmd_ExplanationMsg(string msgfile, string label)
	{
		return default(bool);
	}

	private bool Cmd_TalkMsg(string msbt, string label)
	{
		return default(bool);
	}

	private void Cmd_TalkWindOpen()
	{
	}

	private void Cmd_TalkWindClose()
	{
	}

	private void Cmd_TrainerTalkTypeGet(int wk1, int wk2, int wk3)
	{
	}

	private void Cmd_RevengeTrainerTalkTypeGet(int wk1, int wk2, int wk3)
	{
	}

	private bool CheckTrainer2vs2Type(int tr_id)
	{
		return default(bool);
	}

	private bool EvCmdTrainerMessageSet(int wk1, int wk2)
	{
		return default(bool);
	}

	private void EvCmdBoardMake(EvScriptData ev)
	{
	}

	private bool EvCmdBoardReqDpr(EvScriptData ev)
	{
		return default(bool);
	}

	private bool EvCmdBoardReqDpr()
	{
		return default(bool);
	}

	private bool EvCmdBoardReqWait()
	{
		return default(bool);
	}

	private bool EvCmdBoardEndWait(EvWork.WORK_INDEX work)
	{
		return default(bool);
	}

	private void EvCmdInfoBoardMake(EvScriptData ev)
	{
	}

	private void Cmd_If_Jump(string type, string label)
	{
	}

	private bool Cmd_TalkObjStart()
	{
		return default(bool);
	}

	private bool Cmd_TalkObjStartTurnNot()
	{
		return default(bool);
	}

	private bool Cmd_LastKeyWait()
	{
		return default(bool);
	}

	private bool Cmd_TalkStart()
	{
		return default(bool);
	}

	public bool Cmd_ObjPauseAll()
	{
		return default(bool);
	}

	public bool Cmd_ObjPauseClearAll()
	{
		return default(bool);
	}

	private IEnumerator TurnEnumerator(int index)
	{
		return null;
	}

	private bool Turn_HitObjectToHero()
	{
		return default(bool);
	}

	private bool Turn_HeroToHitObject()
	{
		return default(bool);
	}

	private bool ObjectTurn(float time, float endtime, ref Vector3 target, FieldObjectEntity myEntity, int index)
	{
		return default(bool);
	}

	private string[] GetMsbtFileLabel(string cmdarg)
	{
		return null;
	}

	private bool CmdMapChange(EvScriptData ev)
	{
		return default(bool);
	}

	private bool CmdMapChangeNoneFade(EvScriptData ev)
	{
		return default(bool);
	}

	private bool StackMapChange()
	{
		return default(bool);
	}

	private bool YesNoWindow(EvScriptData ev)
	{
		return default(bool);
	}

	private bool CustumWindow(EvData.Command data, bool wordSet = false)
	{
		return default(bool);
	}

	private bool CmdPlayerMoveGridCenter(EvData.Command data)
	{
		return default(bool);
	}

	private bool CmdPokemonName(EvData.Command data)
	{
		return default(bool);
	}

	private bool CmdFirstPokemonName(EvData.Command data)
	{
		return default(bool);
	}

	private bool CmdRivalPokemonName(EvData.Command data)
	{
		return default(bool);
	}

	private bool CmdSupportPokemonName(EvData.Command data)
	{
		return default(bool);
	}

	private bool CmdPokemonNameIndex(int index, int pos)
	{
		return default(bool);
	}

	private bool CmdPokemonNickNameIndex(int index, int pos)
	{
		return default(bool);
	}

	private bool CmdPokemonNickNameIndexBox(int index, int tray, int pos)
	{
		return default(bool);
	}

	private bool CmdGetRelPosHero(EvScriptData ev)
	{
		return default(bool);
	}

	private bool CmdSxyExitPosChange(EvData.Command data)
	{
		return default(bool);
	}

	private TrainerID GetArgTrainerID(EvScriptData ev, EvData.Aregment arg)
	{
		return default(TrainerID);
	}

	private bool CmdTrainerBtlSet(EvScriptData ev)
	{
		return default(bool);
	}

	private bool CmdTrainerBtlSetMulti(EvScriptData ev)
	{
		return default(bool);
	}

	private bool CmdTrainerBgmSet(EvData.Command data)
	{
		return default(bool);
	}

	private bool CmdVisibleObjProp(EvScriptData ev, bool flag)
	{
		return default(bool);
	}

	private bool CmdFirstPokeSelectProc(EvScriptData ev)
	{
		return default(bool);
	}

	private bool UpdateEvdata(float time, bool sp_script = false)
	{
		return default(bool);
	}

	private bool EvCmdNop()
	{
		return default(bool);
	}

	private bool EvCmdDummy()
	{
		return default(bool);
	}

	private bool EvCmdEnd()
	{
		return default(bool);
	}

	private bool EvCmdTimeWait()
	{
		return default(bool);
	}

	private bool EvCmdLoadRegValue()
	{
		return default(bool);
	}

	private bool EvCmdLoadRegWData()
	{
		return default(bool);
	}

	private bool EvCmdLoadRegAdrs()
	{
		return default(bool);
	}

	private bool EvCmdLoadAdrsValue()
	{
		return default(bool);
	}

	private bool EvCmdLoadAdrsReg()
	{
		return default(bool);
	}

	private bool EvCmdLoadRegReg()
	{
		return default(bool);
	}

	private bool EvCmdLoadAdrsAdrs()
	{
		return default(bool);
	}

	private bool EvCmdCmpRegReg()
	{
		return default(bool);
	}

	private bool EvCmdCmpRegValue()
	{
		return default(bool);
	}

	private bool EvCmdCmpRegAdrs()
	{
		return default(bool);
	}

	private bool EvCmdCmpAdrsReg()
	{
		return default(bool);
	}

	private bool EvCmdCmpAdrsValue()
	{
		return default(bool);
	}

	private bool EvCmdCmpAdrsAdrs()
	{
		return default(bool);
	}

	private bool EvCmdCmpWkValue()
	{
		return default(bool);
	}

	private bool EvCmdCmpWkWk()
	{
		return default(bool);
	}

	private bool EvCmdDebugWatch()
	{
		return default(bool);
	}

	private bool EvCmdVMMachineAdd()
	{
		return default(bool);
	}

	private bool EvCmdChangeCommonScr()
	{
		return default(bool);
	}

	private bool EvCmdChangeLocalScr()
	{
		return default(bool);
	}

	private bool EvCmdGlobalJump()
	{
		return default(bool);
	}

	private bool EvCmdObjIDJump()
	{
		return default(bool);
	}

	private bool EvCmdBgIDJump()
	{
		return default(bool);
	}

	private bool EvCmdPlayerDirJump()
	{
		return default(bool);
	}

	private bool EvCmdGlobalCall()
	{
		return default(bool);
	}

	private bool EvCmdRet()
	{
		return default(bool);
	}

	private bool EvCmdIfJump()
	{
		return default(bool);
	}

	private bool EvCmdIfCall()
	{
		return default(bool);
	}

	private bool EvMacro_IFVAL_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_IFVAL_CALL()
	{
		return default(bool);
	}

	private bool EvMacro_IFWK_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_IFWK_CALL()
	{
		return default(bool);
	}

	private bool EvMacro_SWITCH()
	{
		return default(bool);
	}

	private bool EvMacro_CASE_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_CASE_CANCEL()
	{
		return default(bool);
	}

	private bool EvCmdTimeWaitIconAdd()
	{
		return default(bool);
	}

	private bool EvCmdTimeWaitIconDel()
	{
		return default(bool);
	}

	private bool EvCmdFlagSet()
	{
		return default(bool);
	}

	private bool EvMacro_ARRIVE_FLAG_SET()
	{
		return default(bool);
	}

	private bool EvCmdFlagReset()
	{
		return default(bool);
	}

	private bool EvCmdFlagCheck()
	{
		return default(bool);
	}

	private bool EvMacro_IF_FLAGON_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_IF_FLAGOFF_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_IF_FLAGON_CALL()
	{
		return default(bool);
	}

	private bool EvMacro_IF_FLAGOFF_CALL()
	{
		return default(bool);
	}

	private int GetIF_FLAG(EvData.Aregment arg)
	{
		return default(int);
	}

	private bool EvCmdFlagCheckWk()
	{
		return default(bool);
	}

	private bool EvCmdFlagSetWk()
	{
		return default(bool);
	}

	private bool EvCmdTrainerFlagSet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerFlagReset()
	{
		return default(bool);
	}

	private bool EvCmdTrainerFlagCheck()
	{
		return default(bool);
	}

	private bool EvMacro_IF_TR_FLAGON_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_IF_TR_FLAGOFF_JUMP()
	{
		return default(bool);
	}

	private bool EvMacro_IF_TR_FLAGON_CALL()
	{
		return default(bool);
	}

	private bool EvMacro_IF_TR_FLAGOFF_CALL()
	{
		return default(bool);
	}

	private bool EvCmdWkAdd()
	{
		return default(bool);
	}

	private bool EvCmdWkSub()
	{
		return default(bool);
	}

	private bool EvCmdLoadWkValue()
	{
		return default(bool);
	}

	private bool EvCmdLoadWkWk()
	{
		return default(bool);
	}

	private bool EvCmdLoadWkWkValue()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgAllPut()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgAllPutOtherArc()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgOtherArc()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgAllPutPMS()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgPMS()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgTowerApper()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgNgPokeName()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsg()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgSp()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgSpAuto()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgNoSkip()
	{
		return default(bool);
	}

	private bool EvCmdTalkConSioMsg()
	{
		return default(bool);
	}

	private bool EvCmdMsgAutoGet()
	{
		return default(bool);
	}

	private bool EvCmdABKeyWait()
	{
		return default(bool);
	}

	private bool EvCmdABKeyTimeWait()
	{
		return default(bool);
	}

	private bool EvCmdLastKeyWait()
	{
		return default(bool);
	}

	private bool EvCmdNextAnmLastKeyWait()
	{
		return default(bool);
	}

	private bool EvCmdTalkWinOpen()
	{
		return default(bool);
	}

	private bool EvCmdTalkWinClose()
	{
		return default(bool);
	}

	private bool EvCmdTalkWinCloseNoClear()
	{
		return default(bool);
	}

	private bool EvMacro_TALK_KEYWAIT()
	{
		return default(bool);
	}

	private bool EvMacro_EASY_OBJ_MSG()
	{
		return default(bool);
	}

	private bool EvMacro_EASY_MSG()
	{
		return default(bool);
	}

	private bool EvCmdBoardMake()
	{
		return default(bool);
	}

	private bool EvCmdInfoBoardMake()
	{
		return default(bool);
	}

	private bool EvCmdBoardReq()
	{
		return default(bool);
	}

	private bool EvCmdBoardWait()
	{
		return default(bool);
	}

	private bool EvCmdBoardMsg()
	{
		return default(bool);
	}

	private bool EvCmdBoardEndWait()
	{
		return default(bool);
	}

	private bool EvMacro_EASY_BOARD_MSG()
	{
		return default(bool);
	}

	private bool EvMacro_EASY_INFOBOARD_MSG()
	{
		return default(bool);
	}

	private bool EvCmdMenuReq()
	{
		return default(bool);
	}

	private bool EvCmdBgScroll()
	{
		return default(bool);
	}

	private bool EvCmdYesNoWin()
	{
		return default(bool);
	}

	private bool EvCmdGuinnessWin()
	{
		return default(bool);
	}

	private bool EvCmdBmpMenuInit()
	{
		return default(bool);
	}

	private bool EvCmdBmpMenuInitEx()
	{
		return default(bool);
	}

	private bool EvCmdBmpMenuMakeList()
	{
		return default(bool);
	}

	private bool EvCmdBmpMenuMakeList16()
	{
		return default(bool);
	}

	private bool EvCmdBmpMenuStart()
	{
		return default(bool);
	}

	private bool EvCmdBmpListInit()
	{
		return default(bool);
	}

	private bool EvCmdBmpListInitEx()
	{
		return default(bool);
	}

	private bool EvCmdBmpListMakeList()
	{
		return default(bool);
	}

	private bool EvCmdBmpListStart()
	{
		return default(bool);
	}

	private bool EvCmdBmpMenuHVStart()
	{
		return default(bool);
	}

	private bool EvCmdSePlay()
	{
		return default(bool);
	}

	private bool EvCmdSeStop()
	{
		return default(bool);
	}

	private bool EvCmdSeWait()
	{
		return default(bool);
	}

	private bool EvCmdVoicePlay()
	{
		return default(bool);
	}

	private bool EvCmdVoicePlayWait()
	{
		return default(bool);
	}

	private bool EvMacro_EASY_VOICE_MSG()
	{
		return default(bool);
	}

	private bool EvCmdMePlay()
	{
		return default(bool);
	}

	private bool EvCmdMeWait()
	{
		return default(bool);
	}

	private bool EvCmdSndInitialVolSet()
	{
		return default(bool);
	}

	private bool EvCmdBgmPlay()
	{
		return default(bool);
	}

	private bool EvCmdBgmPlayCheck()
	{
		return default(bool);
	}

	private bool EvCmdBgmStop()
	{
		return default(bool);
	}

	private bool EvCmdBgmNowMapPlay()
	{
		return default(bool);
	}

	private bool EvCmdBgmSpecialSet()
	{
		return default(bool);
	}

	private bool EvMacro_BGM_SPECIAL_CLR()
	{
		return default(bool);
	}

	private bool EvCmdBgmFadeOut()
	{
		return default(bool);
	}

	private bool EvMacro_BGM_FADEOUT_PLAY()
	{
		return default(bool);
	}

	private bool EvCmdBgmFadeIn()
	{
		return default(bool);
	}

	private bool EvCmdBgmPlayerPause()
	{
		return default(bool);
	}

	private bool EvCmdPlayerFieldDemoBgmPlay()
	{
		return default(bool);
	}

	private bool EvCmdCtrlBgmFlagSet()
	{
		return default(bool);
	}

	private bool EvCmdCtrlBgmFlagReSet()
	{
		return default(bool);
	}

	private bool EvCmdPerapDataCheck()
	{
		return default(bool);
	}

	private bool EvCmdPerapRecStart()
	{
		return default(bool);
	}

	private bool EvCmdPerapRecStop()
	{
		return default(bool);
	}

	private bool EvCmdPerapSave()
	{
		return default(bool);
	}

	private bool EvCmdSndClimaxDataLoad()
	{
		return default(bool);
	}

	private bool EvCmdObjAnime()
	{
		return default(bool);
	}

	private bool EvCmdObjAnimePos()
	{
		return default(bool);
	}

	private bool EvMacro_ANIME_LABEL()
	{
		return default(bool);
	}

	private bool EvMacro_ANIME_DATA()
	{
		return default(bool);
	}

	private bool EvCmdObjAnimeWait()
	{
		return default(bool);
	}

	private bool EvCmdTalkObjPauseAll()
	{
		return default(bool);
	}

	private bool EvCmdObjPauseAll()
	{
		return default(bool);
	}

	private bool EvCmdObjPauseClearAll()
	{
		return default(bool);
	}

	private bool EvCmdObjPause()
	{
		return default(bool);
	}

	private bool EvCmdObjPauseClear()
	{
		return default(bool);
	}

	private bool EvCmdObjAdd()
	{
		return default(bool);
	}

	private bool EvCmdObjDel()
	{
		return default(bool);
	}

	private bool EvCmdVanishDummyObjAdd()
	{
		return default(bool);
	}

	private bool EvCmdVanishDummyObjDel()
	{
		return default(bool);
	}

	private bool EvCmdObjTurn()
	{
		return default(bool);
	}

	private bool EvMacro_TALK_OBJ_START()
	{
		return default(bool);
	}

	private bool EvMacro_TALK_OBJ_START_TURN_NOT()
	{
		return default(bool);
	}

	private bool EvMacro_TALK_OBJ_END()
	{
		return default(bool);
	}

	private bool EvMacro_TALK_START()
	{
		return default(bool);
	}

	private bool EvMacro_EVENT_START()
	{
		return default(bool);
	}

	private bool EvMacro_TALK_END()
	{
		return default(bool);
	}

	private bool EvMacro_EVENT_END()
	{
		return default(bool);
	}

	private bool EvCmdPlayerPosGet()
	{
		return default(bool);
	}

	private bool EvCmdObjPosGet()
	{
		return default(bool);
	}

	private bool EvCmdPlayerPosOffsetSet()
	{
		return default(bool);
	}

	private bool EvCmdPlayerDirGet()
	{
		return default(bool);
	}

	private bool EvCmdNotZoneDelSet()
	{
		return default(bool);
	}

	private bool EvCmdMoveCodeChange()
	{
		return default(bool);
	}

	private bool EvCmdMoveCodeGet()
	{
		return default(bool);
	}

	private bool EvCmdPairObjIdSet()
	{
		return default(bool);
	}

	private bool EvMacro_EVENT_DATA()
	{
		return default(bool);
	}

	private bool EvMacro_EVENT_DATA_END()
	{
		return default(bool);
	}

	private bool EvMacro_SP_EVENT_DATA_END()
	{
		return default(bool);
	}

	private bool EvMacro_SCENE_CHANGE_LABEL()
	{
		return default(bool);
	}

	private bool EvMacro_SCENE_CHANGE_DATA()
	{
		return default(bool);
	}

	private bool EvMacro_SCENE_CHANGE_END()
	{
		return default(bool);
	}

	private bool EvMacro_FLAG_CHANGE_LABEL()
	{
		return default(bool);
	}

	private bool EvMacro_OBJ_CHANGE_LABEL()
	{
		return default(bool);
	}

	private bool EvMacro_INIT_CHANGE_LABEL()
	{
		return default(bool);
	}

	private bool EvCmdAddGold()
	{
		return default(bool);
	}

	private bool EvCmdSubGold()
	{
		return default(bool);
	}

	private bool EvCmdCompGold()
	{
		return default(bool);
	}

	private bool EvCmd_GET_GOLD()
	{
		return default(bool);
	}

	private bool EvCmdGoldWinWrite()
	{
		return default(bool);
	}

	private bool EvCmdGoldWinDel()
	{
		return default(bool);
	}

	private bool EvCmdGoldWrite()
	{
		return default(bool);
	}

	private bool EvCmdCoinWinWrite()
	{
		return default(bool);
	}

	private bool EvCmdCoinWinDel()
	{
		return default(bool);
	}

	private bool EvCmdCoinWrite()
	{
		return default(bool);
	}

	private bool EvCmdCheckCoin()
	{
		return default(bool);
	}

	private bool EvCmdAddCoin()
	{
		return default(bool);
	}

	private bool EvCmdSubCoin()
	{
		return default(bool);
	}

	private bool EvMacro_FLD_ITEM_EVENT()
	{
		return default(bool);
	}

	private bool EvMacro_HIDE_ITEM_EVENT()
	{
		return default(bool);
	}

	private bool EvCmdAddItem()
	{
		return default(bool);
	}

	private bool EvCmdSubItem()
	{
		return default(bool);
	}

	private bool EvCmdAddItemChk()
	{
		return default(bool);
	}

	private bool EvCmdCheckItem()
	{
		return default(bool);
	}

	private bool EvCmd_GET_ITEM_COUNT()
	{
		return default(bool);
	}

	private bool EvCmd_PLAY_EMO_SE()
	{
		return default(bool);
	}

	private bool EvCmdWazaMachineItemNoCheck()
	{
		return default(bool);
	}

	private bool EvCmdGetPocketNo()
	{
		return default(bool);
	}

	private bool EvCmdPocketCheck()
	{
		return default(bool);
	}

	private bool EvCmdPofinCheck()
	{
		return default(bool);
	}

	private bool EvCmdAddPCBoxItem()
	{
		return default(bool);
	}

	private bool EvCmdCheckPCBoxItem()
	{
		return default(bool);
	}

	private bool EvCmdAddGoods()
	{
		return default(bool);
	}

	private bool EvCmdSubGoods()
	{
		return default(bool);
	}

	private bool EvCmdAddGoodsChk()
	{
		return default(bool);
	}

	private bool EvCmdCheckGoods()
	{
		return default(bool);
	}

	private bool EvCmdAddTrap()
	{
		return default(bool);
	}

	private bool EvCmdSubTrap()
	{
		return default(bool);
	}

	private bool EvCmdAddTrapChk()
	{
		return default(bool);
	}

	private bool EvCmdCheckTrap()
	{
		return default(bool);
	}

	private bool EvCmdAddTreasure()
	{
		return default(bool);
	}

	private bool EvCmdSubTreasure()
	{
		return default(bool);
	}

	private bool EvCmdAddTreasureChk()
	{
		return default(bool);
	}

	private bool EvCmdCheckTreasure()
	{
		return default(bool);
	}

	private bool EvCmdAddTama()
	{
		return default(bool);
	}

	private bool EvCmdSubTama()
	{
		return default(bool);
	}

	private bool EvCmdAddTamaChk()
	{
		return default(bool);
	}

	private bool EvCmdCheckTama()
	{
		return default(bool);
	}

	private bool EvCmdCBSealKindNumGet()
	{
		return default(bool);
	}

	private bool EvCmdCBItemNumGet()
	{
		return default(bool);
	}

	private bool EvCmdCBItemNumAdd()
	{
		return default(bool);
	}

	private bool EvCmdUnknownFormGet()
	{
		return default(bool);
	}

	private bool EvCmdAddPokemon()
	{
		return default(bool);
	}

	private bool EvCmdAddPokemonUI()
	{
		return default(bool);
	}

	private bool EvCmdAddUniquePokemonUI()
	{
		return default(bool);
	}

	private bool EvCmdAddTamago()
	{
		return default(bool);
	}

	private bool EvCmdChgPokeWaza()
	{
		return default(bool);
	}

	private bool EvCmdChkPokeWaza()
	{
		return default(bool);
	}

	private bool EvCmdChkPokeWazaGroup()
	{
		return default(bool);
	}

	private bool EvCmdAddWaza()
	{
		return default(bool);
	}

	private bool EvCmdApprovePoisonDead()
	{
		return default(bool);
	}

	private bool EvCmdRevengeTrainerSearch()
	{
		return default(bool);
	}

	private bool EvCmdSetWeather()
	{
		return default(bool);
	}

	private bool EvCmdInitWeather()
	{
		return default(bool);
	}

	private bool EvCmdUpdateWeather()
	{
		return default(bool);
	}

	private bool EvCmdGetMapPosition()
	{
		return default(bool);
	}

	private bool EvCmdGetTemotiPokeNum()
	{
		return default(bool);
	}

	private bool EvCmdSetMapProc()
	{
		return default(bool);
	}

	private bool EvCmdFinishMapProc()
	{
		return default(bool);
	}

	private bool EvCmdWiFiAutoReg()
	{
		return default(bool);
	}

	private bool EvCmdWiFiP2PMatchEventCall()
	{
		return default(bool);
	}

	private bool EvCmdWiFiP2PMatchSetDel()
	{
		return default(bool);
	}

	private bool EvCmdCommGetCurrentID()
	{
		return default(bool);
	}

	private bool EvCmdDendouNumGet()
	{
		return default(bool);
	}

	private bool EvCmdPokeWindowPut()
	{
		return default(bool);
	}

	private bool EvCmdPokeWindowPutPP()
	{
		return default(bool);
	}

	private bool EvCmdPokeWindowDel()
	{
		return default(bool);
	}

	private bool EvCmdPokeWindowAnm()
	{
		return default(bool);
	}

	private bool EvCmdPokeWindowAnmWait()
	{
		return default(bool);
	}

	private bool EvCmdBtlSearcherEventCall()
	{
		return default(bool);
	}

	private bool EvCmdBtlSearcherDirMvSet()
	{
		return default(bool);
	}

	private bool EvCmdMsgBoyEvent()
	{
		return default(bool);
	}

	private bool EvCmdImageClipSetProc()
	{
		return default(bool);
	}

	private bool EvCmdImageClipPreviewTvProc()
	{
		return default(bool);
	}

	private bool EvCmdImageClipPreviewConProc()
	{
		return default(bool);
	}

	private bool EvCmdCustomBallEventCall()
	{
		return default(bool);
	}

	private bool EvCmdTMapBGSetProc()
	{
		return default(bool);
	}

	private bool EvCmdBoxSetProc()
	{
		return default(bool);
	}

	private bool EvCmd_BOX_SEAL_UI_WAIT()
	{
		return default(bool);
	}

	private bool EvCmdOekakiBoardSetProc()
	{
		return default(bool);
	}

	private bool EvCmdCallTrCard()
	{
		return default(bool);
	}

	private bool EvCmdTradeListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdRecordCornerSetProc()
	{
		return default(bool);
	}

	private bool EvCmdDendouSetProc()
	{
		return default(bool);
	}

	private bool EvCmdPcDendouSetProc()
	{
		return default(bool);
	}

	private bool EvCmdPcDendouSetProcOpenWait()
	{
		return default(bool);
	}

	private bool EvCmdWorldTradeSetProc()
	{
		return default(bool);
	}

	private bool EvCmdDPWInitProc()
	{
		return default(bool);
	}

	private bool EvCmdFirstPokeSelectProc()
	{
		return default(bool);
	}

	private bool EvCmdFirstPokeSelectSetAndDel()
	{
		return default(bool);
	}

	private bool EvCmdBagSetProcNormal()
	{
		return default(bool);
	}

	private bool EvCmdBagSetProcKinomi()
	{
		return default(bool);
	}

	private bool EvCmdBagGetResult()
	{
		return default(bool);
	}

	private bool EvCmdPokeListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdNpcTradePokeListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdUnionPokeListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdPokeListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdConPokeListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdConPokeListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdConPokeStatusSetProc()
	{
		return default(bool);
	}

	private bool EvCmdPokeStatusGetResult()
	{
		return default(bool);
	}

	private bool EvCmdWifiEarthSetProc()
	{
		return default(bool);
	}

	private bool EvCmdEyeTrainerMoveSet()
	{
		return default(bool);
	}

	private bool EvCmdEyeTrainerMoveCheck()
	{
		return default(bool);
	}

	private bool EvCmdEyeTrainerTypeGet()
	{
		return default(bool);
	}

	private bool EvCmdEyeTrainerIdGet()
	{
		return default(bool);
	}

	private bool EvCmdNameIn()
	{
		return default(bool);
	}

	private bool EvCmdNameInPoke()
	{
		return default(bool);
	}

	private bool EvCmdWipeFadeStart()
	{
		return default(bool);
	}

	private bool EvCmdWipeFadeCheck()
	{
		return default(bool);
	}

	private bool EvMacro_WHITE_OUT()
	{
		return default(bool);
	}

	private bool EvMacro_WHITE_IN()
	{
		return default(bool);
	}

	private bool EvMacro_BLACK_OUT()
	{
		return default(bool);
	}

	private bool EvMacro_BLACK_IN()
	{
		return default(bool);
	}

	private bool EvMacro_MAP_CHANGE()
	{
		return default(bool);
	}

	private bool EvCmdMapChange()
	{
		return default(bool);
	}

	private bool EvCmdColosseumMapChangeIn()
	{
		return default(bool);
	}

	private bool EvCmdColosseumMapChangeOut()
	{
		return default(bool);
	}

	private bool EvCmdGetBeforeZoneID()
	{
		return default(bool);
	}

	private bool EvCmdGetNowZoneID()
	{
		return default(bool);
	}

	private bool EvCmdKabeNobori()
	{
		return default(bool);
	}

	private bool EvCmdNaminori()
	{
		return default(bool);
	}

	private bool EvCmdBicycleCheck()
	{
		return default(bool);
	}

	private bool EvCmdBicycleReq()
	{
		return default(bool);
	}

	private bool EvCmdBicycleReqNonBgm()
	{
		return default(bool);
	}

	private bool EvCmdCyclingRoadSet()
	{
		return default(bool);
	}

	private bool EvCmdPlayerFormGet()
	{
		return default(bool);
	}

	private bool EvCmdPlayerReqBitOn()
	{
		return default(bool);
	}

	private bool EvCmdPlayerReqStart()
	{
		return default(bool);
	}

	private bool EvCmdTakinobori()
	{
		return default(bool);
	}

	private bool EvCmdSorawotobu()
	{
		return default(bool);
	}

	private bool EvCmdSorawotobuEnd()
	{
		return default(bool);
	}

	private bool EvCmdHidenFlash()
	{
		return default(bool);
	}

	private bool EvCmd_DARKNESS_TEMPORARILY_OFF()
	{
		return default(bool);
	}

	private bool EvCmd_DARKNESS_TEMPORARILY_ON()
	{
		return default(bool);
	}

	private bool EvCmdHidenKiribarai()
	{
		return default(bool);
	}

	private bool EvCmdCutIn()
	{
		return default(bool);
	}

	private MonsNo GetHidenWazaMonsNo(WazaNo wazaNo)
	{
		return default(MonsNo);
	}

	private bool CheckHidenWazaForceResetForm(WazaNo wazaNo)
	{
		return default(bool);
	}

	private bool EvCmdConHeroChange()
	{
		return default(bool);
	}

	private bool EvCmdPlayerName()
	{
		return default(bool);
	}

	private bool EvCmdRivalName()
	{
		return default(bool);
	}

	private bool EvCmdSupportName()
	{
		return default(bool);
	}

	private bool EvCmdPokemonName()
	{
		return default(bool);
	}

	private bool EvCmdItemName()
	{
		return default(bool);
	}

	private bool EvCmdPocketName()
	{
		return default(bool);
	}

	private bool EvCmdItemWazaName()
	{
		return default(bool);
	}

	private bool EvCmdWazaName()
	{
		return default(bool);
	}

	private bool EvCmdNumberName()
	{
		return default(bool);
	}

	private bool EvCmdNumberNameEx()
	{
		return default(bool);
	}

	private bool EvCmdSpeakersName()
	{
		return default(bool);
	}

	private bool EvCmdContestCategoryName()
	{
		return default(bool);
	}

	private bool EvCmdContestRankName()
	{
		return default(bool);
	}

	private bool EvCmdPokeTypeName()
	{
		return default(bool);
	}

	private bool EvCmdPofifinName()
	{
		return default(bool);
	}

	private bool EvCmdDressName()
	{
		return default(bool);
	}

	private bool EvCmdBirthDayCheck()
	{
		return default(bool);
	}

	private bool EvCmdBirthMonthInput()
	{
		return default(bool);
	}

	private bool EvCmdBirthDayInput()
	{
		return default(bool);
	}

	private int DayNumInMonth(int month)
	{
		return default(int);
	}

	private bool EvCmdAnoonSeeNum()
	{
		return default(bool);
	}

	private bool EvCmdNickName()
	{
		return default(bool);
	}

	private bool EvCmdPoketchName()
	{
		return default(bool);
	}

	private bool EvCmdTrTypeName()
	{
		return default(bool);
	}

	private bool EvCmdPartnerNameSet()
	{
		return default(bool);
	}

	private bool EvCmdMyTrTypeName()
	{
		return default(bool);
	}

	private bool EvCmdPokemonNameExtra()
	{
		return default(bool);
	}

	private bool EvCmdFirstPokemonName()
	{
		return default(bool);
	}

	private bool EvCmdRivalPokemonName()
	{
		return default(bool);
	}

	private bool EvCmdSupportPokemonName()
	{
		return default(bool);
	}

	private bool EvCmdFirstPokeNoGet()
	{
		return default(bool);
	}

	private bool EvCmdNutsName()
	{
		return default(bool);
	}

	private bool EvCmdSeikakuName()
	{
		return default(bool);
	}

	private bool EvCmdGoodsName()
	{
		return default(bool);
	}

	private bool EvCmdTrapName()
	{
		return default(bool);
	}

	private bool EvCmdTamaName()
	{
		return default(bool);
	}

	private bool EvCmdZoneName()
	{
		return default(bool);
	}

	private bool EvCmdZoneName2()
	{
		return default(bool);
	}

	private bool EvCmdZoneNameLabel()
	{
		return default(bool);
	}

	private bool EvCmdGenerateInfoGet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerIdGet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerMultiBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerMessageSet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerTalkTypeGet()
	{
		return default(bool);
	}

	private bool EvCmdRevengeTrainerTalkTypeGet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerTypeGet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerBgmSet()
	{
		return default(bool);
	}

	private bool EvCmdTrainerLose()
	{
		return default(bool);
	}

	private bool EvCmdTrainerLoseCheck()
	{
		return default(bool);
	}

	private bool EvCmdNormalLose()
	{
		return default(bool);
	}

	private bool EvCmdNormalLoseCheck()
	{
		return default(bool);
	}

	private bool EvCmdSeacretPokeRetryCheck()
	{
		return default(bool);
	}

	private bool EvCmdHaifuPokeRetryCheck()
	{
		return default(bool);
	}

	private bool EvCmd2vs2BattleCheck()
	{
		return default(bool);
	}

	private bool EvCmdDebugBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdDebugTrainerFlagSet()
	{
		return default(bool);
	}

	private bool EvCmdDebugTrainerFlagOnJump()
	{
		return default(bool);
	}

	private bool EvMacro_DEBUG_TR_TALK_BTL()
	{
		return default(bool);
	}

	private bool EvCmdConnectSelParentWin()
	{
		return default(bool);
	}

	private bool EvCmdConnectSelChildWin()
	{
		return default(bool);
	}

	private bool EvCmdConnectDebugParentWin()
	{
		return default(bool);
	}

	private bool EvCmdConnectDebugChildWin()
	{
		return default(bool);
	}

	private bool EvCmdDebugSioEncount()
	{
		return default(bool);
	}

	private bool EvCmdDebugSioContest()
	{
		return default(bool);
	}

	private bool EvCmdConSioTimingSend()
	{
		return default(bool);
	}

	private bool EvCmdConSioTimingCheck()
	{
		return default(bool);
	}

	private bool EvCmdConSystemCreate()
	{
		return default(bool);
	}

	private bool EvCmdConSystemExit()
	{
		return default(bool);
	}

	private bool EvCmdConJudgeNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConBreederNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConNickNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConNumTagSet()
	{
		return default(bool);
	}

	private bool EvCmdConSioParamInitSet()
	{
		return default(bool);
	}

	private bool EvCmdContestProc()
	{
		return default(bool);
	}

	private bool EvCmdConRankNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConTypeNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConVictoryBreederNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConVictoryItemNoGet()
	{
		return default(bool);
	}

	private bool EvCmdConVictoryNickNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConRankingCheck()
	{
		return default(bool);
	}

	private bool EvCmdConVictoryEntryNoGet()
	{
		return default(bool);
	}

	private bool EvCmdConMyEntryNoGet()
	{
		return default(bool);
	}

	private bool EvCmdConObjCodeGet()
	{
		return default(bool);
	}

	private bool EvCmdConPopularityGet()
	{
		return default(bool);
	}

	private bool EvCmdConDeskModeGet()
	{
		return default(bool);
	}

	private bool EvCmdConHaveRibbonCheck()
	{
		return default(bool);
	}

	private bool EvCmdConRibbonNameGet()
	{
		return default(bool);
	}

	private bool EvCmdConAcceNoGet()
	{
		return default(bool);
	}

	private bool EvCmdConEntryParamGet()
	{
		return default(bool);
	}

	private bool EvCmdConCameraFlashSet()
	{
		return default(bool);
	}

	private bool EvCmdConCameraFlashCheck()
	{
		return default(bool);
	}

	private bool EvCmdConHBlankStop()
	{
		return default(bool);
	}

	private bool EvCmdConHBlankStart()
	{
		return default(bool);
	}

	private bool EvCmdConEndingSkipCheck()
	{
		return default(bool);
	}

	private bool EvCmdConRecordDisp()
	{
		return default(bool);
	}

	private bool EvCmdConMsgPrintFlagSet()
	{
		return default(bool);
	}

	private bool EvCmdConMsgPrintFlagReset()
	{
		return default(bool);
	}

	private bool EvCmdSpLocationSet()
	{
		return default(bool);
	}

	private bool EvCmdElevatorNowFloorGet()
	{
		return default(bool);
	}

	private bool EvCmdElevatorFloorWrite()
	{
		return default(bool);
	}

	private bool EvCmdGetShinouZukanSeeNum()
	{
		return default(bool);
	}

	private bool EvCmdGetShinouZukanGetNum()
	{
		return default(bool);
	}

	private bool EvCmdGetZenkokuZukanSeeNum()
	{
		return default(bool);
	}

	private bool EvCmdGetZenkokuZukanGetNum()
	{
		return default(bool);
	}

	private bool EvCmdChkZenkokuZukan()
	{
		return default(bool);
	}

	private bool EvCmdGetZukanHyoukaMsgID()
	{
		return default(bool);
	}

	private bool EvCmdWildBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdSpWildBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdFirstBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdCaptureBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdHoneyTree()
	{
		return default(bool);
	}

	private bool EvCmdGetHoneyTreeState()
	{
		return default(bool);
	}

	private bool EvCmdHoneyTreeBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdHoneyAfterTreeBattleSet()
	{
		return default(bool);
	}

	private bool EvCmdTSignSetProc()
	{
		return default(bool);
	}

	private bool EvCmdReportSaveCheck()
	{
		return default(bool);
	}

	private bool EvCmdReportSave()
	{
		return default(bool);
	}

	private IEnumerator evReportSaveCoroutine()
	{
		return null;
	}

	private bool EvCmdReportInfoWinOpen()
	{
		return default(bool);
	}

	private bool EvCmdReportInfoWinClose()
	{
		return default(bool);
	}

	private bool EvCmdImageClipTvSaveDataCheck()
	{
		return default(bool);
	}

	private bool EvCmdImageClipConSaveDataCheck()
	{
		return default(bool);
	}

	private bool EvCmdImageClipTvSaveTitle()
	{
		return default(bool);
	}

	private bool EvCmdGetPoketch()
	{
		return default(bool);
	}

	private bool EvCmdGetPoketchFlag()
	{
		return default(bool);
	}

	private bool EvCmdPoketchAppAdd()
	{
		return default(bool);
	}

	private bool EvCmdPoketchAppCheck()
	{
		return default(bool);
	}

	private bool EvCmdCommTimingSyncStart()
	{
		return default(bool);
	}

	private bool EvCmdCommTempDataReset()
	{
		return default(bool);
	}

	private bool EvCmdUnionProc()
	{
		return default(bool);
	}

	private bool EvCmdUnionParentCardTalkNo()
	{
		return default(bool);
	}

	private bool EvCmdUnionGetInfoTalkNo()
	{
		return default(bool);
	}

	private bool EvCmdUnionBeaconChange()
	{
		return default(bool);
	}

	private bool EvCmdUnionConnectTalkDenied()
	{
		return default(bool);
	}

	private bool EvCmdUnionConnectTalkOk()
	{
		return default(bool);
	}

	private bool EvCmdUnionTrainerNameRegist()
	{
		return default(bool);
	}

	private bool EvCmdUnionReturnSetUp()
	{
		return default(bool);
	}

	private bool EvCmdUnionConnectCutRestart()
	{
		return default(bool);
	}

	private bool EvCmdUnionGetTalkNumber()
	{
		return default(bool);
	}

	private bool EvCmdUnionIdSet()
	{
		return default(bool);
	}

	private bool EvCmdUnionResultGet()
	{
		return default(bool);
	}

	private bool EvCmdUnionObjAllVanish()
	{
		return default(bool);
	}

	private bool EvCmdUnionScriptResultSet()
	{
		return default(bool);
	}

	private bool EvCmdUnionParentStartCommandSet()
	{
		return default(bool);
	}

	private bool EvCmdUnionChildSelectCommandSet()
	{
		return default(bool);
	}

	private bool EvCmdUnionConnectStart()
	{
		return default(bool);
	}

	private bool EvCmdUnionMapChange()
	{
		return default(bool);
	}

	private bool EvCmdUnionViewSetUpTrainerTypeSelect()
	{
		return default(bool);
	}

	private bool EvCmdUnionViewGetTrainerType()
	{
		return default(bool);
	}

	private bool EvCmdUnionViewGetTrainerTypeNo()
	{
		return default(bool);
	}

	private bool EvCmdUnionViewMyStatusSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagZukanGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagZukanSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagShoesGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagShoesSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagBadgeGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagBadgeSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagBadgeCount()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagBagGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagBagSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagPairGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagPairSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagPairReset()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagOneStepGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagOneStepSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagOneStepReset()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagGameClearGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagGameClearSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagKairikiSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagKairikiReset()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagKairikiGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagFlashSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagFlashReset()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagFlashGet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagKiribaraiSet()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagKiribaraiReset()
	{
		return default(bool);
	}

	private bool EvCmdSysFlagKiribaraiGet()
	{
		return default(bool);
	}

	private bool EvCmdShopCall()
	{
		return default(bool);
	}

	private bool EvCmdFixShopCall()
	{
		return default(bool);
	}

	private bool EvCmdFixGoodsCall()
	{
		return default(bool);
	}

	private bool EvCmdFixSealCall()
	{
		return default(bool);
	}

	private bool EvCmdAcceShopCall()
	{
		return default(bool);
	}

	private bool EvCmdReportDrawProcSet()
	{
		return default(bool);
	}

	private bool EvCmdReportDrawProcDel()
	{
		return default(bool);
	}

	private bool EvCmdGameOverCall()
	{
		return default(bool);
	}

	private bool EvCmdSetWarpId()
	{
		return default(bool);
	}

	private bool EvCmd_SET_TELEPORT_ID()
	{
		return default(bool);
	}

	private bool EvCmdGetMySex()
	{
		return default(bool);
	}

	private bool EvCmdPcKaifuku()
	{
		return default(bool);
	}

	private bool EvCmdUgManShopNpcRandomPlace()
	{
		return default(bool);
	}

	private bool EvCmdCommDirectEnd()
	{
		return default(bool);
	}

	private bool EvCmdCommDirectEndTiming()
	{
		return default(bool);
	}

	private bool EvCmdCommDirectEnterBtlRoom()
	{
		return default(bool);
	}

	private bool EvCmdCommPlayerSetDir()
	{
		return default(bool);
	}

	private bool EvCmdSetUpDoorAnime()
	{
		return default(bool);
	}

	private bool EvCmdWait3DAnime()
	{
		return default(bool);
	}

	private bool EvCmdFree3DAnime()
	{
		return default(bool);
	}

	private bool EvCmdOpenDoor()
	{
		return default(bool);
	}

	private bool EvCmdCloseDoor()
	{
		return default(bool);
	}

	private bool EvCmdPMSInputSingleProc()
	{
		return default(bool);
	}

	private bool EvCmdPMSInputDoubleProc()
	{
		return default(bool);
	}

	private bool EvCmdPMSBuf()
	{
		return default(bool);
	}

	private FieldKinomiGrowEntity GetCurrentKinomiGrowEntity()
	{
		return null;
	}

	private int GetCurrentKinomiGrowId()
	{
		return default(int);
	}

	private bool EvCmdSeedGetStatus()
	{
		return default(bool);
	}

	private bool EvCmdSeedGetType()
	{
		return default(bool);
	}

	private bool EvCmdSeedGetCompost()
	{
		return default(bool);
	}

	private bool EvCmdSeedGetGroundStatus()
	{
		return default(bool);
	}

	private bool EvCmdSeedGetNutsCount()
	{
		return default(bool);
	}

	private bool EvCmdSeedSetCompost()
	{
		return default(bool);
	}

	private bool EvCmdSeedSetNuts()
	{
		return default(bool);
	}

	private bool EvCmdSeedSetWater()
	{
		return default(bool);
	}

	private bool EvCmdSeedTakeNuts()
	{
		return default(bool);
	}

	private bool EvCmdSxyPosChange()
	{
		return default(bool);
	}

	private bool EvCmdObjPosChange()
	{
		return default(bool);
	}

	private bool EvCmd_OBJ_POS_CHANGE_WORLD()
	{
		return default(bool);
	}

	private bool EvCmd_OBJ_DIR_CHANGE_WORLD()
	{
		return default(bool);
	}

	private bool EvCmd_OBJ_POS_CHANGE_WORLD_FIND()
	{
		return default(bool);
	}

	private bool EvCmdSxyMoveCodeChange()
	{
		return default(bool);
	}

	private bool EvCmdSxyDirChange()
	{
		return default(bool);
	}

	private bool EvCmdSxyExitPosChange()
	{
		return default(bool);
	}

	private bool EvCmdSxyBgPosChange()
	{
		return default(bool);
	}

	private bool EvCmdObjDirChange()
	{
		return default(bool);
	}

	private bool EvCmdReturnScriptWkSet()
	{
		return default(bool);
	}

	private bool EvCmdMsgExpandBuf()
	{
		return default(bool);
	}

	private bool EvCmdGetSodateyaName()
	{
		return default(bool);
	}

	private bool EvCmdGetSodateyaZiisan()
	{
		return default(bool);
	}

	private bool EvCmdInitWaterGym()
	{
		return default(bool);
	}

	private bool EvCmdPushWaterGymButton()
	{
		return default(bool);
	}

	private bool EvCmdInitGhostGym()
	{
		return default(bool);
	}

	private bool EvCmdMoveGhostGymLift()
	{
		return default(bool);
	}

	private bool EvCmdInitSteelGym()
	{
		return default(bool);
	}

	private bool EvCmdInitCombatGym()
	{
		return default(bool);
	}

	private bool EvCmdInitElecGym()
	{
		return default(bool);
	}

	private bool EvCmdRotElecGymGear()
	{
		return default(bool);
	}

	private bool EvCmdGetPokeCount()
	{
		return default(bool);
	}

	private bool EvCmdGetPokeCount2()
	{
		return default(bool);
	}

	private bool EvCmdGetPokeCount3()
	{
		return default(bool);
	}

	private bool EvCmdGetPokeCount4()
	{
		return default(bool);
	}

	private bool EvCmdGetPokeCount5()
	{
		return default(bool);
	}

	private bool EvCmdGetTamagoCount()
	{
		return default(bool);
	}

	private bool EvCmdUgShopMenuInit()
	{
		return default(bool);
	}

	private DayOfWeek GetShopUgWeek()
	{
		return default(DayOfWeek);
	}

	private bool EvCmdUgLevaeHyouta()
	{
		return default(bool);
	}

	private bool EvCmdAGAnimationHyouta()
	{
		return default(bool);
	}

	private bool EvCmdUgShopTalkStart()
	{
		return default(bool);
	}

	private bool EvCmdUgShopTalkEnd()
	{
		return default(bool);
	}

	private bool EvCmdUgShopTalkRegisterItemName()
	{
		return default(bool);
	}

	private bool EvCmdUgShopTalkRegisterTrapName()
	{
		return default(bool);
	}

	private bool EvCmdDelSodateyaEgg()
	{
		return default(bool);
	}

	private bool EvCmdGetSodateyaEgg()
	{
		return default(bool);
	}

	private bool EvCmdMsgSodateyaAishou()
	{
		return default(bool);
	}

	private bool EvCmdMsgAzukeSet()
	{
		return default(bool);
	}

	private bool EvCmdSetSodateyaPoke()
	{
		return default(bool);
	}

	private bool EvCmdSodateyaPokeList()
	{
		return default(bool);
	}

	private bool EvCmdHikitoriList()
	{
		return default(bool);
	}

	private bool EvCmdSodatePokeLevelStr()
	{
		return default(bool);
	}

	private bool EvCmdHikitoriRyoukin()
	{
		return default(bool);
	}

	private bool EvCmdHikitoriPoke()
	{
		return default(bool);
	}

	private bool EvCmdTamagoDemo()
	{
		return default(bool);
	}

	private bool EvCmdTemotiMonsNo()
	{
		return default(bool);
	}

	private bool EvCmdMonsOwnChk()
	{
		return default(bool);
	}

	private bool EvCmdChkTemotiPokerus()
	{
		return default(bool);
	}

	private bool EvCmdTemotiPokeSexGet()
	{
		return default(bool);
	}

	private bool EvCmdSubMyGold()
	{
		return default(bool);
	}

	private bool EvCmdCompMyGold()
	{
		return default(bool);
	}

	private bool EvCmdObjVisible()
	{
		return default(bool);
	}

	private bool EvCmdObjInvisible()
	{
		return default(bool);
	}

	private bool EvCmdMailBox()
	{
		return default(bool);
	}

	private bool EvCmdGetMailBoxDataNum()
	{
		return default(bool);
	}

	private bool EvCmdRankingView()
	{
		return default(bool);
	}

	private bool EvCmdGetTimeZone()
	{
		return default(bool);
	}

	private bool EvCmdGetRand()
	{
		return default(bool);
	}

	private bool EvCmdGetRandNext()
	{
		return default(bool);
	}

	private bool EvCmdGetNatsuki()
	{
		return default(bool);
	}

	private bool EvCmdAddNatsuki()
	{
		return default(bool);
	}

	private bool EvCmdSubNatsuki()
	{
		return default(bool);
	}

	private bool EvCmdHikitoriListNameSet()
	{
		return default(bool);
	}

	private bool EvCmdGetSodateyaAishou()
	{
		return default(bool);
	}

	private bool EvCmdGetSodateyaTamagoCheck()
	{
		return default(bool);
	}

	private bool EvCmdTemotiPokeChk()
	{
		return default(bool);
	}

	private bool EvCmdOokisaRecordChk()
	{
		return default(bool);
	}

	private int CalcPokemonSizeValue(PokemonParam param)
	{
		return default(int);
	}

	private float CalcPokemonSize(MonsNo monsNo, int sizeValue)
	{
		return default(float);
	}

	private bool EvCmdOokisaRecordSet()
	{
		return default(bool);
	}

	private bool EvCmdOokisaTemotiSet()
	{
		return default(bool);
	}

	private bool EvCmdOokisaKirokuSet()
	{
		return default(bool);
	}

	private bool EvCmdOokisaValueSet()
	{
		return default(bool);
	}

	private void SetOokisaDigit(int idx0, int idx1, float size)
	{
	}

	private bool EvCmdOokisaKurabeInit()
	{
		return default(bool);
	}

	private bool EvCmdWazaListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdWazaListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdWazaCount()
	{
		return default(bool);
	}

	private bool EvCmdWazaDel()
	{
		return default(bool);
	}

	private bool EvCmdTemotiWazaNo()
	{
		return default(bool);
	}

	private bool EvCmdTemotiWazaName()
	{
		return default(bool);
	}

	private bool EvCmdFNoteStartSet()
	{
		return default(bool);
	}

	private bool EvCmdFNoteDataMake()
	{
		return default(bool);
	}

	private bool EvCmdFNoteDataSave()
	{
		return default(bool);
	}

	private bool EvCmdImcAcceAddItem()
	{
		return default(bool);
	}

	private bool EvCmdImcAcceAddItemChk()
	{
		return default(bool);
	}

	private bool EvCmdImcAcceCheckItem()
	{
		return default(bool);
	}

	private bool EvCmdImcBgAddItem()
	{
		return default(bool);
	}

	private bool EvCmdImcBgCheckItem()
	{
		return default(bool);
	}

	private bool EvCmdNutMixerProc()
	{
		return default(bool);
	}

	private bool EvCmdNutMixerPlayStateCheck()
	{
		return default(bool);
	}

	private bool EvCmdZukanChkShinou()
	{
		return default(bool);
	}

	private bool EvCmdZukanChkNational()
	{
		return default(bool);
	}

	private bool EvCmdZukanRecongnizeShinou()
	{
		return default(bool);
	}

	private bool EvCmdZukanRecongnizeNational()
	{
		return default(bool);
	}

	private bool EvCmdRecongnizeTokikake()
	{
		return default(bool);
	}

	private bool EvCmdRecongnizeOpenWait()
	{
		return default(bool);
	}

	private bool EvCmdUrayamaEncountSet()
	{
		return default(bool);
	}

	private bool EvCmdUrayamaEncountNoChk()
	{
		return default(bool);
	}

	private bool EvCmdPokeMailChk()
	{
		return default(bool);
	}

	private bool EvCmdPaperplaneSet()
	{
		return default(bool);
	}

	private bool EvCmdPokeMailDel()
	{
		return default(bool);
	}

	private bool EvCmdKasekiCount()
	{
		return default(bool);
	}

	private bool EvCmdItemListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdItemListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdItemNoToMonsNo()
	{
		return default(bool);
	}

	private bool EvCmdKasekiItemNo()
	{
		return default(bool);
	}

	private bool EvCmdPokeLevelChk()
	{
		return default(bool);
	}

	private bool EvCmdBTowerAppSetProc()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerRecordMenuWait()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerWorkClear()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerWorkInit()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerWorkRelease()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerTools()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerGetSevenPokeData()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerIsPrizeGet()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerIsPrizemanSet()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerSendBuf()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerRecvBuf()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerGetLeaderRoomID()
	{
		return default(bool);
	}

	private bool EvCmdBattleTowerIsLeaderDataExist()
	{
		return default(bool);
	}

	private bool EvCmdRecordInc()
	{
		return default(bool);
	}

	private bool EvCmdRecordGet()
	{
		return default(bool);
	}

	private bool EvCmdRecordAdd()
	{
		return default(bool);
	}

	private bool EvCmdRecordSet()
	{
		return default(bool);
	}

	private bool EvCmdRecordSetIflarge()
	{
		return default(bool);
	}

	private bool EvCmdSafariControlStart()
	{
		return default(bool);
	}

	private bool EvCmdSafariControlEnd()
	{
		return default(bool);
	}

	private bool EvCmdCallSafariScope()
	{
		return default(bool);
	}

	private bool EvCmdClimaxDemoCall()
	{
		return default(bool);
	}

	private bool EvCmdInitSafariTrain()
	{
		return default(bool);
	}

	private bool EvCmdMoveSafariTrain()
	{
		return default(bool);
	}

	private bool EvCmdCheckSafariTrain()
	{
		return default(bool);
	}

	private FieldEventTrainEntity GetTrain()
	{
		return null;
	}

	private bool EvCmdPlayerHeightValid()
	{
		return default(bool);
	}

	private bool EvCmdGetPokeSeikaku()
	{
		return default(bool);
	}

	private bool EvCmdChkPokeSeikakuAll()
	{
		return default(bool);
	}

	private bool EvCmdUnderGroundTalkCount()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkWalkCountClear()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkWalkCountGet()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkAccessoryNoGet()
	{
		return default(bool);
	}

	private bool EvCmdGetNewsPokeNo()
	{
		return default(bool);
	}

	private bool EvCmdNewsCountSet()
	{
		return default(bool);
	}

	private bool EvCmdNewsCountChk()
	{
		return default(bool);
	}

	private bool EvCmdStartGenerate()
	{
		return default(bool);
	}

	private bool EvCmdAddMovePoke()
	{
		return default(bool);
	}

	private bool EvCmdOshieWazaCount()
	{
		return default(bool);
	}

	private bool EvCmdRemaindWazaCount()
	{
		return default(bool);
	}

	private bool EvCmdOshieWazaListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdRemaindWazaListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdOshieWazaListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdRemaindWazaListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdNormalWazaListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdNormalWazaListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdFldTradeAlloc()
	{
		return default(bool);
	}

	private bool EvCmdFldTradeMonsno()
	{
		return default(bool);
	}

	private bool EvCmdFldTradeChgMonsno()
	{
		return default(bool);
	}

	private bool EvCmdFldTradeEvent()
	{
		return default(bool);
	}

	private bool EvCmdFldTradeDel()
	{
		return default(bool);
	}

	private bool EvCmdZukanTextVerUp()
	{
		return default(bool);
	}

	private bool EvCmdZukanSexVerUp()
	{
		return default(bool);
	}

	private bool EvCmdZenkokuZukanFlag()
	{
		return default(bool);
	}

	private bool EvCmdChkRibbonCount()
	{
		return default(bool);
	}

	private bool EvCmdChkRibbonCountAll()
	{
		return default(bool);
	}

	private bool EvCmdChkRibbon()
	{
		return default(bool);
	}

	private bool EvCmdSetRibbon()
	{
		return default(bool);
	}

	private bool EvCmdRibbonName()
	{
		return default(bool);
	}

	private bool EvCmdChkPrmExp()
	{
		return default(bool);
	}

	private bool EvCmdChkWeek()
	{
		return default(bool);
	}

	private bool EvCmdTVEntryWatchHideItem()
	{
		return default(bool);
	}

	private bool EvCmdTVEntryWatchChangeName()
	{
		return default(bool);
	}

	private bool EvCmdRegulationListCall()
	{
		return default(bool);
	}

	private bool EvCmdAshiatoChk()
	{
		return default(bool);
	}

	private bool EvCmdPcRecoverAnm()
	{
		return default(bool);
	}

	private bool EvCmdElevatorAnm()
	{
		return default(bool);
	}

	private bool EvCmdCallShipDemo()
	{
		return default(bool);
	}

	private bool EvCmdCallShipDemoSeaMap()
	{
		return default(bool);
	}

	private bool EvCmdSetupShip()
	{
		return default(bool);
	}

	private bool EvCmdGetUsedPoketchAppID()
	{
		return default(bool);
	}

	private bool EvCmdDebugPrintWork()
	{
		return default(bool);
	}

	private bool EvCmdDebugPrintFlag()
	{
		return default(bool);
	}

	private bool EvCmdDebugPrintWorkStationed()
	{
		return default(bool);
	}

	private bool EvCmdDebugPrintFlagStationed()
	{
		return default(bool);
	}

	private bool EvCmdPMVersionGet()
	{
		return default(bool);
	}

	private bool EvCmdFrontPokemon()
	{
		return default(bool);
	}

	private bool EvCmdTemotiPokeType()
	{
		return default(bool);
	}

	private bool EvCmdAikotobaKabegamiSet()
	{
		return default(bool);
	}

	private bool EvCmdGetUgHataNum()
	{
		return default(bool);
	}

	private bool EvCmdSetUpPasoAnime()
	{
		return default(bool);
	}

	private bool EvCmdStartPasoOnAnime()
	{
		return default(bool);
	}

	private bool EvCmdStartPasoOffAnime()
	{
		return default(bool);
	}

	private bool EvCmdGetKujiAtariNum()
	{
		return default(bool);
	}

	private bool EvCmdKujiAtariChk()
	{
		return default(bool);
	}

	private bool EvCmdKujiAtariInit()
	{
		return default(bool);
	}

	private bool EvCmdNickNamePC()
	{
		return default(bool);
	}

	private bool EvCmdTVInterviewerCheck()
	{
		return default(bool);
	}

	private bool EvCmdTVInterviewerMsg()
	{
		return default(bool);
	}

	private bool EvCmdTVInterviewerEntry()
	{
		return default(bool);
	}

	private bool EvCmdTVStart()
	{
		return default(bool);
	}

	private void PlayTv(TvDataTable.Sheetdata data)
	{
	}

	private FieldTvEntity FindTvEntity()
	{
		return null;
	}

	private bool EvCmdTVEnd()
	{
		return default(bool);
	}

	private bool EvCmdTVStartNumber()
	{
		return default(bool);
	}

	private bool EvCmdTVTopicBranchGet()
	{
		return default(bool);
	}

	private bool EvCmdTVTopicIntGet()
	{
		return default(bool);
	}

	private bool EvCmdTVTopicStrWordSet()
	{
		return default(bool);
	}

	private bool EvCmdTVTopicStrGenderWordSet()
	{
		return default(bool);
	}

	private bool EvCmdTvInterviewStrWordSet()
	{
		return default(bool);
	}

	private bool EvCmdTVMonitorSet()
	{
		return default(bool);
	}

	private bool EvCmdTVMonitorReset()
	{
		return default(bool);
	}

	private bool EvCmdPokeBoxCountEmptySpace()
	{
		return default(bool);
	}

	private bool EvCmdConOpenPokeSelectMenu()
	{
		return default(bool);
	}

	private bool EvCmdConOpenCapsuleSelectMenu()
	{
		return default(bool);
	}

	private bool EvCmdConOpenBoutiqueSelectMenu()
	{
		return default(bool);
	}

	private bool EvCmdConOpenMatchingMenu()
	{
		return default(bool);
	}

	private bool EvCmdConOpenResumeMatchingMenu()
	{
		return default(bool);
	}

	private IEnumerator OpOpenSubContentsWindow<T>(UIWindowID windowID, Action<T> onCompletedLoad) where T : UIWindow
	{
		return null;
	}

	private bool EvCmdConWaitContestMenu()
	{
		return default(bool);
	}

	private bool EvCmdConMyEntryNumberWordSet()
	{
		return default(bool);
	}

	private bool EvCmdConBestPerformerCheck()
	{
		return default(bool);
	}

	private bool EvCmdConCategoryRibbonNameSet()
	{
		return default(bool);
	}

	private bool EvCmdConHaveContestStarCheck()
	{
		return default(bool);
	}

	private bool EvCmdConContestStarNameSet()
	{
		return default(bool);
	}

	private bool EvCmdConRewardNameSet()
	{
		return default(bool);
	}

	private bool EvCmdConTwinkleStarNameSet()
	{
		return default(bool);
	}

	private bool EvCmdRewardShowMasterNameSet()
	{
		return default(bool);
	}

	private bool EvCmdConCategoryAndRankSet()
	{
		return default(bool);
	}

	private bool EvCmdConRankSet()
	{
		return default(bool);
	}

	private bool EvCmdConCheckEntryPoke()
	{
		return default(bool);
	}

	private bool EvCmdConResetParameter()
	{
		return default(bool);
	}

	private bool EvCmdConSelectSingleMode()
	{
		return default(bool);
	}

	private bool EvCmdConSelectMultiMode()
	{
		return default(bool);
	}

	private bool ExCmdImageClipViewConCheckProc()
	{
		return default(bool);
	}

	private bool EvCmdPokeParkControl()
	{
		return default(bool);
	}

	private bool EvCmdPokeParkDepositCount()
	{
		return default(bool);
	}

	private bool EvCmdPokeParkTransMons()
	{
		return default(bool);
	}

	private bool EvCmdPokeParkGetScore()
	{
		return default(bool);
	}

	private bool EvCmdDendouBallAnm()
	{
		return default(bool);
	}

	private bool EvCmdInitFldLift()
	{
		return default(bool);
	}

	private bool EvCmdMoveFldLift()
	{
		return default(bool);
	}

	private bool EvCmdCheckFldLift()
	{
		return default(bool);
	}

	private bool EvCmdSetupRAHCyl()
	{
		return default(bool);
	}

	private bool EvCmdStartRAHCyl()
	{
		return default(bool);
	}

	private bool EvCmdAddScore()
	{
		return default(bool);
	}

	private bool EvCmdAcceName()
	{
		return default(bool);
	}

	private bool EvCmdPartyMonsNoCheck()
	{
		return default(bool);
	}

	private bool EvCmdPartyDeokisisuFormChange()
	{
		return default(bool);
	}

	private bool EvCmdCheckMinomuchiComp()
	{
		return default(bool);
	}

	private bool EvCmdPoketchHookSet()
	{
		return default(bool);
	}

	private bool EvCmdPoketchHookReset()
	{
		return default(bool);
	}

	private bool EvCmdSlotMachine()
	{
		return default(bool);
	}

	private bool EvCmdGetNowHour()
	{
		return default(bool);
	}

	private bool EvCmdObjShakeAnm()
	{
		return default(bool);
	}

	private bool EvCmdObjBlinkAnm()
	{
		return default(bool);
	}

	private bool EvCmd_D20R0106Legend_IsUnseal()
	{
		return default(bool);
	}

	private bool EvCmdDressingImcAcceCheck()
	{
		return default(bool);
	}

	private bool EvCmdTalkMsgUnknownFont()
	{
		return default(bool);
	}

	private bool EvCmdAgbCartridgeVerGet()
	{
		return default(bool);
	}

	private bool EvCmdUnderGroundTalkCountClear()
	{
		return default(bool);
	}

	private bool EvCmdHideMapStateChange()
	{
		return default(bool);
	}

	private bool EvCmdNameInStone()
	{
		return default(bool);
	}

	private bool EvCmdMonumantName()
	{
		return default(bool);
	}

	private bool EvCmdImcBgNameSet()
	{
		return default(bool);
	}

	private bool EvCmdCompCoin()
	{
		return default(bool);
	}

	private bool EvCmdSlotRentyanChk()
	{
		return default(bool);
	}

	private bool EvCmdAddCoinChk()
	{
		return default(bool);
	}

	private bool EvCmdLevelJijiiNo()
	{
		return default(bool);
	}

	private bool EvCmdPokeLevelGet()
	{
		return default(bool);
	}

	private bool EvCmdImcAcceSubItem()
	{
		return default(bool);
	}

	private bool EvCmdc08r0801ScopeCameraSet()
	{
		return default(bool);
	}

	private bool EvCmdc08r0801ScopeSequence()
	{
		return default(bool);
	}

	private bool EvCmdLevelJijiiInit()
	{
		return default(bool);
	}

	private bool EvCmdNewNankaiWordSet()
	{
		return default(bool);
	}

	private bool EvCmdRegularCheck()
	{
		return default(bool);
	}

	private bool EvCmdNankaiWordCompleteCheck()
	{
		return default(bool);
	}

	private bool EvCmdTemotiPokeContestStatusGet()
	{
		return default(bool);
	}

	private bool EvCmdD17SystemMapSelect()
	{
		return default(bool);
	}

	private bool EvCmdUnderGroundToolGiveCount()
	{
		return default(bool);
	}

	private bool EvCmdUnderGroundKasekiDigCount()
	{
		return default(bool);
	}

	private bool EvCmdUnderGroundTrapHitCount()
	{
		return default(bool);
	}

	private bool EvCmdPofinAdd()
	{
		return default(bool);
	}

	private bool EvCmdPofinAddCheck()
	{
		return default(bool);
	}

	private bool EvCmdIsHaihuEventEnable()
	{
		return default(bool);
	}

	private bool EvCmdSodateyaPokeListSetProc()
	{
		return default(bool);
	}

	private bool EvCmdSodateyaPokeListGetResult()
	{
		return default(bool);
	}

	private bool EvCmdGetRandomHit()
	{
		return default(bool);
	}

	private bool EvCmdUnderGroundTalkCount2()
	{
		return default(bool);
	}

	private bool EvCmdHidenEffStart()
	{
		return default(bool);
	}

	private bool EvCmdZishin()
	{
		return default(bool);
	}

	private bool EvCmdBtlPointWinWrite()
	{
		return default(bool);
	}

	private bool EvCmdBtlPointWinDel()
	{
		return default(bool);
	}

	private bool EvCmdBtlPointWrite()
	{
		return default(bool);
	}

	private bool EvCmdCheckBtlPoint()
	{
		return default(bool);
	}

	private bool EvCmdAddBtlPoint()
	{
		return default(bool);
	}

	private bool EvCmdSubBtlPoint()
	{
		return default(bool);
	}

	private bool EvCmdCompBtlPoint()
	{
		return default(bool);
	}

	private bool EvCmdGetBtlPointGift()
	{
		return default(bool);
	}

	private bool EvCmdUgBallCheck()
	{
		return default(bool);
	}

	private bool EvCmdAusuItemCheck()
	{
		return default(bool);
	}

	private bool EvCmdCheckMyGSID()
	{
		return default(bool);
	}

	private bool EvCmdGetFriendDataNum()
	{
		return default(bool);
	}

	private bool EvCmdGetCoinGift()
	{
		return default(bool);
	}

	private bool EvCmdSubWkCoin()
	{
		return default(bool);
	}

	private bool EvCmdCompWkCoin()
	{
		return default(bool);
	}

	private bool EvCmdAikotobaOkurimonoChk()
	{
		return default(bool);
	}

	private bool EvCmdWifiHusiginaokurimonoOpenFlagSet()
	{
		return default(bool);
	}

	private bool EvCmdUnionGetCardTalkNo()
	{
		return default(bool);
	}

	private bool EvCmdWirelessIconEasy()
	{
		return default(bool);
	}

	private bool EvCmdWirelessIconEasyEnd()
	{
		return default(bool);
	}

	private bool EvCmdSaveFieldObj()
	{
		return default(bool);
	}

	private bool EvCmdSealName()
	{
		return default(bool);
	}

	private bool EvCmdSetEscapeLocation()
	{
		return default(bool);
	}

	private bool EvCmdFieldObjBitSetFellowHit()
	{
		return default(bool);
	}

	private bool EvCmdDameTamagoChkAll()
	{
		return default(bool);
	}

	private bool EvCmdUnionBmpMenuStart()
	{
		return default(bool);
	}

	private bool EvCmdUnionBattleStartCheck()
	{
		return default(bool);
	}

	private bool EvCmdGetCardRank()
	{
		return default(bool);
	}

	private bool EvCmdFieldScopeModeSet()
	{
		return default(bool);
	}

	private bool EvCmdFieldScopeModeReSet()
	{
		return default(bool);
	}

	private bool EvCmd_SET_TURN_HERO_FRAME()
	{
		return default(bool);
	}

	private bool EvCmd_SET_TURN_OBJ_FRAME()
	{
		return default(bool);
	}

	private bool EvCmd_DEBUG_PRINT()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_HERO_MOVE_GRID_CENTER()
	{
		return default(bool);
	}

	private bool EvCmd_SET_POS_HERO_MATCH_X()
	{
		return default(bool);
	}

	private bool EvCmd_SET_POS_HERO_MATCH_Z()
	{
		return default(bool);
	}

	private bool EvCmd_GET_LANGUAGE()
	{
		return default(bool);
	}

	private bool EvCmd__GET_REL_POS_HERO()
	{
		return default(bool);
	}

	private bool EvCmd__CAMERA_TARGET_HERO()
	{
		return default(bool);
	}

	private bool EvCmd__CAMERA_TARGET_DUMMY()
	{
		return default(bool);
	}

	private bool EvCmd_DUMMY_ANIME()
	{
		return default(bool);
	}

	private bool EvCmd__DUMMY_ANIME_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_DUMMY_SET_POS()
	{
		return default(bool);
	}

	private bool EvCmd_DUMMY_SET_POS_HERO()
	{
		return default(bool);
	}

	private bool EvCmd_SET_CUSTUM_WIN_MSBT()
	{
		return default(bool);
	}

	private bool EvCmd_ADD_CUSTUM_WIN_LABEL()
	{
		return default(bool);
	}

	private bool EvCmd_ADD_CUSTUM_WIN_LABEL_TWO_WINDOW()
	{
		return default(bool);
	}

	private bool EvCmd_OPEN_CUSTUM_WIN()
	{
		return default(bool);
	}

	private bool EvCmd_OPEN_CUSTUM_WIN_FIXED()
	{
		return default(bool);
	}

	private bool EvCmd_VISIBLE_OBJ_PROP()
	{
		return default(bool);
	}

	private bool EvCmd_INVISIBLE_OBJ_PROP()
	{
		return default(bool);
	}

	private bool EvCmd_EVENT_CAMERA_MODE()
	{
		return default(bool);
	}

	private bool EvCmd_SET_EVENT_CAMERA_PARAM()
	{
		return default(bool);
	}

	private bool EvCmd_EVENT_CAMERA_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_EVENT_CAMERA_FRAME()
	{
		return default(bool);
	}

	private bool EvCmd_HIT_DOOR_ANIME()
	{
		return default(bool);
	}

	private bool EvCmd_HIT_DOOR_ANIME_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_SET_DOOR_OBJ()
	{
		return default(bool);
	}

	private bool EvCmdRotomuFormCheck()
	{
		return default(bool);
	}

	private bool EvCmdRotomuFormWazaChange()
	{
		return default(bool);
	}

	private bool EvCmdTemotiRotomuFormChangeGet()
	{
		return default(bool);
	}

	private bool EvCmdTemotiPokeChkNum()
	{
		return default(bool);
	}

	private bool EvCmdTemotiRotomuFormNoGet()
	{
		return default(bool);
	}

	private bool EvCmdEventGetTemotiPokeChkGetPos()
	{
		return default(bool);
	}

	private bool EvCmd_TURN_HERO_TALK_OBJ()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_SPEED()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_BALL()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_DEFAULT()
	{
		return default(bool);
	}

	private bool EvCmd_DOOR_FORCE_ANIME_END()
	{
		return default(bool);
	}

	private bool EvMacro_LDVAL_VERSION()
	{
		return default(bool);
	}

	private bool EvMacro_LDVAL_SEX()
	{
		return default(bool);
	}

	private bool EvCmd_DEBUG_RESET_WORK()
	{
		return default(bool);
	}

	private bool EvCmd_SET_SYS_FLAG()
	{
		return default(bool);
	}

	private bool EvCmd_RESET_SYS_FLAG()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_SET_COS_ANGLE()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_COS_ANGLE_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_HERO_MOVE_GRID_CENTER_FRONT()
	{
		return default(bool);
	}

	private bool EvCmd_WARP_ENABLE_SET()
	{
		return default(bool);
	}

	private bool EvCmd_DOOR_ENABLE_SET()
	{
		return default(bool);
	}

	private bool EvCmd_AC_ANIM_LOCK()
	{
		return default(bool);
	}

	private bool EvCmd_AC_ANIM_RELEASE()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_SET_OFFSET()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_OFFSET_WAIT()
	{
		return default(bool);
	}

	private bool EvCmdNaminoriEnd()
	{
		return default(bool);
	}

	private bool EvCmdTakikudari()
	{
		return default(bool);
	}

	private bool EvCmdKabeNoboriCheck()
	{
		return default(bool);
	}

	private bool EvCmdTalkPokeGetTemotiIndex()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkGetMonohiroiItemNo()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkPokeCreate()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkPokeKaisan()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkPokeSyuugou()
	{
		return default(bool);
	}

	private bool EvCmdNaturalParkPokeSelectMenu()
	{
		return default(bool);
	}

	private bool EvCmdObjAnimeFureai()
	{
		return default(bool);
	}

	private FieldEventEntity FindEventEntity(string name)
	{
		return null;
	}

	private FieldEventEntity FindEventDoorEntity(string name)
	{
		return null;
	}

	private bool HeroMoveGridCenterFront(float deltaTime)
	{
		return default(bool);
	}

	private bool BoardReq()
	{
		return default(bool);
	}

	private bool BoardEndWait(EvWork.WORK_INDEX work)
	{
		return default(bool);
	}

	private Vector3 ArgPosToPosition(int gx, int gy, int gz)
	{
		return default(Vector3);
	}

	private bool CheckValidPokemonParam(PokemonParam param)
	{
		return default(bool);
	}

	private bool CheckCanBattlePokemonParam(PokemonParam param)
	{
		return default(bool);
	}

	private int GetPokemonFormNo(PokemonParam param)
	{
		return default(int);
	}

	private void TemotiBoxScan(Action<PokemonParam> action)
	{
	}

	private void TemotiBoxScan(Func<PokemonParam, int, int, bool> action)
	{
	}

	private void BoxScan(Action<PokemonParam> action)
	{
	}

	private void BoxScan(Func<PokemonParam, int, int, bool> action)
	{
	}

	private int GetOriginalCassetVersion()
	{
		return default(int);
	}

	private DIR SetupHeroMoveGridCenterFrontDir([In] ref RectInt stopGridArea, [In] ref Vector2Int nowGrid, [In] ref Vector2Int oldGrid)
	{
		return default(DIR);
	}

	private static bool InGridArea([In] ref RectInt area, int x, int y)
	{
		return default(bool);
	}

	private bool EvCmdShopOpen()
	{
		return default(bool);
	}

	private bool EvCmdShopOpenWait()
	{
		return default(bool);
	}

	private bool EvCmdDoorTransitionZoneSet()
	{
		return default(bool);
	}

	private bool EvCmdMoveCombatGymWall()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityPlayerMoveStart()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityPlayerMoveEnd()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityPlayerMoveReset()
	{
		return default(bool);
	}

	public bool CheckCanSeedWater(int groupId)
	{
		return default(bool);
	}

	private bool EvCmdCheckCanSeedWater()
	{
		return default(bool);
	}

	private bool EvCmdOpenFixedShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenSealShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenBattleParkShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenTobari4fShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenFlowerShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenOtenkiShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenPalParkShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenSellShop()
	{
		return default(bool);
	}

	private bool EvCmdOpenBoutiqueShopBuy()
	{
		return default(bool);
	}

	private bool EvCmdOpenBoutiqueShopChange()
	{
		return default(bool);
	}

	private bool EvCmdOpenFloor()
	{
		return default(bool);
	}

	private bool EvCmdCloseFloor()
	{
		return default(bool);
	}

	private bool EvCmdOpenMoney()
	{
		return default(bool);
	}

	private bool EvCmdCloseMoney()
	{
		return default(bool);
	}

	private bool EvCmdGetCostume()
	{
		return default(bool);
	}

	private bool EvCmdAnawohoru()
	{
		return default(bool);
	}

	private bool EvCmdAnanukenohimo()
	{
		return default(bool);
	}

	private bool EvCmdTeleport()
	{
		return default(bool);
	}

	private bool EvCmdAmaikaori()
	{
		return default(bool);
	}

	private bool EvCmdAmaimitu()
	{
		return default(bool);
	}

	private bool NeckRotateHero()
	{
		return default(bool);
	}

	private bool NeckOnlyRotateHero()
	{
		return default(bool);
	}

	private bool NeckRotateTarget(bool isTurnNotFlag)
	{
		return default(bool);
	}

	private bool CalcNeckRotateAngle(FieldCharacterEntity player, ref Vector3 tPos, out float angle)
	{
		return default(bool);
	}

	private bool EvCmdWarpStartAnimation()
	{
		return default(bool);
	}

	private bool EvCmdWarpEndAnimation()
	{
		return default(bool);
	}

	private bool EvCmdSafariScopeSequence()
	{
		return default(bool);
	}

	private bool EvCmdEventCameraIndex()
	{
		return default(bool);
	}

	private bool EvCmdEventCameraEndWait()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaExistEgg()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaStoredCount()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaSetStoredName()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaStoreUI()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaStore()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaRestore()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaLoveLevel()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaGetStoredMonsNo()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaGetEgg()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaDiscardEgg()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaSetStoredInfoStr()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaGetStoredSex()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyOldmanInit()
	{
		return default(bool);
	}

	private bool EvCmd_ADD_CUSTUM_WIN_LABEL_WORD_SET()
	{
		return default(bool);
	}

	private bool EvCmd_OPEN_CUSTUM_WIN_WORD_SET()
	{
		return default(bool);
	}

	private bool EvCmd_BTL_ENCSEQ_LOAD()
	{
		return default(bool);
	}

	private bool EvCmd_UseSpray()
	{
		return default(bool);
	}

	private bool EvCmd_GET_PLAYER_CAP()
	{
		return default(bool);
	}

	private bool EvCmdCameraShake()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityClipPlay()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityClipWait()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityAttachPlayer()
	{
		return default(bool);
	}

	private bool EvCmdEventEntityVisible()
	{
		return default(bool);
	}

	private bool EvCmd_FACE_INDEX()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_EXIST_CHECK()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_ENTRY_CHECK()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_NAME()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_LEADER_NAME()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_NAME_IN()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_ENTRY()
	{
		return default(bool);
	}

	private bool EvCmd_GROUP_MAKE()
	{
		return default(bool);
	}

	private bool EvCmdTemotiBallLoad()
	{
		return default(bool);
	}

	private bool EvCmdTemotiBallLoadWait()
	{
		return default(bool);
	}

	private bool EvCmdPokecenPutBall()
	{
		return default(bool);
	}

	private bool EvCmdPokecenClearBall()
	{
		return default(bool);
	}

	private bool EvCmd_CHARA_LOOK_LOCK()
	{
		return default(bool);
	}

	private bool EvCmd_CHARA_LOOK_RELEASE()
	{
		return default(bool);
	}

	private bool EvCmd_TALK_OBJ_START_LOOK_NONE()
	{
		return default(bool);
	}

	private bool EvCmdBoukennootoTipsOpen()
	{
		return default(bool);
	}

	private bool EvCmdBoukennootoTipsOpenWait()
	{
		return default(bool);
	}

	private bool EvCmdOpenSpecialWinLabel()
	{
		return default(bool);
	}

	private bool EvCmdWaitSpecialWinLabel()
	{
		return default(bool);
	}

	private bool EvCmdHidenEffWait()
	{
		return default(bool);
	}

	private bool EvCmd_GET_URAYAMA_ENCOUNT_INDEX()
	{
		return default(bool);
	}

	private bool EvCmd_CUSTOM_BALL_NUM_ADD()
	{
		return default(bool);
	}

	private bool EvCmd_CHANGE_FASHION_REQ()
	{
		return default(bool);
	}

	private bool EvCmdWarpPanelStart()
	{
		return default(bool);
	}

	private bool EvCmdWarpPanelEnd()
	{
		return default(bool);
	}

	private bool EvCmdOpenPasswordSWKeyboard()
	{
		return default(bool);
	}

	private bool EvCmdSetMatchingGroup()
	{
		return default(bool);
	}

	public bool EvCmdCheckOnlineAccount()
	{
		return default(bool);
	}

	private bool EvCmdWaitCheckOnlineAccount()
	{
		return default(bool);
	}

	private bool EvCmd_DENDOU_NUM_SET()
	{
		return default(bool);
	}

	private bool EvCmdTemotiBoxPokeChk()
	{
		return default(bool);
	}

	private bool EvCmdTemotiBoxMonsNo()
	{
		return default(bool);
	}

	private PokemonParam GetPokemonParam(int trayIndex, int index)
	{
		return null;
	}

	private bool EvCmdCallWazaOmoidashiUi()
	{
		return default(bool);
	}

	private bool EvCmdCallWazaWasureUi()
	{
		return default(bool);
	}

	private bool EvCmdCallWazaOshieUi()
	{
		return default(bool);
	}

	private bool CallWazaUiCommon(UIWazaManage.BootType bootType, PokemonParam pokemonParam, Action<WazaNo, WazaNo> resultCallback, WazaNo oshieWazaNo = WazaNo.NULL)
	{
		return default(bool);
	}

	private void LearnWaza(PokemonParam param, WazaNo learnWazaNo, WazaNo unlearnWazaNo)
	{
	}

	private bool EvCmdCheckWazaOshie()
	{
		return default(bool);
	}

	private bool EvCmdCheckWazaOshieAll()
	{
		return default(bool);
	}

	private WazaOshieResult CheckWazaOshie(PokemonParam param, WazaNo oshieWazaNo)
	{
		return default(WazaOshieResult);
	}

	private bool EvCmdTemotiBoxPokemonName()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_CHK_ENTRY_POKE_NUM()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_CLEAR_PLAY_DATA()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_PUSH_NOW_LOCATION()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_POP_NOW_LOCATION()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_GET_WIFI_RANK()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_SET_PLAY_MODE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_SET_NOW_WIN()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_TOOL_SET_RANK()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_RANK()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_RANK_DOWN_LOSE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_RANK_DOWN_LOSE_RESET()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_ADD_LOSE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_CHK_ENTRY_POKE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_NOW_ROUND()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_INC_ROUND()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_IS_CLEAR()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_RENSHOU_CNT()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_SET_SCORE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_CHOICE_BTL_PARTNER()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_LOCAL_BTL_CALL()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_PLAY_MODE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_SET_LEADER_CLEAR_FLAG()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_LEADER_CLEAR_FLAG()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_ADD_BATTLE_POINT()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_RENSHOU_RIBBON_SET()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_MINE_OBJ()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_UPDATE_RANDOM()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_DEB_IS_WORK_NULL()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_BTL_TRAINER_SET()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_PLAYER_WIN_CHECK()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_ADD_BATTLE_POINT_MANUAL()
	{
		return default(bool);
	}

	private bool EvCmdSaveRendouEnable()
	{
		return default(bool);
	}

	private bool EvCmd_RETURN_LOOP()
	{
		return default(bool);
	}

	private bool EvCmd_INPUT_JUMP()
	{
		return default(bool);
	}

	private bool EvCmd_SET_VISIBILITY()
	{
		return default(bool);
	}

	private void ChangeVisibility(FieldCharacterEntity entity, int type, bool flag)
	{
	}

	private bool EvCmd_LOAD_CAMERA_CONTROLLER()
	{
		return default(bool);
	}

	private bool EvCmd_RELEASE_CAMERA_CONTROLLER()
	{
		return default(bool);
	}

	private bool EvCmd_LOAD_WAIT_CAMERA_CONTROLLER()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_CONTROLLER_PLAY()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_CONTROLLER_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_CONTROLLER_END()
	{
		return default(bool);
	}

	private bool EvCmd_TUREARUKI_POKEMON_TALK()
	{
		return default(bool);
	}

	private bool EvCmd_TUREARUKI_POKEMON_INDEX()
	{
		return default(bool);
	}

	private bool EvCmd_TUREARUKI_TAKE_ITEM()
	{
		return default(bool);
	}

	private bool EvCmd_TUREARUKI_ITEM_TIMER_SET()
	{
		return default(bool);
	}

	private bool EvCmd_TUREARUKI_POKE_CREATE()
	{
		return default(bool);
	}

	private bool EvCmd_TUREARUKI_POKE_DELETE()
	{
		return default(bool);
	}

	private bool EvCmd_FIND_BG_ENABLE()
	{
		return default(bool);
	}

	private bool EvCmd_FIND_BG_DISABLE()
	{
		return default(bool);
	}

	private bool EvCmd_CALL_EFFECT()
	{
		return default(bool);
	}

	private bool EvCmd_STOP_EFFECT()
	{
		return default(bool);
	}

	public bool EvCmd_RELEASE_EFFECT()
	{
		return default(bool);
	}

	private bool EvCmd_CALL_EFFECT_OBJ()
	{
		return default(bool);
	}

	private bool EvCmd_EFF_SCALE()
	{
		return default(bool);
	}

	private IEnumerator EffScaleAnime(int index, float min, float max, float spd)
	{
		return null;
	}

	private bool EvCmd_POKELIST_FORM_CHANGE_SET_PROC()
	{
		return default(bool);
	}

	private bool EvCmd_POKELIST_FORM_CHANGE_GET_RESULT()
	{
		return default(bool);
	}

	private bool EvCmd_CASSET_VERSION_GET()
	{
		return default(bool);
	}

	private bool EvCmd_BOX_OPEN_NORMAL()
	{
		return default(bool);
	}

	private bool EvCmd_BOX_OPEN_SELECT()
	{
		return default(bool);
	}

	private bool EvCmd_AK_LISNER_TRA()
	{
		return default(bool);
	}

	private bool EvCmd_AK_LISNER_POS()
	{
		return default(bool);
	}

	private bool EvCmd_AK_LISNER_ROT()
	{
		return default(bool);
	}

	private bool EvCmd_SET_TV_INT()
	{
		return default(bool);
	}

	private bool EvCmd_SET_TV_PLAYER_NAME()
	{
		return default(bool);
	}

	private bool EvCmd_SET_TV_POKE_NICK_NAME()
	{
		return default(bool);
	}

	private bool EvCmd_TV_TPIC_ENABLE()
	{
		return default(bool);
	}

	private bool EvCmd_TV_TPIC_BRANCH()
	{
		return default(bool);
	}

	private bool EvCmd_AUTO_TANKEN_SET()
	{
		return default(bool);
	}

	private bool EvCmd_AUTO_TANKEN_SET_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_USE_TANKENSET()
	{
		return default(bool);
	}

	private bool EvCmd_LOCALKOUKAN_APPLY()
	{
		return default(bool);
	}

	private bool EvCmd_ZUKAN_TOUROKU()
	{
		return default(bool);
	}

	private bool EvCmd_ZUKAN_TOUROKU_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_CHK_ZUKAN_TOUROKU()
	{
		return default(bool);
	}

	private bool EvCmd_AUTO_SAVE()
	{
		return default(bool);
	}

	private bool EvCmd_AUTO_SAVE_BACK_UP_ON()
	{
		return default(bool);
	}

	private bool EvCmd_ENDING_DEMO()
	{
		return default(bool);
	}

	private bool EvCmdAzukariyaTakeOverPoke()
	{
		return default(bool);
	}

	private bool EvCmd_TALK_UNION_NPC()
	{
		return default(bool);
	}

	private bool EvCmd_TALK_COLISEUM_NPC()
	{
		return default(bool);
	}

	private bool EvCmd_POKETORE_GET_CHARGE()
	{
		return default(bool);
	}

	private bool EvCmd_POKETORE_START()
	{
		return default(bool);
	}

	private bool EvCmd_BICYCLE_COLOR_SET()
	{
		return default(bool);
	}

	private bool EvCmd_BICYCLE_COLOR_GET()
	{
		return default(bool);
	}

	private bool EvCmd_PARK_ITEM_NAME()
	{
		return default(bool);
	}

	private bool EvCmd_LOAD_UMA_ANIME()
	{
		return default(bool);
	}

	private IEnumerator LoadUMAAsset()
	{
		return null;
	}

	private bool EvCmd_RELEASE_UMA_ANIME()
	{
		return default(bool);
	}

	private bool EvCmd_LOAD_UMA_ANIME_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_UMA_ANIME_PLAY()
	{
		return default(bool);
	}

	private bool EvCmd_UMA_ANIME_ATTACH()
	{
		return default(bool);
	}

	private bool EvCmd_UMA_PLAY_WAIT()
	{
		return default(bool);
	}

	private bool EvCmd_OBJ_ANIME_SPEED()
	{
		return default(bool);
	}

	private bool EvCmd_OBJ_SCALE()
	{
		return default(bool);
	}

	private bool EvCmd_BADGE_GET()
	{
		return default(bool);
	}

	private bool EvCmdAddUgItem()
	{
		return default(bool);
	}

	private bool EvCmd_DOF_FAR_DEPTH()
	{
		return default(bool);
	}

	private bool EvCmd_DISPLAY_MESSAGE()
	{
		return default(bool);
	}

	private bool EvCmd_DISPLAY_MESSAGE_CLOSE()
	{
		return default(bool);
	}

	private bool EvCmdCustomBallTrainerPage()
	{
		return default(bool);
	}

	private bool EvCmdCustomBallTrainerCopyOpen()
	{
		return default(bool);
	}

	private bool EvCmdUgItemName()
	{
		return default(bool);
	}

	private bool EvCmdFureaiTalkStart()
	{
		return default(bool);
	}

	private bool EvCmdFureaiTalkEnd()
	{
		return default(bool);
	}

	private bool EvCmdPlayFureaiVoiceNakayoshiRank()
	{
		return default(bool);
	}

	private bool EvCmdCreateHyouta()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_DUNGEON_OUT()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_DUNGEON_IN()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_BUILDING_OUT()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_BUILDING_IN()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_AREA_OUT()
	{
		return default(bool);
	}

	private bool EvCmd_FADE_AREA_IN()
	{
		return default(bool);
	}

	private bool EvCmdCustomBallTrainerOpenWait()
	{
		return default(bool);
	}

	private bool EvCmd_EMBANKMENT()
	{
		return default(bool);
	}

	private bool EvCmdEntryUwasaZukan()
	{
		return default(bool);
	}

	private bool EvCmdTrainingOpen()
	{
		return default(bool);
	}

	private bool EvCmdTrainingOpenWait()
	{
		return default(bool);
	}

	private bool EvCmdTalkUgNpc()
	{
		return default(bool);
	}

	private bool EvCmd_CAMERA_CONTROLLER_IS_NULL()
	{
		return default(bool);
	}

	private bool EvCmd_UMA_IS_NULL()
	{
		return default(bool);
	}

	private bool EvCmdGetIsHaveSecretBase()
	{
		return default(bool);
	}

	private bool EvCmdGetUgNpcTalkCount()
	{
		return default(bool);
	}

	private bool EvCmdResetUgNpcTalkCount()
	{
		return default(bool);
	}

	private bool EvCmd_TEMOTI_POKE_CHK_GET_POS()
	{
		return default(bool);
	}

	private bool EvCmd_SET_FORCE_BLINK()
	{
		return default(bool);
	}

	private bool EvCmd_CheckSecretBaseExpantion()
	{
		return default(bool);
	}

	private bool EvCmd_END_LIGHTINTENSITY()
	{
		return default(bool);
	}

	private bool EvCmd_END_LIGHTINTENSITY_CHARCTER()
	{
		return default(bool);
	}

	private bool EvCmd_END_LIGHTINTENSITY_POKE()
	{
		return default(bool);
	}

	private bool EvCmd_SET_LIGHTINTENSITY()
	{
		return default(bool);
	}

	private bool EvCmd_SET_LIGHTINTENSITY_CHARCTER()
	{
		return default(bool);
	}

	private bool EvCmd_SET_LIGHTINTENSITY_POKE()
	{
		return default(bool);
	}

	private void EnvironmentControllerSetLight(EnvironmentController controller, float deltaTime)
	{
	}

	private void EnvironmentControllerSetLightCharacter(EnvironmentController controller, float deltaTime)
	{
	}

	private void EnvironmentControllerSetLightPoke(EnvironmentController controller, float deltaTime)
	{
	}

	private bool EnviromentLightUpdate(int index, float deltaTime, out float ret)
	{
		return default(bool);
	}

	private bool EvCmd_TV_RED_GYARADOS_ON()
	{
		return default(bool);
	}

	private bool EvCmd_TV_RED_GYARADOS_OFF()
	{
		return default(bool);
	}

	private bool EvCmd_AUTO_MSG()
	{
		return default(bool);
	}

	private bool EvCmd_AUTO_MSG_STOP()
	{
		return default(bool);
	}

	private bool EvCmd_GET_TAG_PATNER_ID()
	{
		return default(bool);
	}

	private bool EvCmd_UNIQUE_POKE_TEMP()
	{
		return default(bool);
	}

	private bool EvCmd_UNIQUE_POKE_FIX()
	{
		return default(bool);
	}

	private bool EvCmd_NICKNAME_PLACEMENT()
	{
		return default(bool);
	}

	private bool EvCmd_GET_FORM()
	{
		return default(bool);
	}

	private void CreateTurearuki()
	{
	}

	private void DeleteTurearuki()
	{
	}

	private bool EvCmd_NICK_NAME_ALL()
	{
		return default(bool);
	}

	private bool EvCmd_DOF_CHANGE_TARGET_POS()
	{
		return default(bool);
	}

	private bool EvCmd_DOF_RESET_TARGET_POS()
	{
		return default(bool);
	}

	private bool EvCmd_ADD_MAROYAKA_POFFIN()
	{
		return default(bool);
	}

	private bool EvCmd_ALL_MONSNO()
	{
		return default(bool);
	}

	private bool EvCmd_ALL_MONS_OWN_CHK()
	{
		return default(bool);
	}

	private bool EvCmd_POKE_LVUP_HOW_MANY()
	{
		return default(bool);
	}

	private bool EvCmd_USE_SPECIAL_ITEM()
	{
		return default(bool);
	}

	private bool EvCmd_GET_BP()
	{
		return default(bool);
	}

	private bool EvCmd_FOV_OFFSET_RATE()
	{
		return default(bool);
	}

	private bool EvCmd_USE_SUB_ATTRIBUTE()
	{
		return default(bool);
	}

	private bool EvCmd_POKE_LEVEL_GET_ALL()
	{
		return default(bool);
	}

	private bool EvCmd_RESET_SAVEBGM()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_SELECT_POKE()
	{
		return default(bool);
	}

	private bool EvCmd_BTWR_SUB_GET_ENTRY_POKE()
	{
		return default(bool);
	}

	private bool EvCmd_SET_GLOBALWATERFIELD()
	{
		return default(bool);
	}

	private bool EvCmd_GET_STATUENUM()
	{
		return default(bool);
	}

	private bool EvCmdGetFureaiSelectPokeTemotiNo()
	{
		return default(bool);
	}

	private bool EvCmd_POKE_TARENT_POW_MAX()
	{
		return default(bool);
	}

	private bool EvCmd_OPEN_BATTLE_WIN()
	{
		return default(bool);
	}

	private IEnumerator LoadBattleWindow(Action onLoad)
	{
		return null;
	}

	private void OpenBattleWindow()
	{
	}

	private bool EvCmd_OJIGI()
	{
		return default(bool);
	}

	private bool OjibiCallback(AnimationPlayer anime)
	{
		return default(bool);
	}

	private bool EvCmdSavePlayReport()
	{
		return default(bool);
	}

	private bool EvCmd_SET_STOP_EYE_ENCOUNT()
	{
		return default(bool);
	}

	private bool EvCmd_RESET_STOP_EYE_ENCOUNT()
	{
		return default(bool);
	}

	private bool EvCmd_PLAY_REPORT_TRAINING()
	{
		return default(bool);
	}

	private bool EvCmd_PLAY_REPORT_BTLTOWER_WIN()
	{
		return default(bool);
	}

	private bool RunEvCmd(int index)
	{
		return default(bool);
	}

	private bool WarpSegmentHitCheck(FieldEventDoorEntity entity, out Vector3 reusltPosition, out float subtendedAngle, out float lineDistance, float hitrange)
	{
		return default(bool);
	}

	private void SegmentHit(ref Vector2 segA, ref Vector2 segB, ref Vector2 targetPos, float radius, out float angleAT, out float angleBT, out float distance, out int hitstatus)
	{
	}

	public void InitScriptLoad()
	{
	}

	public bool InitScriptLoadWait()
	{
		return default(bool);
	}

	public void InitScriptEnd()
	{
	}

	private bool IsRockclimbLabel(string label)
	{
		return default(bool);
	}

	public void SaveDataReflection()
	{
	}

	public void SetSaveObj()
	{
	}

	public void SetupGimmickEntity()
	{
	}

	public void SceneStartGimmickEntity()
	{
	}

	public static void PlayHoneyTreeAnimation(ZoneID zoneId)
	{
	}

	private void CreateWorpPoint()
	{
	}

	private FieldEventDoorEntity CreateWarpEntity(MapWarp.SheetData data, int[] index, Vector2 size, int[] locator)
	{
		return null;
	}

	public IEnumerator RequestAssetSetUp(AreaID areaid)
	{
		return null;
	}

	public IEnumerator PreRequestAssetSetUp(AreaID areaid)
	{
		return null;
	}

	private void SetSaveDataParam(ref LoadObjectData lodata)
	{
	}

	public void SetCreateParent(Transform parent)
	{
	}

	public void SortLoadObjectData(Vector2Int grid)
	{
	}

	public IEnumerator StartUpCreate()
	{
		return null;
	}

	public void UpdateCreate()
	{
	}

	public void Init_PokemonCenter()
	{
	}

	public void Init_FieldShip()
	{
	}

	public bool RefCountZeroUnload()
	{
		return default(bool);
	}

	public bool ForceUnload()
	{
		return default(bool);
	}

	public bool IsLoadAssetBundle()
	{
		return default(bool);
	}

	private void LoadObjectCreate(LoadObjectData lodata)
	{
	}

	private void LoadObjectCreate_BOX(LoadObjectData lodata)
	{
	}

	private void LoadObjectCreate_Asset(LoadObjectData lodata)
	{
	}

	private void LoadObjectCreate_KinomiGrow(KinomiPlaceData.SheetSheet1 kinomiPlaceData)
	{
	}

	public int FieldObjectEntityAdd(FieldObjectEntity entity)
	{
		return default(int);
	}

	public void FieldObjectEntityRemove(FieldObjectEntity entity)
	{
	}
}
