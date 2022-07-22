namespace Dpr.NetworkUtils;

public class NetRequestData : ANetData<RequestData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
