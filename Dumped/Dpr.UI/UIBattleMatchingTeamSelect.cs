using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.SubContents;
using Pml;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class UIBattleMatchingTeamSelect : UIWindow
{
	private enum UIState
	{
		MatchingMenu,
		OpenUIMenu,
		ClosingUIMenu,
		Closed
	}

	private enum RegulationType
	{
		None,
		Empty,
		NotEnoughNum,
		Legend,
		SamePokemon,
		SameItem,
		Illegal
	}

	[SerializeField]
	private UIBattleMatchingTimer _timer;

	[SerializeField]
	private UIBattleMatchingTeamPlate[] _teamPlates;

	[SerializeField]
	private GameObject[] _objArrows;

	private const float CLOSING_INTERVAL = 0.5f;

	private BoxWindow _boxWindow;

	private Action _onDecide;

	private Action _onCancel;

	private UIState _currentState;

	private bool _cancelFade;

	private bool _closed;

	private bool _showFirstMessage;

	private bool _isServerError;

	private Dictionary<uint, bool> _illegalList;

	private int _currentIndex;

	private ShowMessageWindow _msgWindow;

	private float _closingProgressTime;

	private readonly string[] YESNO_CONTEXTMENU_LABELS;

	private readonly Vector2 MSG_WINDOW_ANCHOR_POS;

	public bool isActiveKeyGuide
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

	public bool IsServerError => default(bool);

	public override void OnCreate()
	{
	}

	public void Open(Action onDecide, Action onCancel, bool firstOpen = false, bool fadeIn = false, bool cancelFade = false, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId, bool firstOpen = false, bool fadeIn = false)
	{
		return null;
	}

	public void OpenTeam(Action onCancel, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpenTeam(UIWindowID prevWindowId)
	{
		return null;
	}

	public bool CanClose()
	{
		return default(bool);
	}

	public void PreClose()
	{
	}

	public void Close(bool isCloseCB = false)
	{
	}

	public IEnumerator OpClose(bool isCloseCB = false)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateMatchingMenu()
	{
	}

	private void OnUpdateClosingUIMenu(float deltaTime)
	{
	}

	private void SetKeyguide(bool backOnly = false)
	{
	}

	private void CloseKeyGuide()
	{
	}

	private void SetActiveArrow(bool active)
	{
	}

	public void RemainingWarningText(bool warning = true)
	{
	}

	public void UpdateUITimeText(string minutes, string seconds)
	{
	}

	private void OpenBox()
	{
	}

	private IEnumerator CloseBox()
	{
		return null;
	}

	private void MoveTeam(bool right)
	{
	}

	private void SelectTeam(int index)
	{
	}

	private int GetPrevIndex()
	{
		return default(int);
	}

	private int GetNextIndex()
	{
		return default(int);
	}

	private void SetTeam()
	{
	}

	private PokemonParam[] GetPokemonParams(int index)
	{
		return null;
	}

	private bool[] GetRegulations(PokemonParam[] pokemonParams)
	{
		return null;
	}

	private RegulationType GetRegulation(PokemonParam[] pokemonParams)
	{
		return default(RegulationType);
	}

	private void GetRegulation(PokemonParam[] pokemonParams, ref List<MonsNo> monsNoList, ref List<ItemNo> itemNoList)
	{
	}

	private bool IsRegulationEmpty(PokemonParam[] pokemonParams)
	{
		return default(bool);
	}

	private bool IsRegulationNotEnoughNum(PokemonParam[] pokemonParams)
	{
		return default(bool);
	}

	private bool IsRegulationLegend(MonsNo monsNo)
	{
		return default(bool);
	}

	private bool IsRegulationSamePokemon(List<MonsNo> monsNoList, MonsNo monsNo)
	{
		return default(bool);
	}

	private bool IsRegulationSameItem(List<ItemNo> itemNoList, ItemNo itemNo)
	{
		return default(bool);
	}

	private bool IsRegulationIllegal(uint id)
	{
		return default(bool);
	}

	private IEnumerator CheckIllegal(Action onFinish)
	{
		return null;
	}

	private void DecideTeam()
	{
	}

	private void Decide()
	{
	}

	private void Back()
	{
	}

	private void ShowDefaultMessageWindow(bool firstOpen = false)
	{
	}

	private void ShowInputCloseMessageWindow(string msbt, string label, [Optional] Action onCloseed)
	{
	}

	private void ShowConfirmYesNoMsg(string message, [Optional] Action onSelectYes, [Optional] Action onSelectNo)
	{
	}

	private new void CloseMessageWindow()
	{
	}

	private void OpenContextMenu(string[] contextLabels, Action<int> onSelect)
	{
	}

	private void CloseContextMenu()
	{
	}
}
