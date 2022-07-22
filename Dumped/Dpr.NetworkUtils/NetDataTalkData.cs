namespace Dpr.NetworkUtils;

public class NetDataTalkData : ANetData<TalkData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
