using System;
using System.Collections;
using Dpr.Contest;
using Dpr.MsgWindow;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class UIFureaiPokeSelect : UIWindow
{
	[SerializeField]
	private MenuHeader _header;

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private PokemonParty _uiPokeParty;

	private KeyGuideCreater _keyGuide;

	private ContestMenuEventID _resultEventID;

	private MsgWindowParam msgWindowParam;

	private Dpr.MsgWindow.MsgWindow msgWindowPtr;

	private bool _bInputed;

	private bool _showModel;

	public Action<int> GetTemotiNo;

	public override void OnCreate()
	{
	}

	private void SetErrorMsgParam(bool isEgg)
	{
	}

	public void Open(int resultWorkIndex)
	{
	}

	private IEnumerator OpOpen()
	{
		return null;
	}

	private void ResetContestParam()
	{
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

	private void OpenMsgWindow()
	{
	}

	private void UpdateInpuInOpenWindow()
	{
	}

	private void CloseWindow(int selectIndex)
	{
	}

	private IEnumerator OpClose()
	{
		return null;
	}

	private void ClosedMenu()
	{
	}
}
