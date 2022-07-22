using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Field;
using Dpr.Field.Walking;
using Dpr.Item;
using Dpr.SubContents;
using Dpr.Trainer;
using Dpr.UI;
using Effect;
using Pml;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

public class FieldManager
{
	public enum UpdateType
	{
		Field,
		UnderGround,
		Encount,
		Fishing,
		DemoWait
	}

	private enum EncountUpdateType
	{
		CallEffect,
		EndWait,
		CallBackWait,
		TrainerEffWait,
		End
	}

	public enum EncountFadeType
	{
		Normal,
		Trainer
	}

	public enum AttributeEventType
	{
		Run,
		Jump
	}

	public enum AttributeEventCallType
	{
		Player,
		NPC_Heel,
		NPC
	}

	public struct AttributeEvent
	{
		public int chartype;

		public bool isRun;

		public bool isBic;

		public FieldObjectEntity entity;

		public AttributeEventType eventType;

		public AttributeEventCallType callType;
	}

	private class LoadEffectData
	{
		public string name;

		public EffectData effect;

		public bool isLoading;

		public bool isComplete;
	}

	public delegate bool FieldWazaAction(float deltatime);

	public enum AutoSaveState
	{
		None,
		Zone_Change,
		BattleResult,
		EventScript,
		Stop
	}

	private const int MapSize = 64;

	public Action OnZoneChangeOnce;

	public static FieldWalkingManager fwMng;

	public static Utils.AssetUnloader abUnloader;

	private UpdateType _updateType;

	private EncountUpdateType _encountUpdateType;

	private float _encountWait;

	private EncountFadeType _encountFadeType;

	private Queue<AttributeEvent> _attributeEntitySE;

	private Queue<AttributeEvent> _attributeEntityEffect;

	public MapType NowMapType;

	public MapType OldMapType;

	private ZoneID _now_zoneID;

	private LoadEffectData[] _effectDataArray;

	private EffectInstance _weatherEffectInstance;

	private SYS_WEATHER _nowWeather;

	private FieldWeather _weather;

	public FieldMistWork MistWork;

	public FieldFlashWork FlashWork;

	private TrainerID _btl_trainerID1;

	private TrainerID _btl_trainerID2;

	private GameObject _ug_hole;

	private bool _is_ugHoleLock;

	private Vector3 _ugHolePos;

	private UgMainProc _ugMainProc;

	private GameObject _fldCanvasObject;

	private AssetRequestOperation _fldCanvasAssetReqOpe;

	private int _oldEncountWalkCount;

	private EncountFadeTextures _encFadeTextures;

	private Material _encFadeMaterial;

	private AssetRequestOperation _encFadeTexturesReqOpe;

	private EncountResult _encResult;

	private EncEffectSequenceController _encEffctController;

	private int _encEffectCount;

	private GameObject[] _encEffectAsset;

	private bool _encountAttriLog;

	private FieldFishing _fishing;

	private FishingRod _useRod;

	private FieldWazaAction _wazaAction;

	private bool _isMenuOpenRequest;

	private float _shortCutPushTime;

	private int _shortCutPushHoldId;

	public bool SND_W_ID_CTRL_BGM_FLAG;

	private UpdateType _demoReturnType;

	private bool _demoReturnInput;

	private uint _WalkEventName_Attribute;

	private bool _initFlag;

	private AutoSaveState _autoSaveState;

	public static bool SealPrevFalg;

	public Vector3 eventTownMapPos;

	private List<int> unnnoonFormList;

	private int _shorCutSeq;

	private Transform _akLisnerTransform;

	public static FieldManager Instance
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

	public static bool IsResume
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public UpdateType updateType => default(UpdateType);

	public MapInfo.SheetZoneData ZoneData => null;

	public AreaID areaID => default(AreaID);

	public ZoneID zoneID => default(ZoneID);

