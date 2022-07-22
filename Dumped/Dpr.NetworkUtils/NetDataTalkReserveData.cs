namespace Dpr.NetworkUtils;

public class NetDataTalkReserveData : ANetData<TalkReserveData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
