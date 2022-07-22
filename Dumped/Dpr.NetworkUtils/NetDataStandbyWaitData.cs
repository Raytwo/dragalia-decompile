namespace Dpr.NetworkUtils;

public class NetDataStandbyWaitData : ANetData<StandbyData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
