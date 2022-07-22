using Pml;

namespace Dpr.Battle.Logic;

public sealed class WazaMessageParam
{
	public bool isDone;

	public ushort reservedQueuePos;

	public ushort commandQueuePos;

	public WazaNo wazano;

	public byte attackerID;

	public BtlPokePos targetPos;

	public bool needMsgDisplay;

	public void Clear()
	{
	}

	public bool IsDone()
	{
		return default(bool);
	}

	public bool IsReserved()
	{
		return default(bool);
	}
}
