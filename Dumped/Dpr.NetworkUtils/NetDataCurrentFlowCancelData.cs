namespace Dpr.NetworkUtils;

public class NetDataCurrentFlowCancelData : ANetData<CancelData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
