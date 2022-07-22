namespace Dpr.NetworkUtils;

public class NetDigGroupIdData : ANetData<UgStationID_to_DigFossilIDList>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
