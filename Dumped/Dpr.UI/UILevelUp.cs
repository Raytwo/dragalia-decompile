using System.Collections;
using Dpr.Battle.Logic;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UILevelUp : UIWindow
{
	public struct PokemonStatus
	{
		public uint Level;

		public uint Exp;

		public uint Hp;

		public uint Attack;

		public uint Deffence;

		public uint SpecialAttack;

		public uint SpecialDeffence;

		public uint Agility;

		public PokemonStatus(CoreParam coreParam)
		{
		}
	}

	public struct Param
	{
		public uint[] AddExpValues;

		public int TargetIndex;

		public int LevelUpCount;

		public PokeParty PokeParty;

		public BattleViewBase.ExpGetResult BattleExpGetResult;

		public void Clear()
		{
		}
	}

	private const string GetExpMessageLabel = "SS_level_up_02_01";

	private const string GetExpSingleMessageLabel = "SS_level_up_02_08";

	private const string LevelUpMessageLabel = "SS_level_up_02_02";

	private const string ResultLearnWazaMessageLabel = "SS_level_up_02_03";

	private const string ResultLearnWazaMessageLabel_Evolve = "SS_shinka_demo_04_01";

	private const string QuestionSwapWazaMessageLabel = "SS_level_up_02_04";

	private const string ResultSwapWazaMessageLabel = "SS_level_up_02_05";

	private const string ResultNotLearnWazaMessageLabel = "SS_level_up_02_06";

	private static readonly string[] QuestionSwapWazaContextMenuMessageLabels;

	private static readonly string[] QuestionSwapWazaContextMenuMessageLabels_Evolve;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	[SerializeField]
	private LevelUpPokemonPanel[] levelUpPokemonPanels;

	[SerializeField]
	private LevelUpStatusPanel statusPanel;

	private Param param;

	private UIMsgWindowController msgWindowController;

	private bool isAnimateGauge;

	private bool isPlayGaugeUpSe;

	private bool isPlayLevelUpSe;

	private bool isWaitExit;

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

	public static void WazaOboeSequence(UIMsgWindowController msgWindowController, WazaNo wazaNo, WazaLearningResult WazaResult, PokemonParam param, bool isEvolve = false)
	{
	}

	private void SetupPokemonPanels()
	{
	}

	private void ApplyParam()
	{
	}

	private void PlayGaugeUpSe()
	{
	}

	private void PlayLevelUpSe()
	{
	}

	private static void ShowLearnWazaWindow(PokemonParam pokemonParam, WazaNo wazaNo, UIMsgWindowController msgWindowController)
	{
	}
}
