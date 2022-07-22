using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Item;
using Pml;
using Pml.Item;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIBag : UIWindow
{
	public enum BootType
	{
		Default,
		Pokemon,
		Status,
		Poffine,
		Battle,
		BattleAutoPilot,
		WazaMachine,
		Important,
		Length
	}

	public enum ModeType
	{
		Default,
		Recovery,
		Equip,
		EquipOnly
	}

	private enum RecoveryResultType
	{
		None,
		RecoveryPoison,
		RecoveryBurn,
		RecoveryIce,
		RecoveryPanic,
		RecoveryParalyze,
		RecoverySleep,
		RecoveryMeroMero,
		RecoveryAllSick,
		RecoveryHp,
		RecoveryDead
	}

	private struct BattleBootParam
	{
		public int TopMemberIndex;

		public bool IsTrainerBattle;

		public bool isDouble;

		public bool[] SasiosaeFlags;
	}

	private const string QuestionWhichUseItemMessageLabel = "SS_bag_035";

	private const string ResultCantLearnWazaMachineMessageLabel = "SS_bag_036";

	private const string ResultExistWazaMessageLabel = "SS_bag_037";

	private const string QuestionUseWazaMachine1MessageLabel = "SS_bag_038";

	private const string QuestionUseWazaMachine2MessageLabel = "SS_bag_045";

	private const string QuestionUseWazaMachine3MessageLabel = "SS_bag_047";

	private const string ResultLearnWazaMessageLabel = "SS_bag_039";

	private const string ResultUnlearnWazaMessageLabel = "SS_bag_149";

	private const string QuestionUnlernToLearnWazaMessageLabel = "SS_bag_040";

	private const string ResultUnlernToLearnWazaMessageLabel = "SS_bag_041";

	private const string ResultNotLearnWazaMessageLabel = "SS_bag_042";

	private const string QuestionUnlearnWazaMessageLabel = "SS_bag_043";

	private const string TypeSortMessageLabel = "SS_bag_077";

	private const string NameSortMessageLabel = "SS_bag_078";

	private const string NewSortMessageLabel = "SS_bag_079";

	private const string NumberSortMessageLabel = "SS_bag_080";

	private const string FavoriteSortMessageLabel = "SS_bag_081";

	private const string CancelSortMessageLabel = "SS_bag_082";

	private const string QuestionSortMessageLabel = "SS_bag_083";

	private const string TypeSortResultMessageLabel = "SS_bag_084";

	private const string NameSortResultMessageLabel = "SS_bag_085";

	private const string NumberSortResultMessageLabel = "SS_bag_086";

	private const string FavoriteSortResultMessageLabel = "SS_bag_087";

	private const string NewSortResultMessageLabel = "SS_bag_088";

	private const string RecoveryHpResultMessageLabel = "SS_bag_098";

	private const string RecoveryDeadResultMessageLabel = "SS_bag_099";

	private const string RecoveryPoisonResultMessageLabel = "SS_bag_100";

	private const string RecoveryParalyzeResultMessageLabel = "SS_bag_101";

	private const string RecoveryBurnResultMessageLabel = "SS_bag_102";

	private const string RecoveryIceResultMessageLabel = "SS_bag_103";

	private const string RecoverySleepResultMessageLabel = "SS_bag_104";

	private const string RecoveryAllSickResultMessageLabel = "SS_bag_105";

	private const string AddEffortPowerResultMessageLabel = "SS_bag_106";

	private const string AddFriendshipAndSubEffortPowerResultMessageLabel = "SS_bag_107";

	private const string NotAddFriendshipAndSubEffortPowerResultMessageLabel = "SS_bag_108";

	private const string AddFriendshipAndNotSubEffortPowerResultMessageLabel = "SS_bag_109";

	private const string UsedItemMessageLabel = "SS_bag_110";

	private const string EquipItemResultMessageLabel = "SS_bag_112";

	private const string SwapItemResultMessageLabel = "SS_bag_113";

	private const string DontUseSprayItemMessageLabel = "SS_bag_111";

	private const string NoEffectUseItemResultMessageLabel = "SS_bag_115";

	private const string DontUseItemDoctorsAdviceMessageLabel = "SS_bag_337";

	private const string DontUseItemMessageLabel = "SS_bag_337";

	private const string QuestionWhichEquipItemMessageLabel = "SS_bag_119";

	private const string DontEquipItemForEggMessageLabel = "SS_bag_120";

	private const string QuestionSwapItemMessageLabel = "SS_bag_122";

	private const string QuestionRecoverWazaPPMessageLabel = "SS_bag_123";

	private const string RecoverWazaPPResultMessageLabel = "SS_bag_121";

	private const string QuestionWazaPPUpMessageLabel = "SS_bag_124";

	private const string WazaPPUpResultMessageLabel = "SS_bag_125";

	private const string DontAddItemMessageLabel = "SS_bag_126";

	private const string FormChangeResultMessageLabel = "SS_bag_146";

	private const string QuestionUseTokuseiItemMessageLabel = "SS_bag_151";

	private const string UseTokuseiItemResultMessageLabel = "SS_bag_152";

	private const string QuestionUseMintItemMessageLabel = "SS_bag_161";

	private const string UseMintItemResultMessageLabel = "SS_bag_162";

	private const string QuestionHowManyUseItemMessageLabel = "SS_bag_163";

	private const string QuestionRotomFormChangeMessageLabel = "SS_bag_175";

	private const string CantGetOffBicycleMessageLabel = "SS_bag_352";

	private const string DsPlayerOnMessageLabel = "SS_bag_353";

	private const string DsPlayerOffMessageLabel = "SS_bag_354";

	private const string PointCardMessageLabel = "SS_bag_355";

	private const int NonTargetIndex = -1;

	[SerializeField]
	private BagItemPanel bagItemPanel;

	[SerializeField]
	private PokemonParty pokemonParty;

	[SerializeField]
	private BagWazaSelectPanel wazaSelectPanel;

	[SerializeField]
	private RectTransform effectRoot;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private BootType bootType;

	private ModeType modeType;

	private PokemonParam onlyViewPokemonParam;

	private int onlyViewPartyIndex;

	private int onlyViewBattlePokemonId;

	private BattleBootParam battleBootParam;

	private Action<int> onSelectedKinomiItem;

	private Action onCompleteAutoPilot;

	private UIMsgWindowController msgWindowController;

	private PokemonParty.Param pokemonPartyParam;

	private int displayMoney;

	private bool isWaitUpdate;

	private bool isWaitPokemonParty;

	private bool isKinomiContact;

	private bool isDontBuryNuts;

	private bool isAutoPilot;

	private bool isBattle => default(bool);

	private bool isNeedBgmDuck => default(bool);

	private bool canSwitchFavorite => default(bool);

	private bool canSort => default(bool);

	private bool canUseItem => default(bool);

	public bool IsOpenFromBattleTeam
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

	public override void OnCreate()
	{
	}

	public void Open(BootType bootType = BootType.Default, ModeType modeType = ModeType.Default, [Optional] PokemonParam pokemonParam, int displayMoney = -1, bool isDontBuryNuts = false, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void OpenSelectKinomi(Action<int> onSelectedKinomiItem, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void OpenWazaMachineOnly(bool isContestWaza, PokemonParam pokemonParam, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void OpenAutoPilot(ushort useItemNo, BootType bootType = BootType.Default, [Optional] Action onComplete, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId, bool isPlayCloseSe = true)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId, bool isPlayCloseSe = true)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateDefault()
	{
	}

	private void OnUpdateSelectAmount()
	{
	}

	private void OnUpdatePokemonParty(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void SetupBagItemPanel()
	{
	}

	private void SetupBattleBootParam()
	{
	}

	private void OnChangeBagPanelSelectItem(BagItemButton bagItemButton)
	{
	}

	private void CreatePokemonPartyParam(int selectIndex = 0)
	{
	}

	private void StartSelectPokemonParty(UnityAction<PokemonPartyItem, int> onClicked)
	{
	}

	private void EndSelectPokemonParty()
	{
	}

	private void OpenContextMenu(ContextMenuID[] contextMenuIDs, Action<ContextMenuID> onSelected, Vector2 pivot, Vector3 pos, [Optional] Action onClosed, bool isNoDecideSe = false, bool isNoCancelSe = false)
	{
	}

	private void ShowItemContextMenu(ItemInfo item)
	{
	}

	private void SwitchSelectedItemFavorite()
	{
	}

	private void ShowWazaOboeWindow(PokemonParam pokemonParam, WazaNo learnWazaNo, Action<WazaNo, WazaNo> resultCallBack)
	{
	}

	private void StartSortItems()
	{
	}

	private void SortItems(ItemInfo.SortType sortType)
	{
	}

	private void ShowSortResultMessage(ItemInfo.SortType sortType)
	{
	}

	private void OnPokemonPartyClickedToUseItem(PokemonPartyItem pokemonPartyItem, int index)
	{
	}

	private void UseWazaMachine(PokemonParam pokeParam, ItemInfo itemInfo)
	{
	}

	private void UseApplicationItem(PokemonParam pokeParam, ItemInfo itemInfo)
	{
	}

	private void UseTokuseiItem(PokemonParam pokeParam, ItemInfo itemInfo, Func<PokemonParam, bool> useItemFunc)
	{
	}

	private bool CheckAndUseRecoveryItem(PokemonParam pokeParam, ItemInfo itemInfo, bool isUse, out RecoveryResultType resultType)
	{
		return default(bool);
	}

	private string GetRecoveryResultLabelName(RecoveryResultType recoveryResult)
	{
		return null;
	}

	private float GetRecoverHpRate(ItemData.HpRecoverType recoveryHpValue)
	{
		return default(float);
	}

	private bool CheckExpItem(ItemInfo itemInfo, out PowerID powerID, out int addExpValue)
	{
		return default(bool);
	}

	private Action GetUseItemToNothingAction()
	{
		return null;
	}

	private bool CanUseWazaMachine(MonsNo monsNo, ushort formNo, ushort machineNo)
	{
		return default(bool);
	}

	private void EndUseItemAction(PokemonParam pokemonParam, ItemInfo itemInfo, int useCount = 1, bool isForceEnd = false)
	{
	}

	private void UseFormChangeItem(PokemonPartyItem pokemonPartyItem, ItemInfo itemInfo)
	{
	}

	private void ShowFormChangeResult(PokemonParam pokemonParam)
	{
	}

	private void OnBattleBootPokemonPartyClickedToUseItem(PokemonPartyItem pokemonPartyItem, int index)
	{
	}

	private void OnPokemonPartyClickedToEquipItem(PokemonPartyItem pokemonPartyItem, int index)
	{
	}

	private void EndItemEquip(PokemonPartyItem pokemonPartyItem)
	{
	}

	public IEnumerator ResetBallTab()
	{
		return null;
	}

	private IEnumerator StartAutoPilot(ItemInfo useItem)
	{
		return null;
	}
}
