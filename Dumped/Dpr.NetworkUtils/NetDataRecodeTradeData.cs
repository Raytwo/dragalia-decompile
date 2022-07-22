namespace Dpr.NetworkUtils;

public class NetDataRecodeTradeData : ANetData<RecodeTradeData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
