namespace Dpr.Battle.Logic;

public sealed class ActionDesc
{
	public uint serialNo;

	public bool isOiutiInterruptAction;

	public bool isYokodoriRobAction;

	public bool isMagicCoatReaction;

	public bool isOdorikoReaction;

	public bool isSaihaiReaction;

	public InsertActionInfo insertInfo;

	public void CopyFrom(ActionDesc src)
	{
	}

	public void Clear()
	{
	}

	public static void Clear(ActionDesc desc)
	{
	}
}
