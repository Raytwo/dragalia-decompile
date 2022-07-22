using System.Collections;
using Dpr.Contest;
using Dpr.EvScript;
using Dpr.MsgWindow;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class UIContPokeSelect : UIWindow, IContestUIWindow
{
	[SerializeField]
	private MenuHeader _header;

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private PokemonParty _uiPokeParty;

	[SerializeField]
	private ConditionRaderChart _rader;

	[SerializeField]
	private ConditionFur _uiConditionFur;

	private KeyGuideCreater _keyGuide;

	private EvWork.WORK_INDEX _resultWorkIndex;

	private ContestMenuEventID _resultEventID;

	private MsgWindowParam msgWindowParam;

	private Dpr.MsgWindow.MsgWindow msgWindowPtr;

	private uint startSelectIndex;

	private bool _bInputed;

	private bool _bIsOpen;

	private bool _bIsOpening;

	private bool _bIsMulti;

	public bool IsOpen => default(bool);

	public ContestMenuEventID ResultEventID => default(ContestMenuEventID);

	public override void OnCreate()
	{
	}

	private void SetErrorMsgParam()
	{
	}

	public void OpenSingleMode(int resultWorkIndex, UIWindowID prevWindowId)
	{
	}

	public void OpenMultiMode(UIWindowID prevWindowId, string minutStr, string secondStr)
	{
	}

	private IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	private PokemonParty.Param CreatePokemonPartyParam()
	{
		return null;
	}

	private void OnClickPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void OnChangedPartyItem(PokemonPartyItem partyItem, int selectIndex)
	{
	}

	private void UpdatePokemonStatus(PokemonParam selectPokemonParam)
	{
	}

	private void SetupModelView(PokemonParam pokemonParam)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateInput()
	{
	}

	private void UpdateInpuInOpenWindow()
	{
	}

	public void CloseWindow()
	{
	}

	private void CloseSingleMode()
	{
	}

	private IEnumerator TransitionSelectContestWazaMenu()
	{
		return null;
	}

	private void CloseMultiMode()
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}

	private void ClosedMenu()
	{
	}

	public void SetTimeCount(string minutStr, string secondStr)
	{
	}

	private void ResetContestParam()
	{
	}
}
