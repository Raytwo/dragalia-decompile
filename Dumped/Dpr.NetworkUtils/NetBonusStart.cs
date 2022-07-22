namespace Dpr.NetworkUtils;

public class NetBonusStart : ANetData<Dummy>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
