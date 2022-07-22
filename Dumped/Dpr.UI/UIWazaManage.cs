using System;
using System.Collections;
using System.Collections.Generic;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIWazaManage : UIWindow
{
	public enum BootType
	{
		Remember,
		Unlearn,
		Learn
	}

	public struct Param
	{
		public BootType BootType;

		public bool IsOpenFromFieldScript;

		public PokemonParam PokemonParam;

		public WazaNo LearnWazaNo;

		public Action<WazaNo, WazaNo> ResultCallback;
	}

	private static readonly Vector2 MsgWindowAnchorPos;

	private const string ConfirmRememberWazaMessageLabel = "SS_waza_remember_023";

	private const string ConfirmDontRememberWazaMessageLabel = "SS_waza_remember_026";

	private const string ConfirmUnlernWazaMessageLabel = "SS_waza_remember_037";

	private const string SwapWazaResultMessageLabel = "SS_waza_remember_040";

	private const string SelectSwapWazaMessageLabel = "SS_waza_remember_042";

	private const string ConfirmDontLearnWazaMessageLabel = "SS_waza_remember_043";

	private const string ConfirmSwapWazaMessageLabel = "SS_waza_remember_045";

	[SerializeField]
	private GameObject bgObject;

	[SerializeField]
	private GameObject withWazaBgObject;

	[SerializeField]
	private PokemonStatusTab[] categoryTabs;

	[SerializeField]
	private GameObject[] statusPanelObjects;

	[SerializeField]
	private Image[] categoryTabCornerImages;

	[SerializeField]
	private WazaManageWazaStatusPanel[] wazaStatusPanels;

	[SerializeField]
	private Image pokemonInfoMonsterBallImage;

	[SerializeField]
	private RectTransform pokemonInfoSelectArrowRoot;

	[SerializeField]
	private UIText pokemonInfoName;

	[SerializeField]
	private UIText pokemonInfoLevel;

	[SerializeField]
	private Image pokemonInfoSex;

	[SerializeField]
	private Image pokemonInfoLanguage;

	[SerializeField]
	private PokemonSick pokemonInfoSick;

	[SerializeField]
	private WazaManagePokemonStausPanel battlePokemonStatusPanel;

	[SerializeField]
	private WazaManagePokemonStausPanel contestPokemonStatusPanel;

	[SerializeField]
	private WazaManageCondition statusPanelCondition;

	private UIMsgWindowController msgWindowController;

	private List<PokemonStatusTab> activeTabs;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private int selectTabIndex;

	private Param param;

	public override void OnCreate()
	{
	}

	public void Open(Param param)
	{
	}

	public IEnumerator OpOpen()
	{
		return null;
	}

	private void SetupPokemonInfo()
	{
	}

	private void SetupKeyGuide()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateSelectTab(float deltaTime)
	{
	}

	private void UpdateSelectWaza(float deltaTime)
	{
	}

	private bool SetSelectTabIndex(int selectTabIndex, bool isForce = false)
	{
		return default(bool);
	}
}
