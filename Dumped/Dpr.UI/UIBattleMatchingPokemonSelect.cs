using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.SubContents;
using UnityEngine;

namespace Dpr.UI;

public class UIBattleMatchingPokemonSelect : UIWindow
{
	[SerializeField]
	private UIBattleMatchingTimer _timer;

	[SerializeField]
	private UIBattleMatchingTeamPlate _teamPlate;

	[SerializeField]
	private PokemonParty _pokemonParty;

	[SerializeField]
	private UIBattleMatchingPokemonItem[] _pokemonItems;

	[SerializeField]
	private RectTransform _decide;

	[SerializeField]
	private Cursor _cursor;

	private PokemonStatusWindow _pokemonStatusUI;

	private UIBattleMatchingTeamSelect _teamSelectUI;

	private ContextMenuWindow _contextMenu;

	private Action _onDecide;

	private Action _onCancel;

	private Action _onUpdateTimer;

	private bool _isBattleTower;

	private bool _decideFade;

	private bool _isOpeningStatus;

	private bool _isOpeningTeam;

	private int _currentIndex;

	private int _maxIndex;

	private int _requiredNumMin;

	private int _requiredNumMax;

	private List<int> _joinIndexList;

	private bool _isOpeningMessage;

	private ShowMessageWindow _msgWindow;

	private readonly Vector2 MSG_WINDOW_ANCHOR_POS;

	public Action onUpdateTimer
	{
		set
		{
		}
	}

	public override void OnCreate()
	{
	}

	public void Open(Action onDecide, [Optional] Action onCancel, bool battleTower = false, bool decideFade = false, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
	}

	public void PreClose()
	{
	}

	public void Close()
	{
	}

	public IEnumerator OpClose()
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void RemainingWarningText(bool warning = true)
	{
	}

	public void UpdateUITimeText(string minutes, string seconds)
	{
	}

	public void TimeUp()
	{
	}

	private bool UpdateSelect(float deltaTime)
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex)
	{
		return default(bool);
	}

	private void SelectComplete(bool complete)
	{
	}

	private void SetCursorDecide(bool decide)
	{
	}

	private void OpenContextMenu()
	{
	}

	private void SetContextMenuPositionParams(ContextMenuWindow.Param param, RectTransform transPartyItem, int selectIndex, float posZ)
	{
	}

	private void SetNumber()
	{
	}

	private void OpenKeyguide()
	{
	}

	public void CloseKeyGuide()
	{
	}
}
