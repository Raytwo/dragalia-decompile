using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DPData;
using Dpr.Battle.Logic;
using Dpr.Item;
using Dpr.Message;
using Pml;
using Pml.PokePara;
using Pml.WazaData;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class UIManager : SingletonMonoBehaviour<UIManager>
{
	private enum InputLimitType
	{
		JPN,
		KOR,
		TCH,
		SCH,
		EFIGS,
		Num
	}

	private class MonsterBallParam
	{
		public ItemNo itemNo;

		public BallId ballId;

		public Sprite sprite;
	}

	public class SpriteAtlasParam
	{
		public SpriteAtlasID spriteAtlasId;

		public string assetBundleName;

		public string assetName;

		public string variantAssetBundleName;

		public SpriteAtlas spriteAtlas;

		public Action<SpriteAtlas> atlasCallback;

		public void Clear()
		{
		}

		public void SetSpriteAtlas(SpriteAtlas spriteAtlas_)
		{
		}

		public void SetAtlasCallback(Action<SpriteAtlas> atlasCallback_)
		{
		}

		private void Call()
		{
		}
	}

	[Flags]
	private enum InitializeStateBit
	{
		EntrySpriteAtlas = 1,
		LoadedSpriteAtlas = 2,
		EntryWindows = 4,
		LoadedWindows = 8,
		EntryAterLang = 0x10,
		LoadAterLang = 0x20,
		Loaded = 0xA
	}

	public enum FieldUseResult
	{
		Available,
		Unusable,
		Unusable_PairTrainer
	}

	public class FieldWazaParam
	{
		public WazaNo wazaNo;

		public PokemonParam pokemon;

		public PokemonParam targetPokemon;
	}

	public class UIInstance : IObjectPoolInstance
	{
		private UIWindow _uiWindow;

		private UIWindowID _windowId;

		public UIWindow uiWindow => null;

		public UIWindowID windowId
		{
			get
			{
				return default(UIWindowID);
			}
			set
			{
			}
		}

		void IObjectPoolInstance.SetGameObject(GameObject obj)
		{
		}

		GameObject IObjectPoolInstance.GetGameObject()
		{
			return null;
		}

		void IObjectPoolInstance.OnCreate()
		{
		}

		void IObjectPoolInstance.OnRelease()
		{
		}
	}

	private class TransitionInstance : IObjectPoolInstance
	{
		public UITransition transition;

		public TransitionID transitionId;

		void IObjectPoolInstance.SetGameObject(GameObject obj)
		{
		}

		GameObject IObjectPoolInstance.GetGameObject()
		{
			return null;
		}

		void IObjectPoolInstance.OnCreate()
		{
		}

		void IObjectPoolInstance.OnRelease()
		{
		}
	}

	private class CacheSpritePokemonParam
	{
		public int uniqueId;

		public Sprite sprite;

		public void Destroy()
		{
		}
	}

	private class BlugBgParam
	{
		public enum FadeType
		{
			In,
			Out
		}

		public FadeType fadeType;

		public float srcAlpha;

		public float destAlpha;

		public float time;

		public float maxTime;

		public UnityAction onComplete;

		public bool isCapture;

		public RenderTexture captureBlurTexture;

		public Texture2D blankTexture;
	}

	public class EnvironmentControllerSaver
	{
		public bool isSaved;

		public bool actived;

		public bool enabled;

		public void Save(bool isReset = false)
		{
		}

		public void Restore()
		{
		}
	}

	private struct AtlasSpriteKey
	{
		public SpriteAtlasID spriteAtlasId;

		public string name;
	}

	private class ComparerPokemonIcon : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class ComparerAshiatoIcon : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class ComparerZukanDisplay : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class ComparerPokemonVoice : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class ComparerZukanCompareHeight : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class LangParam
	{
		public MessageEnumData.MsgLangId langId;

		public string label;

		public string[] ietfTags;
	}

	private class PokemonParamMapping
	{
		public BTL_POKEPARAM battlePokemonParam;

		public PokemonParam pokemonParam;

		public bool isFriend;
	}

	public class DuplicateImageMaterialParam
	{
		public Image image;

		public Material material;
	}

	private class ComparerTownMapGuide : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	private class ComparerPlaceName : IComparer
	{
		public int Compare(object x, object y)
		{
			return default(int);
		}
	}

	[SerializeField]
	private Transform _activeRoot;

	[SerializeField]
	private UIModelViewController _modelView;

	[SerializeField]
	private Transform _blurBgRoot;

	public static int StickLLeft;

	public static int StickLRight;

	public static int StickLUp;

	public static int StickLDown;

	public static int ButtonA;

	public static int ButtonB;

	public static int ButtonX;

	public static int ButtonY;

	public static int ButtonPlusMinus;

	private const int _sortingOrderWindow = 100;

	private const int _sortingOrderWindowAdd = 100;

	private const int _sortingOrderTransition = 10000;

	private const string _hpBarSpriteName = "cmn_pl_txt_hpbar_01";

	private UIDatabase _mdUis;

	private TownMapGuideTable _mdTownmapGuide;

	private TownMapTable _mdTownmap;

	private DistributionTable _mdDistribution;

	private PlaceNameTable _mdPlaceName;

	private InputLimitTable _mdInputLimit;

	private HashSet<int>[] _inputLimitHashSets;

	private SearchIndexData _mdSearchIndexData;

	private Dictionary<BallId, MonsterBallParam> _spriteMonsterBallDict;

	private Sprite _spriteMonsterBallStrange;

	private List<SpriteAtlasParam> _spriteAtlasParams;

	private Keyguide _keyguide;

	private int _InitializeStateBits;

	private UnityAction<UIWindow> onXMenuClosed;

	private bool _fureaiLimit;

	public static UnityAction<ZoneID, int> onWazaFly;

	public static UnityAction<int> onDressChanged;

	public static Func<FieldWazaParam, FieldUseResult> onFieldWaza;

	public static Func<ItemInfo, FieldUseResult> onUseFieldItem;

	public static Action<int, int, ItemInfo> onUseItemInBattle;

	public static Action<FieldPoketch.HidenWazaType> onUseHidenWaza;

	public static Func<Vector2, FieldPoketch.DowsingResult> onUseDowsing;

	private ObjectPool<UIWindowID, UIInstance> _objectPool;

	private ObjectPool<TransitionID, TransitionInstance> _objectPoolTransition;

	private List<TransitionInstance> _transitionInstances;

	private TransitionID _transitionId;

	private CacheList<CacheSpritePokemonParam> _cacheSpritePokemons;

	private RawImage _blurBg;

	private BlugBgParam _blurBgParam;

	private float _debugInstrument;

	private string[] _databaseAssetBundleNames;

	private bool _isLoadedDatabase;

	private Dictionary<AtlasSpriteKey, Sprite> _atlasSpriteDict;

	private string _assetPathIndexdata;

	private XMenuTop _xMenu;

	private static ComparerPokemonIcon _comparerPokemonIcon;

	private static ComparerAshiatoIcon _comparerAshiatoIcon;

	private static ComparerZukanDisplay _comparerZukanDisplay;

	private static ComparerPokemonVoice _comparerPokemonVoice;

	private static ComparerZukanCompareHeight _comparerZukanCompareHeight;

	private static readonly LangParam[] _langParams;

	private static List<PokemonParamMapping> _pokemonParamMappings;

	private static int _id_GrayscaleAmount;

	private static ComparerTownMapGuide _comparerTownMapGuide;

	private static ComparerPlaceName _comparerPlaceName;

	private NowloadingController _nowLoadingController;

	private NowLoading _nowLoading;

	public static bool isInitialized => default(bool);

	public TransitionID transitionId => default(TransitionID);

	public RectTransform modelBgRoot => null;

	public UIDatabase database => null;

	public TownMapGuideTable townMapGuideTable => null;

	public TownMapTable townMapTable => null;

	public DistributionTable distributionTable => null;

	public PlaceNameTable placeNameTable => null;

	public InputLimitTable inputLimitTable => null;

	public bool IsResidentSpriteAtlases => default(bool);

	public UIModelViewController modelView => null;

	public SearchIndexData searchIndexData => null;

	public bool isLoadedDatabase => default(bool);

	protected override bool Awake()
	{
		return default(bool);
	}

	public void RegisterOnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Destroy()
	{
	}

	public IEnumerator Start()
	{
		return null;
	}

	public void LoadResidents()
	{
	}

	public void LoadWindows(bool isOpening)
	{
	}

	public void Reload(MessageEnumData.MsgLangId unloadLangId, UnityAction onComplete)
	{
	}

	private IEnumerator OpReload(MessageEnumData.MsgLangId unloadLangId, UnityAction onComplete, [Optional] UnityAction onUnloadComplete)
	{
		return null;
	}

	private void BeginDebugInstrument()
	{
	}

	private void DebugInstrument(string label)
	{
	}

	private IEnumerator OpLoad(int type, bool isOpening = false)
	{
		return null;
	}

	private IEnumerator DoParallel()
	{
		return null;
	}

	public void LoadDatabase()
	{
	}

	private IEnumerator OpLoadDatabase()
	{
		return null;
	}

	private void UnloadDatabase()
	{
	}

	private void CreateInputLimitHashSet(InputLimitType type, SheetInputLimitTable[] inputLimitDatas)
	{
	}

	private void UnloadResidentSpriteAtlases(bool isVariant, MessageEnumData.MsgLangId langId = (MessageEnumData.MsgLangId)(-1))
	{
	}

	private IEnumerator OpLoadResidentSpriteAtlases(bool isVariant)
	{
		return null;
	}

	private IEnumerator OpLoadSpriteAtlases(List<SpriteAtlasID> spriteAtlasIds, bool isVariant)
	{
		return null;
	}

	private int FindSpriteAtlasIndex(string assetName)
	{
		return default(int);
	}

	public void UnloadSpriteAtlases(List<SpriteAtlasID> spriteAtlasIds, bool isVariant, MessageEnumData.MsgLangId langId)
	{
	}

	private void OnAtlasRequested(string name, Action<SpriteAtlas> atlasCallback)
	{
	}

	private IEnumerator OpWaitDatabase(string name, Action<SpriteAtlas> atlasCallback)
	{
		return null;
	}

	public SpriteAtlas GetSpriteAtlas(SpriteAtlasID spriteAtlasId)
	{
		return null;
	}

	public Sprite GetAtlasSprite(SpriteAtlasID spriteAtlasId, string name)
	{
		return null;
	}

	public void ClearCachedSprites()
	{
	}

	public void ClearAtlasSprites()
	{
	}

	public void ClearAtlasSprite(SpriteAtlasID spriteAtlasId)
	{
	}

	private void SetupSpriteMonsterBall()
	{
	}

	public IEnumerator LoadSearchIndexData()
	{
		return null;
	}

	private void UnloadSearchIndexData(MessageEnumData.MsgLangId langId)
	{
	}

	public void InitializeAfterLangDecide([Optional] UnityAction onComplete)
	{
	}

	public IEnumerator OpInitializeAfterLangDecide([Optional] UnityAction onComplete)
	{
		return null;
	}

	public static bool IsMaleDress(CharacterDressData.SheetData dressData)
	{
		return default(bool);
	}

	public void PlayTransition(TransitionID transitionId, UITransition.FadeType fadeType, [Optional] UnityAction<UITransition.FadeType> onComplete)
	{
	}

	private IEnumerator OpLoadResidentWindows(bool isCheckFirstLoad = false)
	{
		return null;
	}

	private void UnloadResidentWindows(bool isCheckFirstLoad)
	{
	}

	private void UnloadWindows(List<UIWindowID> windowIds)
	{
	}

	public IEnumerator OpLoadWindows(List<UIWindowID> windowIds, bool isVariant = true)
	{
		return null;
	}

	private int UnloadAssetBundle(string assetBundleName, bool isVariant, MessageEnumData.MsgLangId langId = (MessageEnumData.MsgLangId)(-1))
	{
		return default(int);
	}

	private int FindWindowDataIndex(string assetName)
	{
		return default(int);
	}

	public void UnloadWindows(List<UIWindowID> windowIds, bool isVariant = false)
	{
	}

	public T CreateUIWindow<T>(UIWindowID windowId) where T : UIWindow
	{
		return null;
	}

	public void SetupSortOrder(UIWindow uiwindow)
	{
	}

	public T GetCurrentUIWindow<T>() where T : UIWindow
	{
		return null;
	}

	public UIWindow GetUIWindowByIndex(int index)
	{
		return null;
	}

	public int GetUIWindowCount()
	{
		return default(int);
	}

	public T GetExistWindow<T>() where T : UIWindow
	{
		return null;
	}

	internal void _ReleaseUIWindow(UIWindow window)
	{
	}

	internal void _SetupKeyAssign(INPUTMODE inputMode)
	{
	}

	private void LateUpdate()
	{
	}

	public Sprite GetSharedSprite(SharedSpriteID sharedSpriteId)
	{
		return null;
	}

	public Sprite GetSpritePokemonSex(Sex sex)
	{
		return null;
	}

	public UIDatabase.SheetPokemonIcon GetPokemonIconData(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return null;
	}

	public UIDatabase.SheetAshiatoIcon GetAshiatoIconData(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return null;
	}

	public UIDatabase.SheetZukanDisplay GetZukanDisplayData(PokemonParam pokemonParam)
	{
		return null;
	}

	public UIDatabase.SheetZukanDisplay GetZukanDisplayData(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return null;
	}

	public UIDatabase.SheetPokemonVoice GetPokemonVoiceData(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return null;
	}

	public UIDatabase.SheetPokemonVoice GetPokemonVoiceData(int uniqueId)
	{
		return null;
	}

	public UIDatabase.SheetZukanComparePlayer GetZukanComparePlayerData(bool playerSex)
	{
		return null;
	}

	public UIDatabase.SheetZukanCompareHeight GetZukanCompareHeightData(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return null;
	}

	public UIDatabase.SheetZukanCompareWeight GetZukanCompareWeightData(int diffWeight)
	{
		return null;
	}

	public UIDatabase.SheetZukanRating GetZukanRatingData(bool isZenkokuZukan)
	{
		return null;
	}

	public static string GetPokemonAssetbundleName(int uniqueId)
	{
		return null;
	}

	public UIDatabase.SheetContextMenu GetContextMenuData(ContextMenuID contextMenuId)
	{
		return null;
	}

	public static (string, string) GetLanguageMessage(uint langId)
	{
		return default((string, string));
	}

	public static string GetCurrentIetfCode()
	{
		return null;
	}

	public static MessageEnumData.MsgLangId GetMessageLangIdFromIetfCode(string ietfCode)
	{
		return default(MessageEnumData.MsgLangId);
	}

	public Sprite GetSpriteMonsterBall(BallId ballId)
	{
		return null;
	}

	public static uint GetParentId(PokemonParam pokemonParam)
	{
		return default(uint);
	}

	public Sprite GetSpritePokemonType(int typeNo)
	{
		return null;
	}

	public Sprite GetSpritePokemonTypeZukan(int typeNo, MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public Sprite GetSpritePokemonLanguage(MessageEnumData.MsgLangId langId)
	{
		return null;
	}

	public Sprite GetSpritePlaceMark(uint cassetVersion)
	{
		return null;
	}

	public Sprite GetSpriteWazaDamageType(WazaDamageType wazaDamageType)
	{
		return null;
	}

	public Sprite GetHpBgSprite()
	{
		return null;
	}

	public Color32 GetMarkColor(int type)
	{
		return default(Color32);
	}

	public Color32 GetPokeColor(int type)
	{
		return default(Color32);
	}

	public UIDatabase.SheetWallpaper GetWallPaper(int type)
	{
		return null;
	}

	public int GetWallPaperMax()
	{
		return default(int);
	}

	public int GetSearchPokeIconSex(MonsNo monsNo)
	{
		return default(int);
	}

	public UIDatabase.SheetBox GetBoxData(int no)
	{
		return null;
	}

	public UIDatabase.SheetBoxOpenParam GetBoxOpenData(int type)
	{
		return null;
	}

	public bool IsDisplayWazaString(string wazaMessageID)
	{
		return default(bool);
	}

	public bool IsDisplayTokuseiString(string tokuseiMessageID)
	{
		return default(bool);
	}

	public Keyguide GetKeyguide(bool isCreate = true)
	{
		return null;
	}

	internal void _ClearKeyguide()
	{
	}

	public UIDatabase.SheetKeyguide GetKeyguideData(KeyguideID keyguideId)
	{
		return null;
	}

	public void ReleaseKeyguide()
	{
	}

	public static Taste GetLikeTaste(PokemonParam pokemonParam)
	{
		return default(Taste);
	}

	public static BTL_POKEPARAM ToBattlePokemonParam(PokemonParam pokemonParam)
	{
		return null;
	}

	public static PokemonParam ToPokemonParam(BTL_POKEPARAM battlePokemonParam)
	{
		return null;
	}

	public static PokemonParam ToPokemonParamBySrcData(PokemonParam pokemonParam)
	{
		return null;
	}

	public static bool IsMyParty(PokemonParam pokemonParam)
	{
		return default(bool);
	}

	public static int GetFriendPartyFirstIndex()
	{
		return default(int);
	}

	public static BTL_PARTY GetMultiPlayerFriendParty()
	{
		return null;
	}

	public static List<PokemonParam> CreatePokemonParamsByBattle()
	{
		return null;
	}

	public static PokemonParam CreatePokemonParamByBattle(BTL_POKEPARAM battlePokemonParam)
	{
		return null;
	}

	public static PokemonParam GetTeamPokemon(int team, int pos)
	{
		return null;
	}

	public static bool TryGetTeamPokemonTrayIndex(int team, int pos, out int tray, out int index)
	{
		return default(bool);
	}

	public static bool IsFieldWaza(WazaNo wazaNo)
	{
		return default(bool);
	}

	public static void ReturnItemInBag(PokemonParam pokemonParam)
	{
	}

	public void LoadSpritePokemon(PokemonParam pokemonParam, UnityAction<Sprite> onComplete)
	{
	}

	public Sprite LoadSpritePokemonDirect(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg)
	{
		return null;
	}

	public void LoadSpritePokemon(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg, UnityAction<Sprite> onComplete)
	{
	}

	public void LoadSpritePokemonLarge(PokemonParam pokemonParam, UnityAction<Sprite> onComplete)
	{
	}

	public void LoadSpritePokemonLarge(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg, UnityAction<Sprite> onComplete)
	{
	}

	public void LoadSpritePokemonDot(PokemonParam pokemonParam, UnityAction<Sprite> onComplete)
	{
	}

	public void LoadSpritePokemonDot(MonsNo monsNo, ushort formNo, Sex sex, RareType rareType, bool isEgg, UnityAction<Sprite> onComplete)
	{
	}

	public void LoadSpriteItem(ItemNo itemNo, UnityAction<Sprite> onComplete)
	{
	}

	public static int Repeat(int value, int start, int end)
	{
		return default(int);
	}

	public static void ScreenScaled(ref Vector2 v)
	{
	}

	public static Vector2 ComputeLocalCornerPosition(RectTransform rectTrans, int cornerIndex, [Optional] RectTransform baseRectTrans, [Optional] Camera canvasCamera)
	{
		return default(Vector2);
	}

	public static List<DuplicateImageMaterialParam> DuplicateImageMaterials(Transform trans)
	{
		return null;
	}

	public static void RestoreDuplicateImageMaterials(List<DuplicateImageMaterialParam> duplicateImageMaterialParams)
	{
	}

	public static void DestroyCanvasRendererMaterials(GameObject gameObj)
	{
	}

	public void Grayscale(Transform trans, float value)
	{
	}

	public void SetOnCloseXMenu(UnityAction<UIWindow> onClosed_)
	{
	}

	public void CloseXMenu(UnityAction<UnityAction<UIWindow>> onCall)
	{
	}

	public TownMapGuideTable.SheetGuide SetupCurrentTownmapGuideMessage()
	{
		return null;
	}

	public TownMapGuideTable.SheetGuide GetCurrentTownmapGuideData()
	{
		return null;
	}

	public TownMapGuideTable.SheetGuide GetTownmapGuideData(int guideId)
	{
		return null;
	}

	public PlaceNameTable.SheetDprPlaceName GetPlaceNameData(ZoneID zoneId)
	{
		return null;
	}

	public PlaceNameTable.SheetDprPlaceName GetPlaceNameData(int placeId)
	{
		return null;
	}

	public UIDatabase.SheetCharacterBag GetPlayerCharacterBagData()
	{
		return null;
	}

	public UIDatabase.SheetCharacterBag GetCharacterBagData(int characterDressId)
	{
		return null;
	}

	public void RegisterNowloading(NowloadingController nowloding)
	{
	}

	public void NowLoadingOpen(float waitTime = 5f, int sortOrder = 16390)
	{
	}

	public void NowLoadingClose()
	{
	}

	public void UseDSPlayerItem()
	{
	}

	public void FadeinBlurBg(float time = 0.5f, [Optional] UnityAction onComplete)
	{
	}

	public void FadeoutBlurBg(float time = 0.5f, [Optional] UnityAction onComplete)
	{
	}

	public bool IsActiveFadeBlur()
	{
		return default(bool);
	}

	public void SetActiveFadeBlur(bool enabled)
	{
	}

	internal void _CaptureBlueImage(bool enabled)
	{
	}

	private void UpdateBlurBg()
	{
	}

	public static float FrameCountToSeconds(int frameCount)
	{
		return default(float);
	}

	public SheetDistributionTable[] GetDistributionDatas(bool isField = true)
	{
		return null;
	}

	public static bool IsUnion()
	{
		return default(bool);
	}

	public HashSet<int> GetInputLimitHashSet(MessageEnumData.MsgLangId langId = (MessageEnumData.MsgLangId)(-1))
	{
		return null;
	}

	public static int GetDigit(int num)
	{
		return default(int);
	}

	public static AsyncOperation UnloadUnusedAssets(bool isGcCollect = false)
	{
		return null;
	}

	public void EnableFureaiLimit(bool enabled)
	{
	}

	public bool IsFureaiLimit()
	{
		return default(bool);
	}

	public static bool IsFureaiHiroba()
	{
		return default(bool);
	}

	private static long GetUsedMemorySize()
	{
		return default(long);
	}

	private static long GetUnusedMemorySize()
	{
		return default(long);
	}

	public static bool IsLumpingRibbon(int ribbonNo)
	{
		return default(bool);
	}

	public static int GetLumpingRibbonMaxNum(int ribbonNo)
	{
		return default(int);
	}

	public Sprite GetSpriteRibbon(PokemonParam pokemonParam, int ribbonNo)
	{
		return null;
	}

	public static string ToBinaryString(int val)
	{
		return null;
	}

	public static bool IsLeanFly()
	{
		return default(bool);
	}

	public static int Fps()
	{
		return default(int);
	}

	public static MessageEnumData.MsgLangId GetCurrentLangId()
	{
		return default(MessageEnumData.MsgLangId);
	}
}
