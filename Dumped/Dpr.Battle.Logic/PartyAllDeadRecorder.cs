namespace Dpr.Battle.Logic;

public sealed class PartyAllDeadRecorder
{
	public const byte DEAD_ORDER_NONE = 5;

	private byte[] m_partyAllDeadOrder;

	public void Clear()
	{
	}

	public void RecordPartyAllDead(byte clientID)
	{
	}

	public byte GetAllDeadOrder(byte clientID)
	{
		return default(byte);
	}
}
