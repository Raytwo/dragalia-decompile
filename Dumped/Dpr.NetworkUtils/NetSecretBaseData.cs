using DPData;

namespace Dpr.NetworkUtils;

public class NetSecretBaseData : ANetData<UgSecretBase>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);
}
