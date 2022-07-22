namespace Dpr.NetworkUtils;

public class NetJoinData : ANetData<JoinData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
