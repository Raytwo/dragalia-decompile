using System;
using System.Collections.Generic;
using Dpr.UI;
using UnityEngine;

public class UnionFrontDeskContextMenu
{
	protected static readonly Vector2 CONTEXT_BATTLE_MENU_POSITION;

	private ContextMenuWindow contextMenuWindow;

	private List<string> messgaeList;

	public Action<int> _selectRequirementsMenu;

	public Action<int> _selectDescriptionMenu;

	public Action<int> _selectInternetModeMenu;

	public Action<int> _selectBattleRuleMenuLocal;

	public Action<int> _selectBattleRuleMenuInternet;

	public void CreateContextRequirementsMenu()
	{
	}

	public void CreateContextDescriptionMenu()
	{
	}

	public void CreateContextInternetMenu()
	{
	}

	public void CreateContextColiseumMenu()
	{
	}

	public void CreateContextBattleRuleMenu()
	{
	}

	public void ShowYesNoWindow(Action<int> selectFunc)
	{
	}

	public void Close()
	{
	}
}
