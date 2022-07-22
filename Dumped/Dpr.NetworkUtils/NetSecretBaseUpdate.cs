using DPData;

namespace Dpr.NetworkUtils;

public class NetSecretBaseUpdate : ANetData<UgSecretBase>
{
	public override byte GetDataID => default(byte);

	public new static byte DataID => default(byte);

	public static byte NoticeID => default(byte);
}
