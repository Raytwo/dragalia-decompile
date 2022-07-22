namespace Dpr.NetworkUtils;

public class NetDataTradeReadyOkData : ANetData<ReadyOkData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
