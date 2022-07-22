using Dpr.Battle.Logic;

namespace Dpr.Battle.View.Systems;

public struct StartGActParam
{
	public BtlvPos vpos;

	public static StartGActParam Factory()
	{
		return default(StartGActParam);
	}
}
