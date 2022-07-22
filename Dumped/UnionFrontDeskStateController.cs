using System;
using SmartPoint.AssetAssistant;

public class UnionFrontDeskStateController : SingletonMonoBehaviour<UnionFrontDeskStateController>
{
	public enum FrontDeskNpcState
	{
		NONE,
		START,
		CHANGE_CONNECT,
		DESCRIPTION,
		TALK
	}

	private static readonly ZoneID ZONE_COMMUNITY;

	private static readonly ZoneID ZONE_GLOBAL;

	private static readonly string UNION_ROOM_MANAGER;

	private const int MESSAGE_INDEX_TRADE_DESCRIPTION = 1;

	private const int MESSAGE_INDEX_TRADE_TIMEOUT = 3;

	private static bool IsStart;

	public bool isTalkEnd;

	public bool isNotFirst;

	public bool isFirstInternetCheck;

	private UnionFrontDeskMsgWindow msgWindow;

	private UnionFrontDeskContextMenu contextMenu;

	private ZoneID currentZoneID;

	public UnionRoomManager roomManager;

	public UnionStateTransitionController transitionController;

	public Action _FadeOut;

	public Action _OpenTradeSelectWindow;

	public bool isGlobal => default(bool);

	public void Init()
	{
	}

	public void Clear()
	{
	}

	public void SetFade(UnionStateTransitionController controller)
	{
	}

	public void SetOpenTradeWindow(Action<int, bool> openSelectWindow)
	{
	}

	public void SetSendRequet(Action func)
	{
	}

	public void TimeOut()
	{
	}

	public void Cancel()
	{
	}

	private void Close()
	{
	}

	private void StartMessage()
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

	private void OpenContextSelectInternetYesNoMenu()
	{
	}

	private void OpenContextSelectTradeYesNoMenu()
	{
	}

	private void OpenContextYesNoMenu(Action<int> selectFunc)
	{
	}

	private void FindTradePlayer()
	{
	}

	public void Transition()
	{
	}

	private void SelectContextMenuRequirements(int selectIndex)
	{
	}

	private void SelectContextMenuDescription(int selectIndex)
	{
	}

	private void SelectContextMenuInternetMode(int selectIndex)
	{
	}

	private void SelectInternetCheck(int select)
	{
	}

	private void SelectTradeStart(int select)
	{
	}

	public void ChangeInternetMode()
	{
	}

	public bool CheckPenarty()
	{
		return default(bool);
	}

	private void SwitchMessageTrade()
	{
	}

	private void InternetCheck()
	{
	}

	private void StartTransition()
	{
	}
}
