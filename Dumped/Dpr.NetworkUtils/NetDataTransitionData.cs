namespace Dpr.NetworkUtils;

public class NetDataTransitionData : ANetData<TransitionData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
