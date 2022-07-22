namespace Dpr.NetworkUtils;

public class NetDataStandbyWaitListData : ANetData<StanbyListData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
