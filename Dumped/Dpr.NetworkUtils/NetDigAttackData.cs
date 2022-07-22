namespace Dpr.NetworkUtils;

public class NetDigAttackData : ANetData<DigAttackData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
