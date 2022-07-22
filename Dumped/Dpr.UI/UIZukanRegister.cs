using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIZukanRegister : UIWindow
{
	private enum BootType
	{
		Default,
		RegisterOnly,
		AddMemberOnly,
		InputNickName
	}

	public enum AddMemberResult
	{
		Party,
		Box,
		Cancel
	}

	public enum PartyTradeResult
	{
		Success,
		Cancel,
		CantTrade
	}

	private const string RegisterNewMessageLabel = "SS_pokedex_049";

	private const string QuestionInputNickNameMessageLabel = "SS_pokedex_053";

	private const string QuestionSendToMessageLabel = "SS_pokedex_057";

	private const string QuestionSwapMemberMessageLabel = "SS_pokedex_060";

	private const string ResultAddMemberMessageLabel = "SS_pokedex_062";

	private const string ResultTradeMemberMessageLabel = "SS_pokedex_063";

	private const string ResultSendToBoxMessageLabel = "SS_pokedex_064";

	private const string CantTradePokemonMessageLabel = "SS_pokedex_124";

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	[SerializeField]
	private ZukanDescriptionPanel descriptionPanel;

	[SerializeField]
	private RectTransform descriptionHideModelViewPositionRectTransform;

	[SerializeField]
	private RectTransform contextMenuPositionRectTransform;

	private UIMsgWindowController msgWindowController;

	private BootType bootType;

	private bool isWaitUpdate;

	private bool isRegisterNew;

	private bool isNotAddMember;

	private bool isSkipAddMemberProc;

	private PokemonParam pokemonParam;

	private AddMemberResult addMemberResult;

	public event Action<AddMemberResult> OnComplete
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public override void OnCreate()
	{
	}

	public void Open(PokemonParam pokemonParam, bool isSkipAddMemberProc = false, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void OpenRegisterOnly(PokemonParam pokemonParam, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void OpenAddMemberOnly(PokemonParam pokemonParam, bool isNotAddMember = false, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public void OpenInputNickName(PokemonParam pokemonParam, bool isNotAddMember = false, UIWindowID prevWindowId = (UIWindowID)(-1))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
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

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnUpdateDefault()
	{
	}

	private void OnUpdateDescriptionPanel()
	{
	}

	private void Initialize()
	{
	}

	private void ShowRegisterNewMessage()
	{
	}

	private void ShowInputNickNameMessage()
	{
	}

	private void AddMemberProc()
	{
	}

	private void ShowSelectPokemonProcContextMenu()
	{
	}

	private void End()
	{
	}

	private void OpenPokemonStatusWindow(PokemonStatusWindow.Param param, Action onClosedAction)
	{
	}

	private void BeforeSendBoxProc(PokemonParam pokemonParam, Action onComplete)
	{
	}
}
