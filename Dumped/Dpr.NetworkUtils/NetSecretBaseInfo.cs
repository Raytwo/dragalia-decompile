namespace Dpr.NetworkUtils;

public class NetSecretBaseInfo : ANetData<ZoneData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
