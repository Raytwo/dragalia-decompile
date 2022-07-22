using Dpr.NetworkUtils;

namespace Dpr.Contest;

public class NoticeNetData : ANetData<ReadyData>
{
	public override byte GetDataID => default(byte);
}
