using System;
using System.Runtime.CompilerServices;
using Dpr.NetworkUtils;

public class UnionBattleContextMenu : UnionContextMenu
{
	public Action<int, int, int> _setMatchPlayerData;

	public BattleRecruitmentStateModel battleRecruitmentModel
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

	public BattleJoinStateModel battleJoinModel
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

	public void SetCallBack(Action<int, int, int> setMacthFunc)
	{
	}

	public void ClearCallBack()
	{
	}

	public void CreateContextBattleTypeMenu(string mFileName, string[] MenuMessagesList, int stationIndex)
	{
	}

	public void ShowBattleJoinYesNoWindow(int targetIndex, Action<int, BattleModeID> decide, Action<int> cancel)
	{
	}

	public void ShowBattleRecruitmentYesNoWindow(int targetIndex)
	{
	}

	public void ShowBattleJoinOtherYesNoWindow(int targetIndex, Action<int> decide, Action cancel)
	{
	}

	public void SetActionFade(Action fadeFunc)
	{
	}

	public void SetTransitionType()
	{
	}

	private void SendRuleSelectState(int targetIndex)
	{
	}

	private void SendIsMatchWaitData()
	{
	}

	private void SendRequestIsMatchWaitData(int stationIndex)
	{
	}
}
