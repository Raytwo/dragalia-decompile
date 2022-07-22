namespace Dpr.NetworkUtils;

public class NetPosData : ANetData<PosListData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
