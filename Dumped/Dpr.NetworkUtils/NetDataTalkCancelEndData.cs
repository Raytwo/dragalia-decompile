namespace Dpr.NetworkUtils;

public class NetDataTalkCancelEndData : ANetData<CancelEndData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
