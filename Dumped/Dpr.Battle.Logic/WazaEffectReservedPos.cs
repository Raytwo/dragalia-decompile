namespace Dpr.Battle.Logic;

public class WazaEffectReservedPos
{
	public ushort prevEffectCmd;

	public ushort mainEffectCmd;

	private const ushort INVALID_VALUE = ushort.MaxValue;

	public void CopyFrom(WazaEffectReservedPos src)
	{
	}

	public bool IsValid()
	{
		return default(bool);
	}

	public void Reserve(ServerCommandQueue queue)
	{
	}
}
