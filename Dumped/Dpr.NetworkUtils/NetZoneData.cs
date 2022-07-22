namespace Dpr.NetworkUtils;

public class NetZoneData : ANetData<PosZoneData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
