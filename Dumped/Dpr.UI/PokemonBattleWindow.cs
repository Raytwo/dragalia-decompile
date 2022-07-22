using System.Collections;
using System.Collections.Generic;
using Dpr.Battle.Logic;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class PokemonBattleWindow : PokemonWindowBase
{
	private enum SelectType
	{
		Party,
		Waza
	}

	public enum PositionType
	{
		None = -1,
		Left,
		Right
	}

	public enum SwapNumber
	{
		one = 1,
		two
	}

	public class Param : BaseParam
	{
		public enum BattleType
		{
			Normal,
			Double,
			MultiPlayer,
			Safari
		}

		public BattleType battleType;

		public BTL_POKEPARAM leftPokeParam;

		public BTL_POKEPARAM rightPokeParam;

		public BTL_POKEPARAM swapWaitPokemon;

		public bool isCancel;

		public bool isSwap;

		public bool isSwapRuleSwap;

		public bool isPokeList;

		public bool isBattleTower;

		public bool isNet;
	}

	[SerializeField]
	private PokemonPanelBattle _battle;

	private SelectType _selectType;

	private Param _param;

	private PokeSelParam _selParam;

	private Dictionary<PositionType, BTL_POKEPARAM> selectedPokemonDict;

	private List<PokemonParam> _pokemonParams;

	private BTL_POKEPARAM _currentPokemon;

	public UnityAction<List<BTL_POKEPARAM>, PositionType> onPokemonSwap;

	public UnityAction OnSwapCancel;

	public override void OnCreate()
	{
	}

	public void Open(Param param, PokeSelParam selParam, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, PokeSelParam selParam, UIWindowID prevWindowId)
	{
		return null;
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private int GetPlateType(int index)
	{
		return default(int);
	}

	private int GetMemberCount()
	{
		return default(int);
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetSelectType(SelectType selectType)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void OnSelectChangedPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void OnClickPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void OpenContextMenu(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void OpenBagWindow(UIBag.ModeType modeType, PokemonParam selectPokemonParam)
	{
	}

	private void PokemonSwap(BTL_POKEPARAM pokeParam, PositionType posType = PositionType.None)
	{
	}

	private int GetSwapPokmeonNum()
	{
		return default(int);
	}

	private int GetSelectedPokemonNum()
	{
		return default(int);
	}

	private BTL_POKEPARAM GetSelectedPokeParam()
	{
		return null;
	}

	private void SetSelectPokemonParam(BTL_POKEPARAM pokeParam, PositionType posType)
	{
	}

	private PositionType GetEmptyPositionType()
	{
		return default(PositionType);
	}

	private void ResetSelectPokemonParam()
	{
	}

	private List<ContextMenuItem.Param> GetContextMenuItems(BTL_POKEPARAM pokeParam, PokemonPartyItem partyItem)
	{
		return null;
	}

	private bool IsRecovery(BTL_POKEPARAM pokeParam)
	{
		return default(bool);
	}

	private bool IsSwapWaitPokemon(BTL_POKEPARAM param)
	{
		return default(bool);
	}
}
