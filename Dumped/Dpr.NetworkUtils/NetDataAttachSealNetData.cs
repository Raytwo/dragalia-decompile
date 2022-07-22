namespace Dpr.NetworkUtils;

public class NetDataAttachSealNetData : ANetData<BallDecoData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
