using Dpr.Battle.Logic;

namespace Dpr.Battle.View.Systems;

public struct DeadActParam
{
	public BtlvPos vpos;

	public static DeadActParam Factory()
	{
		return default(DeadActParam);
	}
}
