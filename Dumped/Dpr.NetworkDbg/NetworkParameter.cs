using INL1;

namespace Dpr.NetworkDbg;

public class NetworkParameter
{
	public IlcaNetSessionNetworkType networkType;

	public IlcaNetSessionInitMode matchingMode;

	public ushort gameMode;

	public ushort playerNumMax;

	public string password;

	public IlcaNetSessionGamingStartMode gamingStartMode;

	public void Reset()
	{
	}
}
