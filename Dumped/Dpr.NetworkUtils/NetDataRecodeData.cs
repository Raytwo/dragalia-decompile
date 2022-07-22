namespace Dpr.NetworkUtils;

public class NetDataRecodeData : ANetData<NetRecodeData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
