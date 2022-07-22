using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.UI;
using UnityEngine;

public class UnionContextMenu
{
	public struct ContextMenuData
	{
		public string messageFileName;

		public string[] messageList;

		public Vector2 menuPosition;

		public float minItemWidth;

		public bool isChangeSelectFrame;

		public ContextMenuWindow.CursorType cursorType;

		public bool useLoopAndRepeat;
	}

	public enum RecruitmentMenu
	{
		BATTLE,
		TRADE,
		RECODE,
		GREETINGS,
		BALL_DECO,
		NONE
	}

	public enum BattleType
	{
		SINGLE,
		DOUBLE,
		MIX,
		MULTI,
		NONE
	}

	protected static readonly Vector2 CONTEXT_RECRUITMENT_MENU_POSITION;

	protected static readonly Vector2 CONTEXT_BATTLE_MENU_POSITION;

	protected static readonly Vector2 CONTEXT_START_MENU_POSITION;

	private static int UNION_MSG_INDEX;

	public Action<int> _UnionMenuSelect;

	public Action<int, int> _BattleRuleSelect;

	public Action _Fade;

	public Action _LeaveUnion;

	public Action<OpcState.OnlineState, NetStateModel.StateModelType> _CreateStateModel;

	protected string messageFileName;

	protected List<string> _menuMessageList;

	protected ContextMenuWindow contextMenuWindow;

	protected int transitionType;

	private bool isContextOpen;

	private ZoneID zoneID;

	private Vector3 returnPosition;

	public UnionSystemController systemController
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Clear()
	{
	}

	public void SetZoneID(ZoneID zoneId)
	{
	}

	public void SetCallBack(Action leaveUnion, Action<OpcState.OnlineState, NetStateModel.StateModelType> createStateModel)
	{
	}

	public string GetUnionMenuText(int index)
	{
		return null;
	}

	public void CreateContextMenu(OnlinePlayerCharacter onlinePlayerCharacter)
	{
	}

	public void CreateEmoticonSelctContextMenu(OnlinePlayerCharacter onlinePlayerCharacter, string mFileName, string[] MenuMessagesList)
	{
	}

	public void CreateContextBattleTypeMenu(OnlinePlayerCharacter onlinePlayerCharacter)
	{
	}

	private void SendStateData(OnlinePlayerCharacter onlinePlayerCharacter, OpcState.OnlineState state)
	{
	}

	protected void SendTransitionData(int targetIndex, int isRecruitment = 0)
	{
	}

	protected void SendCancelData(int targetIndex, OpcState.OnlineState state)
	{
	}

	public void ShowYesNoWindow(Action<int> SelectFunc)
	{
	}

	public void CloseContextWindow()
	{
	}

	public ContextMenuWindow GetOpenMenu()
	{
		return null;
	}

	private void SetIsOpen(bool isOpen)
	{
	}

	public bool IsOpen()
	{
		return default(bool);
	}

	public void SetUnderModeInputActive()
	{
	}
}
