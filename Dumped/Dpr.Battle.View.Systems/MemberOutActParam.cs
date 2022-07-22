using Dpr.Battle.Logic;

namespace Dpr.Battle.View.Systems;

public struct MemberOutActParam
{
	public BtlvPos vpos;

	public static MemberOutActParam Factory()
	{
		return default(MemberOutActParam);
	}
}
