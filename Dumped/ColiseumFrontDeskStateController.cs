using System;
using SmartPoint.AssetAssistant;

public class ColiseumFrontDeskStateController : SingletonMonoBehaviour<ColiseumFrontDeskStateController>
{
	public enum FrontDeskNpcState
	{
		NONE,
		START,
		CHANGE_CONNECT,
		DESCRIPTION,
		TALK
	}

	private static readonly string UNION_ROOM_MANAGER;

	private const int MESSAGE_INDEX_TRADE_DESCRIPTION = 1;

	private const int MESSAGE_INDEX_TRADE_TIMEOUT = 3;

	private static bool IsStart;

	public bool isTalkEnd;

	public bool isNotFirst;

	public bool isFirstInternetCheck;

	public bool isInternet;

	public bool isMultiBattleRoom;

	private UnionFrontDeskMsgWindow msgWindow;

	private UnionFrontDeskContextMenu contextMenu;

	private UnionFrontDeskMsgWindow ruleMsgWindow;

	private void OnDestroy()
	{
	}

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void Cancel()
	{
	}

	public void StartTalk()
	{
	}

	public void CreateUI()
	{
	}

	public void SetIsStart(bool start)
	{
	}

	public bool GetIsStart()
	{
		return default(bool);
	}

	public void TalkEnd()
	{
	}

	public void SetIsTalkEnd(bool isEnd)
	{
	}

	public bool GetIsTalkEnd()
	{
		return default(bool);
	}

	private void TalkMessageRequirements()
	{
	}

	private void OpenContextSelectChangeBattleRuleYesNoMenu()
	{
	}

	private void OpenContextYesNoMenu(Action<int> selectFunc)
	{
	}

	private void FindTradePlayer()
	{
	}

	private void SelectContextMenuRequirements(int selectIndex)
	{
	}

	private void SelectContextMenuBattleRuleLocal(int selectIndex)
	{
	}

	private void SelectContextMenuBattleRuleInternet(int selectIndex)
	{
	}

	private void SelectChangeBattleRuleCheck(int select)
	{
	}

	private void InternetCheck()
	{
	}
}
