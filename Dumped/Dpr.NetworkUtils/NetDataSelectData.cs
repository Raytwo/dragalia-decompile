namespace Dpr.NetworkUtils;

public class NetDataSelectData : ANetData<SelectData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
