using System.Collections;
using System.Collections.Generic;
using Audio;
using Dpr.Battle.View.Systems;
using Effect;
using ScriptableObjectFormat;
using SmartPoint.AssetAssistant;
using SmartPoint.Components;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

public class Viewer : MonoBehaviour
{
	public class PokemonInfo
	{
		public static readonly string[] Locations;

		public static readonly RangeInt[] LocationRanges;

		public int index;

		public int currentVariation;

		public bool shinyColor;

		public int petrify;

		public List<PokemonData.ModelData> variations;

		public static int GetLocation(int index)
		{
			return default(int);
		}

		public string[] GetVariationNames()
		{
			return null;
		}
	}

	[SerializeField]
	private PokemonData _pokemonData;

	[SerializeField]
	private CharacterTable _characterData;

	[SerializeField]
	private EffectTable _effectData;

	[SerializeField]
	private AudioTable _audioData;

	[SerializeField]
	private TextMeshProUGUI _selectedObjectLabel;

	[SerializeField]
	private EnvironmentSettings _renderSettings;

	[SerializeField]
	private SkyColorSettings _skyColorSettings;

	[SerializeField]
	private Camera _screenEffectCamera;

	[SerializeField]
	private PetrifyData petrifyData;

	[SerializeField]
	private Shader petrifyShader;

	[SerializeField]
	private Shader petrifyFireShader;

	[SerializeField]
	private Shader petrifySmokeShader;

	[SerializeField]
	private Texture2D _fieldCloudTex;

	[SerializeField]
	private Texture2D _battleCloudTex;

	private MapInfo _mapInfo;

	private ArenaInfo _arenaInfo;

	private StatueEffectRawData _statueData;

	private DebugMenu.MenuInstance _rootMenu;

	private DebugMenu.MenuInstance _fieldPokemonMenu;

	private DebugMenu.MenuInstance _battlePokemonMenu;

	private DebugMenu.MenuInstance _instanceMenu;

	private DebugMenu.MenuInstance _animationMenu;

	private DebugMenu.MenuInstance _settingMenu;

	private List<PokemonInfo> _pokemonInfos;

	private Dictionary<GameObject, LayoutScrollView.Cell> _instancePlayableLookup;

	private Dictionary<GameObject, LayoutScrollView.Cell> _instanceSettingLookup;

	private LayoutScrollView.Cell _effectMenuAdd;

	private LayoutScrollView.Cell _effectMenuBoot;

	private string _savedInputAxisH;

	private string _savedInputAxisV;

	private int _currentPokemonIndex;

	private int _currentStatueIndex;

	private int _theaterTrackIndex;

	private GameObject _bgPrefab;

	private Coroutine _loadingCoroutine;

	private SimpleCamera _simpleCamera;

	private Camera _camera;

	private BtlvWeather _weather;

	private List<EffectInstance> _effecctInstances;

	private DebugMenu.MenuInstance _effectStopMenu;

	private List<AudioInstance> _seInstances;

	private DebugMenu.MenuInstance _seStopMenu;

	private Dictionary<string, DebugMenu.MenuInstance> _audioGroupDict;

	private Mesh _boxMesh;

	private Material _boxMat;

	[SceneBeforeActivateOperationMethod]
	private IEnumerator OnInitialize(Transform cluster)
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Awake()
	{
	}

	private void SetTimeZone(int index)
	{
	}

	private void SetWeather(BtlvWeather weather)
	{
	}

	private IEnumerator Start()
	{
		return null;
	}

	private void CreateLoadMenu(DebugMenu.MenuInstance parentMenu)
	{
	}

	private void CreateSelectionMenu(DebugMenu.MenuInstance parentMenu)
	{
	}

	private void CreateCameraMenu(DebugMenu.MenuInstance parentMenu)
	{
	}

	private void CreateEffectMenu(DebugMenu.MenuInstance parentMenu)
	{
	}

	private void SetupEffectStopMenu()
	{
	}

	private void AddEffectStopInstance(EffectInstance effectInstance)
	{
	}

	private void CreateAudioMenu(DebugMenu.MenuInstance parentMenu)
	{
	}

	private void PlaySe(uint playEventId, uint stopEventId)
	{
	}

	private void PlayVoice(uint playEventId, uint stopEventId)
	{
	}

	private void SetupAudioStopMenu()
	{
	}

	private void AddAudioStopInstance(AudioInstance audioInstance)
	{
	}

	private void AddInstanceItem(string label, GameObject instance)
	{
	}

	private void OnRequestCharacter(object reference)
	{
	}

	private void OnSelectModel(object reference)
	{
	}

	private void OnSelectModel(object reference, bool fit)
	{
	}

	private bool HasPokemonInstance()
	{
		return default(bool);
	}

	private void ClearInstanceItems()
	{
	}

	private void OnRemoveModel(object reference)
	{
	}

	private void OnRequestField(object reference)
	{
	}

	private IEnumerator LoadFieldOperation(MapInfo.SheetZoneData zoneData)
	{
		return null;
	}

	private IEnumerator LoadArenaOperation(ArenaInfo.SheetArenaData arenaData)
	{
		return null;
	}

	private void OnSelectPokemonChanged(int index, int category)
	{
	}

	private void OnSelectVariationChanged(int index, int category)
	{
	}

	private void OnShinyColorChanged(int selected, int category)
	{
	}

	private void OnRequestFieldPokemon(object reference)
	{
	}

	private void OnRequestBattlePokemon(object reference)
	{
	}

	private void OnRequestPokemon(int category)
	{
	}

	private void OnRequestStatue(object reference)
	{
	}

	private void CreateBoxMesh()
	{
	}

	private void DrawBox()
	{
	}

	private IEnumerator AssetBundleLoadingOperation(string assetBundleName, UnityAction<Object> callback)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetCell(GameObject instance)
	{
	}

	private void OnDestroy()
	{
	}
}
