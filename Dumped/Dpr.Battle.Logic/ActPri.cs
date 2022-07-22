namespace Dpr.Battle.Logic;

public static class ActPri
{
	internal const uint MASK_DOMINANT = 234881024u;

	internal const uint MASK_OPERATION = 29360128u;

	internal const uint MASK_WAZA = 4128768u;

	internal const uint MASK_SP = 57344u;

	internal const uint MASK_AGILITY = 8191u;

	private static uint GetShiftWidthByMask(uint mask)
	{
		return default(uint);
	}

	private static uint MakeBitFlag(uint value, uint mask)
	{
		return default(uint);
	}

	private static uint GetMaskedValue(uint value, uint mask)
	{
		return default(uint);
	}

	private static uint SetMaskedValue(uint oldValue, uint mask, uint setValue)
	{
		return default(uint);
	}

	public static uint Make(DominantPriority dominantPri, OperationPriority operationPri, byte wazaPri, byte spPri, ushort agility)
	{
		return default(uint);
	}

	public static uint ChangeAgility(uint priority, ushort agility)
	{
		return default(uint);
	}

	public static uint ChangeWazaPriority(uint priority, byte wazaPri)
	{
		return default(uint);
	}

	public static byte GetWazaPri(uint priority)
	{
		return default(byte);
	}

	public static byte GetSpPri(uint priority)
	{
		return default(byte);
	}

	public static OperationPriority GetOperationPri(uint priority)
	{
		return default(OperationPriority);
	}

	public static DominantPriority GetDominantPri(uint priority)
	{
		return default(DominantPriority);
	}

	public static uint SetDominantPri(uint priority, DominantPriority dominantPri)
	{
		return default(uint);
	}

	public static uint SetSpPri(uint priority, byte spPri)
	{
		return default(uint);
	}

	public static uint ToHandlerPri(uint priority)
	{
		return default(uint);
	}

	public static int ToWazaOrgPri(uint priority)
	{
		return default(int);
	}
}
