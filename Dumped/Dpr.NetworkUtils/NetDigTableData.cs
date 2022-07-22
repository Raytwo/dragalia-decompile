namespace Dpr.NetworkUtils;

public class NetDigTableData : ANetData<UgStationID_to_DigFossilIDList>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
