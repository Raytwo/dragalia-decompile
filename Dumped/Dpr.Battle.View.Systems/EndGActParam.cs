using Dpr.Battle.Logic;

namespace Dpr.Battle.View.Systems;

public struct EndGActParam
{
	public BtlvPos vpos;

	public static EndGActParam Factory()
	{
		return default(EndGActParam);
	}
}
