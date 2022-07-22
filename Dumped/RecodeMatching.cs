using System;
using DPData;
using Dpr.MsgWindow;
using Dpr.NetworkUtils;
using Dpr.UI;

public class RecodeMatching : UIWindow
{
	private struct RecodeData
	{
		public int staIndex;

		public RECORD recode;

		public RANDOM_SEED group;

		public RECORD_HEAD recodeHeadData;

		public TvWork.RecordData tvRecord;
	}

	private enum TopicData
	{
		PERSONALITY,
		BALL_DECO,
		KASEKIHORI,
		STATUE,
		FASHION
	}

	private Action _onClose;

	private const string MESSAGE_FILE = "dp_net_communication";

	private RecodeData _recodeData;

	private int _otherStationIndex;

	private bool _isTradingRecode;

	private bool _isReceivedRecode;

	private bool _isSendRecode;

	private bool _isEndTrading;

	private bool _isShowingCloseMessage;

	private float _waitProgressTime;

	private bool _waitingTime;

	private bool _isError;

	public void Init()
	{
	}

	public void Open(int otherStationIndex, Action onClose)
	{
	}

	public void Close()
	{
	}

	private void CloseFlow()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void LeaveMine()
	{
	}

	public void LeaveOther()
	{
	}

	protected override void OpenMessageWindow(MsgWindowParam messageParam)
	{
	}

	private void ShowCloseMessage(bool cancel)
	{
	}

	private void StartRecodeTrade()
	{
	}

	private void WaitMinTime()
	{
	}

	private void AddRecodeMatching(int index, RANDOM_SEED groupData, RECORD recodeData, RECORD_HEAD recodeHeadData, TvWork.RecordData tvRecord)
	{
	}

	private void StartRecodeTradeFlow()
	{
	}

	private void ApplyTvRecode()
	{
	}

	private void RecodeTradeEnd()
	{
	}

	public void ReceiveData(INetData netData)
	{
	}

	private void ReceiveRecodeData(NetDataRecodeData data)
	{
	}

	private void SendRecodeData()
	{
	}
}
