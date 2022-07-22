using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DG.Tweening;
using Dpr.Message;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Effect;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class BoxWindow : UIWindow
{
	private enum ControlType
	{
		SelectPoke,
		SelectBox,
		SetMark,
		SelectWallPaper,
		SelectSearch,
		SelectSearchSub
	}

	public enum OperationType
	{
		Default,
		Useful,
		Range,
		Num
	}

	public enum DisplayMode
	{
		Arrangement,
		Item,
		Battle,
		Num
	}

	public enum CursorPattern
	{
		Normal,
		Hold,
		Num
	}

	public class OpenParam
	{
		public DisplayMode dispMode;

		public int tray;

		public int index;

		public int teamIndex;

		public bool isSelectParty;

		public OpenType openType;

		public int selectCount;

		public int targetLevel;

		public bool isEnableDying;

		public bool isEnableEgg;

		public bool isEnableTeam;

		public bool isEnableParty;

		public bool isShowSelectCount;

		public bool isEnableKeyboard;

		public bool isOpenFromBattleTeam;

		public bool isDisableUseful;

		public int[] targetsPokeNo;

		public string tradeName;

		public List<SelectedPokemon> selected;

		public SEARCH_DATA searchData;
	}

	public class TradeParam
	{
		public int selectIndex;

		public Action<BoxWindow, SelectedPokemon[]> onSelected;

		public Action<BoxWindow> onDecide;

		public Action<BoxWindow> onConfirm;

		public Action<BoxWindow> onComplete;

		public Action<BoxWindow> onCancelSelect;

		public PokemonParam otherOriginalParam;

		public PokemonParam otherPokeParam;

		public NetTradePhase tradePhase;

		public string messageId;

		public MessageEnumData.MsgLangId langId;

		public ErrorCodeID errorId;
	}

	public enum OpenType
	{
		Normal,
		External,
		TradeNPC,
		TradeNetwork
	}

	public enum NetTradePhase
	{
		None,
		WaitSave,
		PlayerSelecting,
		WaitSend,
		OtherPokeConfirm,
		WaitOtherDecide,
		LastConfirm,
		WaitTrading,
		Complete,
		WaitClose,
		CancelOther,
		Error
	}

	public class SelectedPokemon
	{
		public PokemonParam Param;

		public int TrayIndex;

		public int IndexInTray;
	}

	public class NaviParam
	{
		public enum ItemType
		{
			Party,
			Tray,
			Box
		}

		public ItemType itemType;

		public int index;
	}

	private enum MultiNaviType
	{
		BoxSelect,
		UnitLook,
		UnitSearch,
		BoxLook,
		BoxSearch
	}

	public enum StatusType
	{
		None,
		Status,
		Judge
	}

	public enum SearchType
	{
		Pokemon = 0,
		Type1 = 1,
		Type2 = 2,
		Waza = 3,
		Machine = 4,
		Tokusei = 5,
		Personality = 6,
		Sex = 7,
		Item = 8,
		Mark = 9,
		Team = 10,
		None = 11,
		MAX = 11
	}

	public enum SearchItem
	{
		YES = 0,
		NO = 1,
		MAX = 2,
		NONE = 2
	}

	public class SEARCH_DATA
	{
		public MonsNo mons;

		public PokeType type1;

		public PokeType type2;

		public WazaNo waza;

		public int waza_machine;

		public TokuseiNo tokusei;

		public Seikaku seikaku;

		public Sex sex;

		public SearchItem item;

		public int mark;

		public int team;

		public int form;

		public bool is_active;

		public void Clear()
		{
		}

		public void SetActive()
		{
		}
	}

	public class SearchItemData
	{
		public string Label;

		public Sprite MarkSprite;

		public bool IsEnable;

		public SearchItemData(string label, [Optional] Sprite sprite)
		{
		}
	}

	private static string[] _operationLabels;

	private static string[] _displayModeLabels;

	public static readonly List<(SearchType, string, string, string, string)> SearchMsgData;

	public const string BoxMsgFileName = "ss_box";

	public const string BoxNameFileName = "ss_boxname";

	public const string BoxSearchFileName = "ss_initial";

	public const string BoxMsgSearchBlank = "SS_box_583";

	public const string BoxMsgSearchItemBase = "SS_initial_";

	public const string BoxMsgDescriptionDefault = "SS_box_104";

	private const string _boxTitleNameBase = "box_bt_box_01_body_";

	private const string _boxBgNameBase = "box_pl_box_01_";

	public const int PartyMemberNum = 6;

	public const int TrayCellWidth = 6;

	public const int TrayCellHeight = 5;

	public const float PanelDuration = 0.2f;

	public const Ease PanelEase = Ease.OutSine;

	private const float _pokeIconDuration = 0.2f;

	private const float _modelApplyDuration = 0.7f;

	private const int _cursorSortOrderAddValue = 80;

	private const float _cursorOffsetX = 4f;

	private const float _cursorPartyOffsetX = -90f;

	private const float _cursorOffsetY = 32f;

	private const float _cursorHoldOffsetY = 42f;

	private const float NetTradeOutTime = 7f;

	private const int LocalTradeOpenID = 15;

	public const float PokeIconSelectAlpha = 0.5f;

	public static readonly Color32 DisableIconColor;

	public static readonly Color32 EnableIconColor;

	[SerializeField]
	private Image _displayTitle;

	[SerializeField]
	private UIText _displayModeText;

	[SerializeField]
	private Image _operationTitle;

	[SerializeField]
	private UIText _operationTypeText;

	[SerializeField]
	private Color32[] _operationTypeColors;

	[SerializeField]
	private RectTransform _partyTrayRoot;

	[SerializeField]
	private CanvasGroup _partyTrayCanvasGroup;

	[SerializeField]
	protected Image[] _partyArrows;

	[SerializeField]
	private BoxParty _partyNormal;

	[SerializeField]
	private BoxInfinityScroll _battleTeamScroll;

	[SerializeField]
	private RectTransform _boxTrayRoot;

	[SerializeField]
	private CanvasGroup _boxTrayCanvasGroup;

	[SerializeField]
	protected Image[] _trayArrows;

	[SerializeField]
	private BoxInfinityScroll _trayScroll;

	[SerializeField]
	private RectTransform _naviPartyRoot;

	[SerializeField]
	private RectTransform _naviTrayRoot;

	[SerializeField]
	private BoxMultiNavigator[] _multiNavis;

	[SerializeField]
	private UINavigator _naviPartySelect;

	[SerializeField]
	private UIText[] _leftButtonTexts;

	[SerializeField]
	private Image _searchButtunImage;

	[SerializeField]
	private Image _searchIconImage;

	[SerializeField]
	private Image _boxButtunImage;

	[SerializeField]
	private Image _boxIconImage;

	[SerializeField]
	private BoxListPanel _boxListPanel;

	[SerializeField]
	private PokemonIcon _swapRootPrefab;

	[SerializeField]
	private RectTransform _contextMenuRoot;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private Transform _cursorBody;

	[SerializeField]
	private Image _rangeCursor;

	[SerializeField]
	private Image _rangePlate;

	[SerializeField]
	private Canvas _cursorCanvas;

	[SerializeField]
	private PokemonModelView _modelViewSide;

	[SerializeField]
	private PokemonModelView _modelViewTrade;

	[SerializeField]
	private RectTransform _modelSideRoot;

	[SerializeField]
	private RectTransform _modelTradeRoot;

	[SerializeField]
	private BoxSearchPanel _searchPanel;

	[SerializeField]
	private BoxTextSelector _searchSubPanel;

	[SerializeField]
	private BoxSearchDescription _searchDescription;

	[SerializeField]
	private GameObject _tradeInfo;

	[SerializeField]
	private UIText _traderName;

	[SerializeField]
	private BoxNamePlate _namePlate;

	[SerializeField]
	private BoxSelectNumberPlate _numberPlate;

	[SerializeField]
	private BoxStatusPanel _statusPanel;

	[SerializeField]
	private BoxMarkingSettingPanel _markSettingPanel;

	[SerializeField]
	private GameObject _selectCountPlate;

	[SerializeField]
	private UIText _selectCountText;

	[SerializeField]
	private BoxWallPaperSelector _wallPaperSelector;

	[SerializeField]
	private CanvasGroup _topCanvasGroup;

	[SerializeField]
	private CanvasGroup _bottomCanvasGroup;

	[SerializeField]
	private Image _darkScreen;

	[SerializeField]
	private Transform _effectRoot;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private ControlType _controlType;

	private OperationType _operationType;

	private DisplayMode _displayMode;

	private StatusType _statusType;

	private BoxParty _battleTeam;

	private BoxTray _boxTray;

	private UINavigator _navigator;

	private PokemonIcon _swapIcon;

	private PokemonParam _currentPokeParam;

	private string _currentMsgID;

	private int _currentTrayIndex;

	private int _currentTeamIndex;

	private int _wallNo;

	private UINavigator _lastNaviBoxTrayItem;

	private UINavigator _fromNavigator;

	private UINavigator _returnNavigator;

	private int _fromTrayIndex;

	private int _fromTeamIndex;

	private BoxInfinityScrollItem _fromTray;

	private List<int> _hideIconIndexes;

	private List<int> _effectIndexes;

	private bool _isRepeatCancel;

	private int _rangeX;

	private int _rangeY;

	private int _rangeWidth;

	private int _rangeHeight;

	private UINavigator _rangeBeginNavigator;

	private List<PokemonIcon> _swapIcons;

	private List<UINavigator> _fromNavigators;

	private List<UINavigator> _toNavigators;

	private HashSet<int> _existSwapIndexes;

	private SearchType _searchType;

	private SEARCH_DATA _searchData;

	private bool _isDuckOn;

	private OpenParam _param;

	private List<SelectedPokemon> _selected;

	private Action<BoxWindow, SelectedPokemon[]> _onSelected;

	private Action<BoxWindow> _onDecide;

	private Action<BoxWindow> _onConfirm;

	private Action<BoxWindow> _onComplete;

	private Action<BoxWindow> _onCancelSelect;

	private MessageEnumData.MsgLangId _targetLangId;

	private Coroutine _coOpen;

	private Coroutine _coClose;

	private PokemonModelView _modelView;

	private MsgWindowParam _messageParam;

	private Keyguide.Param _keyguideParam;

	private Material _matSearchButton;

	private Material _matBoxButton;

	private DG.Tweening.Sequence _twSequence;

	private ContextMenuWindow _contextMenu;

	private float _waitSave;

	private EffectInstance _formChangeEffectInstance;

	private bool isCancelFormChange;

	private TradeParam _tradeParam;

	private CanvasGroup _tradeInfoCanvasGroup;

	private DialogWindow _networkDialog;

	private bool _isPhaseProcDone;

	private bool _isTradeInfoEnable;

	private float _tradeTimeoutCount;

	private float _modelOpenPosX;

	private float _modelClosePosX;

	private float _modelTradeOpenPosX;

	private float _modelTradeClosePosX;

	private float _partyOpenPosX;

	private float _partyClosePosX;

	private float _boxTrayPosX;

	private float _boxTraySlideX;

	private float _trayCellSizeX;

	private float _trayCellSizeY;

	private bool _isControlEnable;

	public static bool IsPanelTrasition;

	public static SearchIndexData SearchIndexData;

	public NetTradePhase TradePhase => default(NetTradePhase);

	public bool IsOpenRunning => default(bool);

	public bool IsCloseRunning => default(bool);

	public static Color32[] MarkColorSet
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

	public static void SetPanelTransitionSide(GameObject parentObject, RectTransform targetTransform, float targetPosX, [Optional] Action callback)
	{
	}

	public static void SetPanelTransitionFade(GameObject parentObject, CanvasGroup targetCanvas, float targetAlpha, [Optional] Action callback)
	{
	}

	public static void SetPanelTransitionBoth(GameObject parentObject, RectTransform targetTransform, float targetPosX, CanvasGroup targetCanvas, float targetAlpha, [Optional] Action callback)
	{
	}

	private static void SetPanelTransition(GameObject parentObject, Tween[] tweens, [Optional] Action callback)
	{
	}

	public static void CloseOverUIWindows()
	{
	}

	public void Awake()
	{
	}

	public void Open(UIWindowID prevWindowId, bool isDuckOn = false)
	{
	}

	public void Open(OpenParam param, UIWindowID prevWindowId, bool isDuckOn = false)
	{
	}

	public void Open(int openType, Action<BoxWindow, SelectedPokemon[]> onSelected, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void Open(OpenParam param, Action<BoxWindow, SelectedPokemon[]> onSelected, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void Open(string otherName, MessageEnumData.MsgLangId msgLangId, Action<BoxWindow, SelectedPokemon[]> onSelected, Action<BoxWindow> onDecide, Action<BoxWindow> onConfirm, Action<BoxWindow> onComplete, Action<BoxWindow> onCancelSelect, bool isFirst = true, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public void Open(OpenParam param, TradeParam tradeParam, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private void OnPartySelectChanged(BoxInfinityScrollItem scrollItem)
	{
	}

	private void OnTraySelectChanged(BoxInfinityScrollItem scrollItem)
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId, [Optional] string endMessage)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void ApplyPokemonStatusAndModel(UINavigator navigator, bool isImmidiate = false, bool isPlateEnable = true)
	{
	}

	private void ApplyPokemonStatusAndModel(PokemonParam param, bool isImmidiate = false, bool isPlateEnable = true)
	{
	}

	private void SetModelPanel(bool isEnable, bool isImmediate = false, [Optional] Action callBack)
	{
	}

	private void SetTrayNamePlate(UINavigator navigator)
	{
	}

	private void SetModelTradePanel(bool isEnable)
	{
	}

	private void SetWallPaperImage(BoxTray item, int wallNo)
	{
	}

	private void SetTradeInfo(bool isEnable)
	{
	}

	private void SetSelectBoxPanel(bool isEnable, [Optional] int? index)
	{
	}

	private void SetPanelsToSearchMode(bool isEnable)
	{
	}

	private void SetSelectBoxMode(bool isEnable)
	{
	}

	private void SetMarkingMode(bool isEnable)
	{
	}

	private void SetWallPaperSelectMode(bool isEnable)
	{
	}

	private void SetupKeyguide()
	{
	}

	private void SetBoxButtonGray(bool isGray)
	{
	}

	private void SetSearchButtonGray(bool isGray)
	{
	}

	private bool IsSwap()
	{
		return default(bool);
	}

	private bool IsRangeSelecting()
	{
		return default(bool);
	}

	private bool IsRangeSwap()
	{
		return default(bool);
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private bool UpdateNetworkTrade(float deltaTime)
	{
		return default(bool);
	}

	public void ToNextPhase(NetTradePhase next = NetTradePhase.None)
	{
	}

	public void SetOtherPokeParam(PokemonParam param)
	{
	}

	public void SetTradeMessageID(string messageId, ErrorCodeID errorId = ErrorCodeID.NUM)
	{
	}

	private void DispTradeMessage([Optional] Action callback)
	{
	}

	private IEnumerator WaitTradeSave()
	{
		return null;
	}

	private IEnumerator WaitLastConfirm()
	{
		return null;
	}

	private void CloseOverBoxWindows()
	{
	}

	private bool UpdateFunctionButton(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdatePlusMinusButton(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdateTray(float deltaTime)
	{
		return default(bool);
	}

	private bool UpdateSwap()
	{
		return default(bool);
	}

	private void CancelCursorMove()
	{
	}

	private bool UpdateBoxList(float deltaTime)
	{
		return default(bool);
	}

	private bool DropToBox(int toTrayIndex)
	{
		return default(bool);
	}

	private void BackTrayByBoxlist()
	{
	}

	private void UpdateSelect(float deltaTime, [Optional] UnityAction onMoveComplete)
	{
	}

	private void SetOperationType(OperationType operationType)
	{
	}

	private void SetDisplayMode(DisplayMode displayMode)
	{
	}

	private bool SetNavigate(UINavigator.NavigateType dirType, [Optional] UINavigator navigator, bool isSE = true)
	{
		return default(bool);
	}

	private bool SetNavigateInTray(UINavigator.NavigateType dirType, [Optional] UINavigator navigator, bool isSE = true)
	{
		return default(bool);
	}

	private bool SetRangeNavigateInTray(UINavigator.NavigateType dirType, bool isSE = true)
	{
		return default(bool);
	}

	private void SetNavigateFunction(UINavigator.NavigateType dirType)
	{
	}

	private bool SetNavigateBoxSelect(UINavigator.NavigateType type, UINavigator navigator, bool isSE = true)
	{
		return default(bool);
	}

	private void SetCursor(bool isSE = true, [Optional] UINavigator navigator)
	{
	}

	private void SetCursorPattern(OperationType type, CursorPattern pattern = CursorPattern.Normal)
	{
	}

	private void SetSelectIcons(UINavigator.NavigateType dirType = UINavigator.NavigateType.None)
	{
	}

	private void SetSwapRootParent()
	{
	}

	private void ApplyModel(BoxItem naviItem)
	{
	}

	private void ApplyModel(PokemonParam param, bool isTrade = false)
	{
	}

	private IEnumerator CoApplyModel(PokemonParam param)
	{
		return null;
	}

	private void InitRangeSelect()
	{
	}

	private void BeginRangeSelect()
	{
	}

	private void BeginRangeCursorMove()
	{
	}

	private void SetRangeIcons(List<UINavigator> navigators)
	{
	}

	private void GetRangeFromNavigators(ref List<UINavigator> recieveList, UINavigator startNavi)
	{
	}

	private bool GetRangeToNavigators(ref List<UINavigator> recieveList, UINavigator selectNavi, List<UINavigator> fromTargetList, [Optional] BoxInfinityScrollItem fromTray)
	{
		return default(bool);
	}

	private void UpdatePokemonPaaram(int trayIndex, int index, PokemonParam param)
	{
	}

	private BoxItem GetNaviItem(UINavigator navigator)
	{
		return null;
	}

	private BoxParty GetCurrentParty()
	{
		return null;
	}

	private void ApplyBoxList(int index)
	{
	}

	private void ApplyCurrentTrayAtBoxList()
	{
	}

	private void ApplyTrayAtBoxList()
	{
	}

	private void ApplyTray(bool isParty)
	{
	}

	private void SetSelectCountPlate()
	{
	}

	public IEnumerator DebugNext(int waitSec = 0, NetTradePhase phase = NetTradePhase.None, [Optional] Action callback)
	{
		return null;
	}

	private void OpenContextMenu()
	{
	}

	private void SelectPokemon(BoxItem item, bool isItemMode = false)
	{
	}

	private bool OnContextMenu(ContextMenuItem menuItem)
	{
		return default(bool);
	}

	private bool OnTradeContextMenu(ContextMenuItem item)
	{
		return default(bool);
	}

	private void OpenStatusWindow(PokemonStatusWindow.Param statusParams, OpenParam reopenParam)
	{
	}

	private PokemonStatusWindow.Param GetStatusParams(NaviParam naviParam)
	{
		return null;
	}

	private PokemonStatusWindow.Param GetStatusParams(NaviParam.ItemType type, int index)
	{
		return null;
	}

	private void BeginIconSelect(UINavigator navigator, bool isRemoveByTeam = false)
	{
	}

	private bool SetSendPokemon(SelectedPokemon target, bool isTrade = false)
	{
		return default(bool);
	}

	private void ResetSendPokemon(SelectedPokemon target)
	{
	}

	private void SetItem(NaviParam naviParam, BoxItem naviItem)
	{
	}

	private void RemoveItem(BoxItem naviItem)
	{
	}

	private void formChangeEffect(bool isFormChange, BoxItem naviItem)
	{
	}

	private void CancelNetworkMine()
	{
	}

	private void CancelNetworkTrade()
	{
	}

	public void ClearTradeSelected()
	{
	}

	private void OpenYesNoContextMenu(Func<ContextMenuItem, bool> onClicked, [Optional] UnityAction<UIWindow> onClosed, int selectIndex = 0)
	{
	}

	private void OpenTradeConfirmContextMenu(Func<ContextMenuItem, bool> onClicked, [Optional] UnityAction<UIWindow> onClosed, int selectIndex = 0)
	{
	}

	private void OpenContextMenu(List<ContextMenuItem.Param> menuItems, Func<ContextMenuItem, bool> onClicked, [Optional] UnityAction<UIWindow> onClosed, int selectIndex = 0, uint seDecide = 0u)
	{
	}

	private void SetMessage(string messageID, bool isCloseEnable = true, [Optional] Action onClose, [Optional] Action onShow, bool isNetTrade = false)
	{
	}

	private void SetMessage(string msgFile, string messageID, bool isCloseEnable = true, [Optional] Action onClose, [Optional] Action onShow, bool isNetTrade = false)
	{
	}

	private SelectedPokemon GetSelected()
	{
		return null;
	}

	private OpenParam GetReOpenParam(NaviParam naviParam)
	{
		return null;
	}

	private void BeginRangeSwap()
	{
	}

	private void MoveRangePartyByParty()
	{
	}

	private void MoveRangeTeamByTeam()
	{
	}

	private void BeginRangeTrayByTray()
	{
	}

	private void MoveRangePartyByTray()
	{
	}

	private void MoveRangeTeamByTray()
	{
	}

	private void MoveRangeTrayByParty()
	{
	}

	private void RangeUnregistTeam()
	{
	}

	private void BeginSwap()
	{
	}

	private void BeginTrayByTray(UINavigator toNavigator)
	{
	}

	private void MoveTrayByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapTrayByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void BeginPartyByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void MoveLastPartyByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapPartyByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void BeginPartyByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void MoveLastPartyByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapPartyByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void BeginTeamPartyByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void MoveLastTeamPartyByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapTeamPartyByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void BeginRegistTeamByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void MoveLastTeamPartyByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapAndPackRegistTeamByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void AddRegistTeam(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapRegistTeamByTray(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void UnregistTeam(UINavigator fromNavigator)
	{
	}

	private void BeginTrayByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void MoveTrayByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapTrayByParty(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void MoveItem(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void SwapItem(UINavigator fromNavigator, UINavigator toNavigator)
	{
	}

	private void RestoreSelect(bool isDecide = true, bool isUpdate = true, bool isFromHide = true, [Optional] UINavigator toNavigator, [Optional] Action callback)
	{
	}

	private void RestoreSelectItem(bool isToChange, bool isFormChange, UINavigator toNavigator, UINavigator fromNavigator, PokemonParam toPokemonParam, PokemonParam fromPokemonParam)
	{
	}

	private void RestoreRangeSelect(bool isDecide = true, bool isUpdate = true, bool isFromHide = true, [Optional] List<UINavigator> toNavigators, [Optional] Action callback)
	{
	}

	private void EndSwap(bool isParty)
	{
	}

	private void EndRangeSwap(bool isParty)
	{
	}

	private void SetPartyLast(UINavigator toNavigator, [Optional] Action<UINavigator> callback)
	{
	}

	private void FillPartyGap(UINavigator blankNavigator, int packCount = 1, bool isExceptLast = true, [Optional] Action callback)
	{
	}

	private void SetIconSelect(PokemonIcon swapIcon, UINavigator navigator, bool isEnable, bool isFromHide, [Optional] Action callback)
	{
	}

	private void SetIconSelect(List<PokemonIcon> swapIcons, List<UINavigator> navigators, bool isEnable, bool isFromHide, [Optional] Action callback)
	{
	}

	private void SetTrayIconSwap(PokemonIcon swapIcon, UINavigator fromNavigator, UINavigator toNavigator, [Optional] Action callback)
	{
	}

	public static DG.Tweening.Sequence SetIconMoveSequence(PokemonIcon fromIcon, Vector3 toPosition, [Optional] Action callback)
	{
		return null;
	}

	public static DG.Tweening.Sequence SetIconMoveSequence(int count, PokemonIcon[] fromIcons, Vector3[] toPositions, [Optional] Action callback)
	{
		return null;
	}

	private void SetRangeSwapIcon(int index, PokemonIcon icon)
	{
	}

	private bool SetFormChangeByItem(PokemonParam pokemonParam)
	{
		return default(bool);
	}

	private bool SetFormChangeByMove(PokemonParam pokemonParam)
	{
		return default(bool);
	}

	private void PlayFormChangeeffect(bool isPlay, PokemonParam pokemonParam, PokemonIcon pokeIcon, bool isSingle = true, [Optional] Action onChangeIcon, [Optional] Action onComplete)
	{
	}

	private bool CanBattlePokemon(PokemonParam param)
	{
		return default(bool);
	}

	private PokemonParam GetPartyPokemonParam(int index)
	{
		return null;
	}

	private UINavigator GetLastPartyNavigator()
	{
		return null;
	}

	private void SetPairPokemon(PokemonParam pokeParam)
	{
	}

	private void ReturnPairPokemon(PokemonParam pokeParam)
	{
	}

	private int GetPairPokemonIndex()
	{
		return default(int);
	}

	public static bool IsHitSearchType(PokemonParam pokemonParam, SEARCH_DATA data, int tray = 40, int pos = 30)
	{
		return default(bool);
	}

	public static bool IsHitSelectType(PokemonParam pokemonParam, OpenParam param)
	{
		return default(bool);
	}

	private void SetSearchMode(bool isEnable)
	{
	}

	private void SetSearchSubMode(bool isEnable)
	{
	}

	private void ApplyBoxTrayBySearch()
	{
	}

	private void ApplyPartyTrayBySearch()
	{
	}

	private void ApplyTeamTrayBySearch()
	{
	}

	private void ApplyBoxListBySearch(int trayNum)
	{
	}

	private void ApplyDescription()
	{
	}
}
