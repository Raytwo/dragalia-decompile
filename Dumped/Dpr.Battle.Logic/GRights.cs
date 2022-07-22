using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class GRights
{
	private class ClientInfo
	{
		public BTL_CLIENT_ID clientID;

		public bool isInvalid;

		public void CopyFrom(ClientInfo src)
		{
		}
	}

	private readonly MainModule m_pMainModule;

	private readonly BattleEnv m_pBattleEnv;

	private ClientInfo[] m_clientInfo;

	private byte m_clientNum;

	private byte m_assignedClientIdx;

	private uint m_passedTurnCount;

	public GRights(MainModule pMainModule, BattleEnv pBattleEnv)
	{
	}

	public void Initialize()
	{
	}

	public void CopyFrom([In] ref GRights src)
	{
	}

	public bool IsGRightsRegulationExist()
	{
		return default(bool);
	}

	public void AddClient(BTL_CLIENT_ID clientID)
	{
	}

	public void InvalidateClient(BTL_CLIENT_ID clientID)
	{
	}

	public byte GetClientNum()
	{
		return default(byte);
	}

	public int GetClientOrder(BTL_CLIENT_ID clientID)
	{
		return default(int);
	}

	public BTL_CLIENT_ID GetClientByOrder(byte order)
	{
		return default(BTL_CLIENT_ID);
	}

	public BTL_CLIENT_ID GetAssignedClient()
	{
		return default(BTL_CLIENT_ID);
	}

	public bool TransferRights()
	{
		return default(bool);
	}

	private byte getNextAssignTarget(byte currentIdx)
	{
		return default(byte);
	}

	private bool isAssignEnable([In] ref ClientInfo clientInfo)
	{
		return default(bool);
	}

	public uint GetPassedTurnCount()
	{
		return default(uint);
	}

	public void IncPassedTurnCount()
	{
	}
}
