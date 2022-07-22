using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DG.Tweening;
using Dpr.Battle.Logic;
using Dpr.Battle.View.UI;
using Dpr.Message;
using Dpr.MsgWindow;
using Dpr.UI;
using Pml;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Battle.View.Systems;

public sealed class BattleViewUISystem : MonoBehaviour
{
	private enum Side
	{
		Near,
		Far,
		All
	}

	public enum BallSpriteType
	{
		Normal,
		Dead,
		Sicked,
		Blank
	}

	public enum MoveIndex
	{
		first,
		second
	}

	private class DispInfo
	{
		public Side side;

		public bool isPlayerPlateVisible;

		public bool isFirstTimeAnime;

		public bool isPlayerPlateVisibleIfDead;
	}

	public const int POKE_BALL_MAX = 6;

	private const float DECO_SHOW_POS_X = 570f;

	private const float DECO_HIDE_POS_X = 960f;

	private const float DECO_POS_Y = -340f;

	private const float DECO_SHOW_ROT = 340f;

	private const float DECO_HIDE_ROT = 160f;

	private const int SEQ_END_WAIT_SAFETY_COUNT = 100;

	private const int SEQ_END_WAIT_DOT_DIST_MAX = 10;

	public const string PokemonNameMessageLabel = "msg_ui_btl_pokename";

	public static readonly string[] AffinityText;

	public const string ContextMenuMsgFile = "ss_btl_app";

	public static readonly string[][] ContextMenuText;

	public static readonly string[] AffinitySpriteName;

	private const float _msgTimeOut = 20f;

	[SerializeField]
	private RawImage _decoImage;

	[SerializeField]
	private BUIStatusWindow[] _statusWindows;

	[SerializeField]
	private Sprite[] _ballSprites;

	[SerializeField]
	private Sprite[] _ballLargeSprites;

	[SerializeField]
	private BUIActionList _actionList;

	[SerializeField]
	private BUIWazaList _wazaList;

	[SerializeField]
	private BUIWazaDescription _wazaDescription;

	[SerializeField]
	private BUITokuseiPlate _tokuseiNear;

	[SerializeField]
	private BUITokuseiPlate _tokuseiFar;

	[SerializeField]
	private BUIBallPlate _ballPlateNear;

	[SerializeField]
	private BUIBallPlate _ballPlateFar;

	[SerializeField]
	private BUIPokeBallList _pokeBallList;

	[SerializeField]
	private BUISafariBall _safariBall;

	[SerializeField]
	private BUITargetSelect _targetSelect;

	[SerializeField]
	private BUICommTime _commTime;

	[SerializeField]
	private Dpr.UI.Cursor _cursor;

	[SerializeField]
	private float _cursorWait;

	[SerializeField]
	private float _executeWait;

	[SerializeField]
	private int _tutorialBallCount;

	[SerializeField]
	private int _tutorialDrugCount;

	[SerializeField]
	private int _tutorialMoney;

	private bool _isMenuUIEnd;

	private bool _isFirstTime;

	private bool _isPlaySound;

	private bool _isShowDeco;

	private bool _isMsgEnd;

	private bool _isMessageSleep;

	[SerializeField]
	private bool _isMessageOpen;

	private float _msgTimer;

	private MsgShowParam _showParam;

	private Queue<(MessageTextParseDataModel, MsgShowParam)> _messagePramQueue;

	private Coroutine _coMsgQueue;

	private Action _endMsgAction;

	private Dpr.MsgWindow.MsgWindow _msgWindow;

	private BtlYesNo? _yesnoResult;

	private UIWindow _uiWindow;

	private PokemonBattleWindow.Param _pokeWinParam;

	private Coroutine _coCloseMenuUI;

	private PokeSelParam _pokeSelParam;

	private PokeSelResult _pokeSelResult;

	private BattleViewBase.SelectActionParam _actionParam;

	private BTL_POKEPARAM _swapWaitPokemon;

	private HUDEventID preHUDEventId;

	private uint _outMemberIndex;

	private ItemNo _selectItem;

	private int _selectWaza;

	private int _selectPoke;

	private BUIAutoPilot _autoPilot;

	private BTL_POKEPARAM _currentPoke;

	private DG.Tweening.Sequence _decoballSequence;

	private int SeqEndWaitSafetyCount;

	public int seqDotDispWaitTime;

	private static uint _lastSelectedBallId;

