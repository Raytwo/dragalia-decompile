namespace Dpr.NetworkUtils;

public class NetCharacterStateData : ANetData<StateData>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
