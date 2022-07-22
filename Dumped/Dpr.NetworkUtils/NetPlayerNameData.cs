namespace Dpr.NetworkUtils;

public class NetPlayerNameData : ANetData<NetPlayerName>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