	public static bool IsDebugHide;

	private CanvasGroup _uiCanvasGroup;

	private static BattleViewUISystem _instance;

	public static uint lastSelectedBallItemNo
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public BUIActionList ActionList => null;

	public BUIWazaList WazaList => null;

	public BUIPokeBallList PokeBallList => null;

	public BUIWazaDescription WazaDescription => null;

	public BUIStatusWindow[] StatusWindows => null;

	public BUITokuseiPlate TokuseiNear => null;

	public BUITokuseiPlate TokuseiFar => null;

	public BUIBallPlate BallPlateNear => null;

	public BUIBallPlate BallPlateFar => null;

	public BUISafariBall SafariBall => null;

	public BUITargetSelect TargetSelect => null;

	public BUICommTime CommTime => null;

	public Dpr.UI.Cursor CursorFrame => null;

	public ItemNo SelectItem => default(ItemNo);

	public static BattleViewUISystem Instance => null;

	public void HUD_Hide()
	{
	}

	public void CMD_UI_SelectAction_Start([In] ref BattleViewBase.SelectActionParam param, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public BtlAction CMD_UI_SelectAction_Wait()
	{
		return default(BtlAction);
	}

	public void CMD_UI_SelectAction_ForceQuit()
	{
	}

	public void CMD_UI_SelectWaza_Start(BTL_POKEPARAM bpp, byte pokeIndex, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public void CMD_UI_SelectWaza_Restart(byte pokeIndex)
	{
	}

	public bool CMD_UI_SelectWaza_Wait()
	{
		return default(bool);
	}

	public bool CMD_UI_SelectWaza_End()
	{
		return default(bool);
	}

	public void CMD_UI_SelectWaza_ForceQuit()
	{
	}

	public void CMD_UI_SelectTarget_Start(byte poke_index, BTL_POKEPARAM bpp, BTL_ACTION_PARAM_OBJ dest)
	{
	}

	public BattleViewBase.BtlvResult CMD_UI_SelectTarget_Wait()
	{
		return default(BattleViewBase.BtlvResult);
	}

	public void CMD_UI_SelectTarget_ForceQuit()
	{
	}

	public void CMD_StartPokeList(PokeSelParam param, BTL_POKEPARAM outMemberParam, uint outMemberIndex, bool fCantEsc, PokeSelResult result)
	{
	}

	public bool CMD_WaitPokeList()
	{
		return default(bool);
	}

	public void CMD_ForceQuitPokeList()
	{
	}

	public bool CMD_WaitForceQuitPokeList()
	{
		return default(bool);
	}

	public void CMD_StartPokeSelect(PokeSelParam param, uint outMemberIndex, bool bCancelable, PokeSelResult result)
	{
	}

	public bool CMD_WaitPokeSelect()
	{
		return default(bool);
	}

	public void CMD_ForceQuitPokeSelect()
	{
	}

	public bool CMD_WaitForceQuitPokeSelect()
	{
		return default(bool);
	}

	public void CMD_ExpGet_Start([In] ref BattleViewBase.ExpGetDesc desc, BattleViewBase.ExpGetResult pResult)
	{
	}

	public bool CMD_ExpGet_Wait(ref BattleViewBase.ExpGetResult pResult)
	{
		return default(bool);
	}

	public void MSG_Start(MessageTextParseDataModel pStrBuf, bool isKeyWait = true)
	{
	}

	public void MSG_Hide()
	{
	}

	public void MSG_AutoOnce()
	{
	}

	public void CMD_StartMsg(BTLV_STRPARAM param, bool isKeyWait = false)
	{
	}

	public void CMD_StartMsgWaza(byte pokeId, WazaNo waza, bool isZenryokuWaza)
	{
	}

	public void CMD_StartMsgStd(ushort strID, int[] args)
	{
	}

	public void CMD_StartMsgSet(ushort strID, int[] args)
	{
	}

	public void CMD_StartMsgTrainer(byte clientID, uint param, bool isKeyWait = true, bool needSleep = false)
	{
	}

	public bool CMD_WaitMsg()
	{
		return default(bool);
	}

	public bool CMD_WaitMsg_WithoutHide()
	{
		return default(bool);
	}

	public void CMD_HideMsg()
	{
	}

	public void CMD_ITEMSELECT_Start(byte bagMode, byte energy, byte reserved_energy, bool fFirstPokemon, bool fBallTargetHide, bool canUseReliveItem)
	{
	}

	public bool CMD_ITEMSELECT_Wait()
	{
		return default(bool);
	}

	public void CMD_ITEMSELECT_ForceQuit()
	{
	}

	public ItemNo CMD_ITEMSELECT_GetItemID()
	{
		return default(ItemNo);
	}

	public byte CMD_ITEMSELECT_GetTargetIdx()
	{
		return default(byte);
	}

	public byte CMD_ITEMSELECT_GetWazaIdx()
	{
		return default(byte);
	}

	public void CMD_ITEMSELECT_ReflectUsedItem()
	{
	}

	public void CMD_TokWin_DispStartEx(BtlPokePos pos, TokuseiNo overrideTokusei)
	{
	}

	public bool CMD_TokWin_DispWait(BtlPokePos pos)
	{
		return default(bool);
	}

	public void CMD_QuitTokWin(BtlPokePos pos)
	{
	}

	public bool CMD_QuitTokWinWait(BtlPokePos pos)
	{
		return default(bool);
	}

	public void CMD_TokWin_Renew_Start(BtlPokePos pos)
	{
	}

	public bool CMD_TokWin_Renew_Wait(BtlPokePos pos)
	{
		return default(bool);
	}

	public void CMD_StartCommWait()
	{
	}

	public bool CMD_WaitCommWait()
	{
		return default(bool);
	}

	public void CMD_ResetCommWaitInfo()
	{
	}

	public void CMD_YESNO_Start(bool bCancel, YesNoMode mode)
	{
	}

	public bool CMD_YESNO_Wait(out BtlYesNo result)
	{
		return default(bool);
	}

	public void CMD_YESNO_ForceQuit()
	{
	}

	public void CMD_EFFECT_DrawEnableTimer(GameTimer.TimerType type, bool enable)
	{
	}

	public bool MSG_IsRunnning()
	{
		return default(bool);
	}

	public bool MSG_WaitMenu(ref byte selectId)
	{
		return default(bool);
	}

	public bool AutoPilot_EventTest(AutoPilotEventID id)
	{
		return default(bool);
	}

	public bool HUD_StartingDemo_Wait()
	{
		return default(bool);
	}

	public bool UIFog_Wait()
	{
		return default(bool);
	}

	public bool HUD_IsPinch(BtlvPos vPos)
	{
		return default(bool);
	}

	public bool HUD_IsShowing(BtlvPos vPos)
	{
		return default(bool);
	}

	public void DispBallBar(BtlvPos vPos, bool isDisp)
	{
	}

	public static IEnumerator LoadAssetSelf(Transform parent, [Optional] Action callback)
	{
		return null;
	}

	public static AssetBundleUnloader UnloadAssetSelf()
	{
		return null;
	}

	public void Remove()
	{
	}

	private void RemoveImpl()
	{
	}

	public void Startup()
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}

	public void Show(bool isWithBallPlate = false)
	{
	}

	public void Hide()
	{
	}

	public void HideHpGuge()
	{
	}

	public void OnHUDEvent(HUDEventID eventId, BattleViewSystem pViewSystem)
	{
	}

	public void Apply(int interpFrame)
	{
	}

	public void SetCurrentPokemonStatus()
	{
	}

	public BUIStatusWindow GetStatusWindow(BtlvPos pos)
	{
		return null;
	}

	private void InitStatusWindows(bool isEnableTokusei)
	{
	}

	private void InitializeStatusWindow(BtlvPos pos, bool isEnableTokusei)
	{
	}

	public void SetVisible(BtlvPos vPos, bool isVibivle, bool isWithBallPlate, bool isForced = false)
	{
	}

	public void SetVisibleForced(BtlvPos vPos, bool isVisible, bool isWithBallPlate)
	{
	}

	public void SwitchShowStatusWindow(BtlvPos vPos, bool isShow)
	{
	}

	private IEnumerator SwitchShowStatusWindowCoroutine(BtlvPos vPos, bool isShow)
	{
		return null;
	}

	public void SwitchShowStatusWindows(bool isShow)
	{
	}

	private IEnumerator SwitchShowStatusWindowsCoroutine(bool isShow)
	{
		return null;
	}

	private void SwitchShowStatusWindowsCore(bool isShow, bool isForceBallHide = true)
	{
	}

	public bool IsOpenedStatus()
	{
		return default(bool);
	}

	public bool IsClosingStatus()
	{
		return default(bool);
	}

	public bool IsSeqEndWait()
	{
		return default(bool);
	}

	private IEnumerator CloseStatusWindow(BUIStatusWindow window)
	{
		return null;
	}

	private bool IsShowStatusEnemyOnly(List<bool> flags)
	{
		return default(bool);
	}

	private bool IsStatusWindowTarasit()
	{
		return default(bool);
	}

	public bool Wait()
	{
		return default(bool);
	}

	public void SwitchShowActionList(bool isShow, bool withStatusWindow = false, bool withDecoraton = true)
	{
	}

	private IEnumerator SwitchActionListCoroutine(bool isShow, bool withStatusWindow = false, bool withDecoraton = true)
	{
		return null;
	}

	private void ShowActionListOnly(bool isShow)
	{
	}

	private IEnumerator ShowActionListOnlyCoroutine(bool isShow)
	{
		return null;
	}

	private void SwitchShowDecoImage(bool isShow)
	{
	}

	private bool IsNearSide(BtlPokePos pos)
	{
		return default(bool);
	}

	private BUITokuseiPlate GetTokuseiPlate(BtlPokePos pos)
	{
		return null;
	}

	private void OpenPokemonWindow(PokeSelParam selParam, PokemonBattleWindow.Param winParam, uint outMemberIndex, PokeSelResult result)
	{
	}

	private void OpenPokemonBattleWindow(PokemonBattleWindow uiWindow, PokemonBattleWindow.Param winParam)
	{
	}

	private void OnSwapPokemon(List<BTL_POKEPARAM> pokemonParams, PokemonBattleWindow.PositionType posType)
	{
	}

	private void OnSwapCancel()
	{
	}

	private PokemonBattleWindow.Param.BattleType GetBattleType()
	{
		return default(PokemonBattleWindow.Param.BattleType);
	}

	private bool IsOpenMessage()
	{
		return default(bool);
	}

	private bool IsEndMessage()
	{
		return default(bool);
	}

	private void SetMessageQueue(MessageTextParseDataModel strBuf, MsgShowParam showParam)
	{
	}

	private IEnumerator MessageWindowCoroutine()
	{
		return null;
	}

	private void OpenMessageWindow(MessageTextParseDataModel strBuf, MsgShowParam showParam)
	{
	}

	private void CloseMessageWindow()
	{
	}

	private void OpenSelectWindow(bool bCancel, YesNoMode mode)
	{
	}

	private void OpenMenuUI<T>(UIWindowID id, Action<T> openProc, bool doDuckoff = true) where T : UIWindow
	{
	}

	private void ForceQuitMenuUI<T>(Action<T> closeProc, bool isMenuShow = true) where T : UIWindow
	{
	}

	private IEnumerator CloseMenuUICoroutine<T>(Action<T> closeProc, bool isMenuShow = true) where T : UIWindow
	{
		return null;
	}

	private void BeginTutorialCapture()
	{
	}

	public IEnumerator WaitForStandbyAction(float wait)
	{
		return null;
	}

	public IEnumerator WaitForStandbyWaza(float wait)
	{
		return null;
	}

	public IEnumerator SelectActionListButton(BUIActionList.ActionButtonType target, float wait)
	{
		return null;
	}

	public IEnumerator ExecuteActionButton(float wait)
	{
		return null;
	}

	public IEnumerator ExecuteWazaButton(float wait)
	{
		return null;
	}

	public IEnumerator SetDumyBag(bool enable, float wait = 0f)
	{
		return null;
	}

	private void SetTutorialItem(ItemNo itemNo, int count)
	{
	}

	public string GetAffinityText(BTL_POKEPARAM bpp, WazaNo wazaNo, BTL_POKEPARAM target)
	{
		return null;
	}

	public string GetAffinityText(BTL_POKEPARAM bpp, WazaNo wazaNo, List<BTL_POKEPARAM> targets)
	{
		return null;
	}

	public Sprite GetAffinitySprite(BTL_POKEPARAM bpp, WazaNo wazaNo, BTL_POKEPARAM target)
	{
		return null;
	}

	public Sprite GetAffinitySprite(BTL_POKEPARAM bpp, WazaNo wazaNo, List<BTL_POKEPARAM> targets)
	{
		return null;
	}

	public void PlaySe(uint eventId)
	{
	}

	public void SetSexIcon(Sex sex, Image target)
	{
	}
}
