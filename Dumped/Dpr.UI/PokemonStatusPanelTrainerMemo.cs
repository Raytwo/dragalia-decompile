using System;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class PokemonStatusPanelTrainerMemo : PokemonStatusPanel
{
	[Serializable]
	private class PanelParam
	{
		public RectTransform root;

		public UIText[] texts;
	}

	private enum PanelType
	{
		Normal,
		Egg
	}

	private enum EncounterId
	{
		L26_02_01_1 = 26,
		L27_02_01_2 = 27,
		L28_02_02_1 = 28,
		L29_02_02_2 = 29,
		L30_02_03_1 = 30,
		L31_02_03_2 = 31,
		L32_02_04_1 = 32,
		L33_02_04_2 = 33,
		L34_02_05_1 = 34,
		L35_02_05_2 = 35,
		L36_02_06_1 = 36,
		L37_02_06_2 = 37,
		L38_02_07_1 = 38,
		L39_02_07_2 = 39,
		L40_02_08_1 = 40,
		L41_02_08_2 = 41,
		L42_02_09_1 = 42,
		L43_02_09_2 = 43,
		L44_02_10_1 = 44,
		L45_02_10_2 = 45,
		L80_T01_01 = 80,
		L81_T01_02 = 81,
		L82_T01_03 = 82,
		L83_T01_04 = 83,
		L95 = 95,
		L96 = 96,
		L97 = 97,
		L98 = 98
	}

	private class EggStateParam
	{
		public int value;

		public string label;
	}

	private enum PlaceNo
	{
		START_PERSON = 60001,
		SPECIAL_OUTER_TRADE = 30002,
		SPECIAL_MEGATURTLE = 30018,
		SPECIAL_MEGATURTLE2 = 40086,
		UNKNOWN = 65535,
		TOOKUHANARETATOTI = 30007,
		HOUEN = 30005,
		KANTO = 30003,
		ZYOTO = 30004,
		SINOH = 30006,
		IISHU = 30009,
		KAROSU = 30010,
		CTR_HOUEN = 30014,
		AROORA = 30015,
		HOLOHOLO = 30012,
		VC_KANTO = 30013,
		VC_ZYOTO = 30017,
		LETSGO_KANTO = 30019,
		GARARU = 30020,
		HAYABUSA = 30021
	}

	[SerializeField]
	private PanelParam[] _panels;

	private EggStateParam[] _eggStateParams;

	private bool _isLayoutUpdate;

	private void Awake()
	{
	}

	public override void Setup(PokemonParam pokemonParam)
	{
	}

	private void LateUpdate()
	{
	}

	private int GetEncounterId()
	{
		return default(int);
	}

	private bool IsVc(uint version)
	{
		return default(bool);
	}

	private bool IsOtherVersion(uint iVersion)
	{
		return default(bool);
	}

	private bool IsMegaTurtle(PlaceNo place2)
	{
		return default(bool);
	}

	private bool IsMegaTurtle(PokemonParam pokemonParam)
	{
		return default(bool);
	}

	private bool IsMegaTurtleEvent(PokemonParam pokemonParam)
	{
		return default(bool);
	}

	private void SetupEncounterText(UIText uiText)
	{
	}

	private uint GetExternalPlaceNo(uint cassetteVersion)
	{
		return default(uint);
	}

	private void SetPlaceNameWord(int index, uint place)
	{
	}

	private void SetEggStateText(UIText uiText)
	{
	}

	public override void Select(bool enabled)
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}
}
