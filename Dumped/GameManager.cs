using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.Message;
using Pml;
using ScriptableObjectFormat;
using SmartPoint.AssetAssistant;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

[ExecuteAlways]
public class GameManager : SingletonMonoBehaviour<GameManager>
{
	public enum AfterInitType
	{
		LanguageSelect,
		BackupLoad
	}

	public enum AfterLoadState
	{
		None,
		Msbt,
		Ui,
		Ui2
	}

	public enum AterInitializeType
	{
		Language,
		Backup
	}

	public const long ticksPerDay = 864000000000L;

	public const long ticksPerSecond = 10000000L;

	[SerializeField]
	private Transform _fieldObjectHolder;

	[SerializeField]
	private Transform _battleObjectHolder;

	[SerializeField]
	private GameObject _licenseTextObject;

	[SerializeField]
	private GameObject _errorTextObject;

	[SerializeField]
	private TextMeshProUGUI _officeTextUGUI;

	[SerializeField]
	private TextMeshProUGUI _userTextUGUI;

	[SerializeField]
	private string _securityFileName;

	[SerializeField]
	private string _primarySecurityKey;

	[SerializeField]
	private string _secondarySecurityKey;

	[SerializeField]
	private PokemonData _debugPokemonData;

	private GameSettings gameSettings;

	public static SceneConnector connector;

	private static DateTime _nowTime;

	private AreaID _cacheAreaID;

	private SceneID _targetSceneID;

	private Coroutine _loadingOperation;

	private bool _switchingNow;

	public static FieldCamera fieldCamera;

	public static bool isControllable;

	public static bool useSubAttribute;

	public static Transform fieldObjectHolder => null;

	public static Transform battleObjectHolder => null;

	public static bool isReady
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

	public static MapInfo mapInfo => null;

	public static ArenaInfo arenaInfo => null;

	public static CalenderEncTable calenderEncTable => null;

	public static FieldEncountTable fieldEncountTable => null;

	public static WaterSettings waterSettings => null;

	public static bool afterStarting
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

	public static bool playEnding
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

	public static DateTime nowTime
	{
		get
		{
			return default(DateTime);
		}
		set
		{
		}
	}

	public static long tickOffset
	{
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static long timeScale
	{
		[CompilerGenerated]
		get
		{
			return default(long);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static bool pause
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

	public static float elapsedTimeOfDay => default(float);

	public static PeriodOfDay currentPeriodOfDay => default(PeriodOfDay);

	public static (PeriodOfDay, float, float) currentPeriodOfDayEx => default((PeriodOfDay, float, float));

	public static PokemonData debugPokemonData => null;

	public static FieldEncountTable.Sheettable GetFieldEncountData(ZoneID zoneid)
	{
		return null;
	}

	public static FieldEncountTable.Sheethoneytree[] GetHoneyTreeEncountLotteryTable()
	{
		return null;
	}

	public static FieldEncountTable.Sheetmistu[] GetHoneyTreeEncountTable()
	{
		return null;
	}

	public static MonsNo GetSafariMonsNo(int index)
	{
		return default(MonsNo);
	}

	public static MonsNo GetUrayamaMonsNo(int index)
	{
		return default(MonsNo);
	}

	[AssetAssistantInitializeMethod(0)]
	private static void Initialize()
	{
	}

	private static IEnumerator OnetimeInitializeOperation()
	{
		return null;
	}

	public static void ReloadLanguege(MessageEnumData.MsgLangId unloadLangId, UnityAction<bool> onLoaded)
	{
	}

	public static void AfterInitialize(AfterInitType type, MessageEnumData.MsgLangId unloadLangId, UnityAction<AfterLoadState> onLoaded)
	{
	}

	private static void CheckDebugPause(float deltaTime)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private IEnumerator SceneSwitchingOperation()
	{
		return null;
	}

	private void UpdateTargetScene()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	public static AttributeMatrix GetMapAttributeMattrix()
	{
		return null;
	}

	public static AttributeMatrix GetMapAttributeExMattrix()
	{
		return null;
	}

	public static void GetAttribute(Vector2Int grid, out int code, out int stop, bool debugdraw = false)
	{
	}

	public static MapAttributeTable.SheetData GetAttributeTable(int code)
	{
		return null;
	}

	public static void GetAttribute(AttributeMatrix attributes, Vector2Int grid, out int code, out int stop, bool debugdraw = false)
	{
	}

	public static MapAttributeExTable.SheetData GetAttributeEx(Vector2Int grid, float height, bool debugdraw = false)
	{
		return null;
	}

	public static int GetAttributeExCodeRaw(Vector2Int grid)
	{
		return default(int);
	}

	public static bool IsHighAttribute(int attriRaw, float height)
	{
		return default(bool);
	}

	public static int HeightAttribute(int attri, float height)
	{
		return default(int);
	}

	public static ZoneID GetGridZoneID(Vector2Int pos)
	{
		return default(ZoneID);
	}

	private static void SetAssetBundleMemory()
	{
	}

	public static bool CPU_BOOST_ON()
	{
		return default(bool);
	}

	public static bool CPU_BOOST_OFF()
	{
		return default(bool);
	}
}