	public ZoneID Before_zoneID
	{
		[CompilerGenerated]
		get
		{
			return default(ZoneID);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public GameObject UG_Hole => null;

	public static bool IsWazaActionEnd => default(bool);

	public uint _nowEventId
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public bool IsMenuOpen
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsPoketchOpen
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public KinomiResources KinomiResources
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

	public event Action OnZoneChangeEvent
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

	public event Action OnSceneInitEvent
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

	private void SeqOnDestroy()
	{
	}

	public void SetDefaultParam()
	{
	}

	public IEnumerator SceneInit()
	{
		return null;
	}

	private bool IsSavedMapType(MapType mapType)
	{
		return default(bool);
	}

	private bool IsTownMapNoSavedZone(ZoneID zoneid)
	{
		return default(bool);
	}

	public bool IsSceneLoadEnd()
	{
		return default(bool);
	}

	public bool UnUsed_UnloadAsset()
	{
		return default(bool);
	}

	public IEnumerator SceneInitAfter()
	{
		return null;
	}

	private IEnumerator EffectLoad()
	{
		return null;
	}

	public void SceneStart()
	{
	}

	public void OnDestroy()
	{
	}

	private bool IsDemoReqestStop()
	{
		return default(bool);
	}

	public void ActiveUpdate()
	{
	}

	public void DeleteUpdate()
	{
	}

	public void update(float deltatime)
	{
	}

	public void lateupdate(float deltatime)
	{
	}

	public void postLateUpdate(float deltatime)
	{
	}

	public void OnZoneChange(bool walk = true)
	{
	}

	public void SetAutoSaveState(AutoSaveState state)
	{
	}

	public bool AutoSave(bool isForce = false, bool mainsave = true, bool backup = true, bool underground = false)
	{
		return default(bool);
	}

	public IEnumerator ZoneChangeAutoSave()
	{
		return null;
	}

	public void ZoneChangeSetZenmetu(ZoneID transition)
	{
	}

	public IEnumerator OnSceneChange()
	{
		return null;
	}

	private void fdUpdate(float deltatime)
	{
	}

	private void fdLateUpdate(float deltatime)
	{
	}

	private void ugUpdate(float deltatime)
	{
	}

	private void ugLateUpdate(float deltatime)
	{
	}

	private void EncountUpdate(float deltatime)
	{
	}

	public void PreLoadEncEffect(string assetname)
	{
	}

	public uint GetNowBgmState()
	{
		return default(uint);
	}

	public string GetMapBgmState()
	{
		return null;
	}

	public uint CheckMapBgmState(uint id)
	{
		return default(uint);
	}

	public string GetEnvironmentalSound()
	{
		return null;
	}

	public void ResetSaveZoneBgm()
	{
	}

	public void SetCutOutFade(int index)
	{
	}

	private bool CheckEncount()
	{
		return default(bool);
	}

	private void ResultSetUpWildBattle(EncountResult result, int btlBgIndex, out PokeParty party, out int safariball)
	{
	}

	private ushort GetFormNo(MonsNo mons, int karana, int anno)
	{
		return default(ushort);
	}

	public void EventWildBattle(MonsNo mons, int level, bool isCaptureDemo = false, bool isSymbol = false, bool isMitu = false, byte talentVNum = 0, bool isCantUseBall = false, int formNo = 0, bool tokusei3rd = false)
	{
	}

	public void EventWildBattle(PokeParty pokeParty, bool isCaptureDemo = false, bool isSymbol = false, bool isMitu = false, bool isCantUseBall = false)
	{
	}

	public void EncountStart(EncountFadeType type, TrainerID trainerid1 = TrainerID.NONE, TrainerID trainerid2 = TrainerID.NONE)
	{
	}

	public bool IsEncountUpdate()
	{
		return default(bool);
	}

	private void AttributeEventEffect()
	{
	}

	private void AttributeEventSE()
	{
	}

	private void FootSE_Walk(string name, AttributeEventCallType callType, int graphicIndex, Transform tra)
	{
	}

	private void FootSE_Bic(string name)
	{
	}

	public void FootEventEffect(FieldObjectEntity entity, bool running, bool bicycle, AttributeEventCallType calltype)
	{
	}

	public void FootEventSE(FieldObjectEntity entity, bool running, bool bicycle, AttributeEventCallType calltype)
	{
	}

	public void RequestAttributeEffect(FieldObjectEntity entity, AttributeEventType attri)
	{
	}

	public void RequestAttributeSE(FieldObjectEntity entity, AttributeEventType attri)
	{
	}

	public void CallEffect(EffectFieldID index, Transform parent, Vector3 ofs, Vector3 rot, [Optional] Action<EffectInstance> loadcallback, [Optional] UnityAction<EffectInstance> eff_onFinished)
	{
	}

	public void CallEffect(EffectFieldID index, Transform parent, Vector3 ofs, [Optional] Action<EffectInstance> loadcallback, [Optional] UnityAction<EffectInstance> eff_onFinished)
	{
	}

	public void CallEffect(EffectFieldID index, Transform parent, [Optional] Action<EffectInstance> loadcallback, [Optional] UnityAction<EffectInstance> eff_onFinished)
	{
	}

	public void CallEffect(EffectFieldID index, Vector3 pos, [Optional] Action<EffectInstance> loadcallback, [Optional] UnityAction<EffectInstance> eff_onFinished)
	{
	}

	private IEnumerator PlayEffect(EffectFieldID index, Transform parent, Vector3 pos, Quaternion rot, Action<EffectInstance> loadcallback, UnityAction<EffectInstance> eff_onFinished)
	{
		return null;
	}

	private bool ControlPoketch()
	{
		return default(bool);
	}

	public void ChangePoketchLarge()
	{
	}

	public void ChangePoketchSmall()
	{
	}

	public void MenuOpen(float deltatime, bool isIgnoreGround = false)
	{
	}

	private void LateMenuOpen()
	{
	}

	private bool MenuOpenInvalidZone()
	{
		return default(bool);
	}

	private bool OpenUnionRoomWarp(bool isUnderGround)
	{
		return default(bool);
	}

	public bool IsEnableUnionRoomWarp(bool isUnderGround)
	{
		return default(bool);
	}

	private bool UseShotCut(float deltatime)
	{
		return default(bool);
	}

	private bool IsKariEyeHitCheck()
	{
		return default(bool);
	}

	private void OpenShortCut()
	{
	}

	public void StopShortCutData()
	{
	}

	public void LockHolePos(Vector3 pos)
	{
	}

	public void LockHoleEnd()
	{
	}

	public static void DebugLot(int randmark)
	{
	}

	private void SetMapInfoCameraData(bool isforce)
	{
	}

	private bool CheckWeather()
	{
		return default(bool);
	}

	private void WeatherEffectPlay()
	{
	}

	private void CheckWeatherBGM()
	{
	}

	public void SetCloudShadowBaseEnable()
	{
	}

	public void SetCloudShadowBaseDisable()
	{
	}

	private UIManager.FieldUseResult UI_onFieldWaza(UIManager.FieldWazaParam param)
	{
		return default(UIManager.FieldUseResult);
	}

	public void UI_SelectWaza(WazaNo waza)
	{
	}

	private UIManager.FieldUseResult UI_onUseFieldItem(ItemInfo item)
	{
		return default(UIManager.FieldUseResult);
	}

	private UIManager.FieldUseResult UI_onUseFieldItem(ItemNo id)
	{
		return default(UIManager.FieldUseResult);
	}

	private bool CheckAvailableFieldItem(ItemNo id)
	{
		return default(bool);
	}

	private bool CheckUseItem()
	{
		return default(bool);
	}

	private void UseFieldItem()
	{
	}

	private void UseFieldItem(ItemNo itemno)
	{
	}

	private void UI_onWazaFly(ZoneID zoneid, int locatorIndex)
	{
	}

	public bool StopSwayGrass_NextArea()
	{
		return default(bool);
	}

	private bool CheckIgnoreWeatherSweetEncount(SYS_WEATHER weather)
	{
		return default(bool);
	}

	public bool StartSweetEncount()
	{
		return default(bool);
	}

	public void SetBgmEvent(string eventName)
	{
	}

	public void SetBgmEvent(uint eventid)
	{
	}

	public void SetWwiseEvent(string eventName)
	{
	}

	private uint BGMFlagCheck(uint eventid)
	{
		return default(uint);
	}

	private bool NotSaveBgmEvent(uint eventid)
	{
		return default(bool);
	}

	public void SetWwiseEvent(uint eventid)
	{
	}

	public void UniqueBGMEvent(ZoneID nextid, ZoneID oldid)
	{
	}

	public void RidBicycle(Action onfinish)
	{
	}

	private bool FishingUpdate(float time)
	{
		return default(bool);
	}

	public void SetWazaAction(FieldWazaAction action)
	{
	}

	public void SetTownMapPos(ZoneID zoneid, ref Vector3 pos)
	{
	}

	public void GetTownMapPos(out ZoneID zoneid, out Vector3 pos, bool isForcePrevious = false)
	{
	}

	public void SetAkLisnerTransform(Transform tra)
	{
	}

	public void UpdateAkLisner()
	{
	}

	public void OnZoneChange_Subcontents()
	{
	}

	public void CreateFreaiManager()
	{
	}

	public void DeleteFreaiManager()
	{
	}

	private void GetLegendPokeEncountInfo(PokemonParam param, out string encSec, ref ArenaID arenaID, out string bgm, out BattleSetupEffectId setupEffect)
	{
	}

	private static FieldEncountTable.Sheetlegendpoke GetFieldEncountTableLegendPoke(MonsNo monsNo, ushort formNo)
	{
		return null;
	}

	public bool IsEnableSave(bool isIgnoreGround = false)
	{
		return default(bool);
	}

	public bool IsNoEntry(Vector2Int gridPos, Vector3 worldPos)
	{
		return default(bool);
	}

	public bool IsNoEntrySea(Vector2Int gridPos, Vector3 worldPos)
	{
		return default(bool);
	}

	public SYS_WEATHER GetBatleWeather()
	{
		return default(SYS_WEATHER);
	}

	public UgMainProc GetUgMainProc()
	{
		return null;
	}

	private void SaveCheckCyclingRoad()
	{
	}

	private bool CheckEnterNazonobasyo()
	{
		return default(bool);
	}

	private bool IsNazonobasyoEntrance()
	{
		return default(bool);
	}

	private bool IsNazonobasyoEntry()
	{
		return default(bool);
	}
}
