using System.Runtime.InteropServices;
using Dpr.Battle.Logic.Net;

namespace Dpr.Battle.Logic;

public sealed class Adapter
{
	private enum State
	{
		kFree,
		kCmdRecieved,
		kWaitSendToClient,
		kWaitRecvFromClient,
		kDone
	}

	private Client m_iPtrNetClient;

	private SendData m_sendData;

	private SendData m_returnData;

	private ServerRequest m_processingRequest;

	private byte m_myClientId;

	private State m_state;

	private bool m_isRetDataPrepared;

	private bool m_isCommMode;

	private RaidActionIconID m_raidActionIcon;

	public Adapter(byte clientID, bool isCommMode, Client iPtrNetClient)
	{
	}

	public void Init()
	{
	}

	public void ChangeToNonCommMode()
	{
	}

	public bool IsWaitingClientReply()
	{
		return default(bool);
	}

	public unsafe void SetCmd(ushort serialNumber, ServerSequence serverSeq, ServerRequest serverReq, void* sendData, uint sendDataSize)
	{
	}

	public bool WaitCmd()
	{
		return default(bool);
	}

	public SendData GetReturnData()
	{
		return null;
	}

	public void ResetCmd()
	{
	}

	public void ClearRecvData()
	{
	}

	private bool startToReception()
	{
		return default(bool);
	}

	private bool receptionClient()
	{
		return default(bool);
	}

	public void ResetRecvBuffer()
	{
	}

	public void RecvCmd(ref ServerRequest serverReq, ref ushort commandSerialNumber, ref ServerSequence serverSeq)
	{
	}

	public unsafe uint GetRecvData(void** ppRecv)
	{
		return default(uint);
	}

	public bool ReturnCmd([In] ref SendData returnData)
	{
		return default(bool);
	}

	public RaidActionIconID GetRaidAction(BTL_CLIENT_ID clientID)
	{
		return default(RaidActionIconID);
	}

	public void SetRaidAction(RaidActionIconID action)
	{
	}

	public void ClearRaidAction()
	{
	}

	public bool CheckTrainerActionRequest(BTL_CLIENT_ID clientID)
	{
		return default(bool);
	}

	public void SetTrainerActionRequest()
	{
	}

	public void ClearTrainerActionRequest()
	{
	}
}
