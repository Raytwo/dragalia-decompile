namespace Dpr.Battle.Logic;

public sealed class TrainerMessageManager
{
	private sealed class ClientData
	{
		public bool[] isDone;
	}

	private readonly MainModule m_pMainModule;

	private ClientData[] m_clientData;

	public TrainerMessageManager(MainModule pMainModule)
	{
	}

	private void ClearClientData()
	{
	}

	public bool IsMessageExist(byte clientID, TrainerMessageID messageID)
	{
		return default(bool);
	}

	public void Done(byte clientID, TrainerMessageID messageID)
	{
	}
}
