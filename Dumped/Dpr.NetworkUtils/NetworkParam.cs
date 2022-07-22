using INL1;

namespace Dpr.NetworkUtils;

public class NetworkParam
{
	public IlcaNetSessionNetworkType networkType;

	public IlcaNetSessionInitMode matchingMode;

	public IlcaNetSessionGamingStartMode gamingStartMode;

	public IlcaNetSessionCallbackLastEventLeave lastEventLeave;

	public ushort gameMode;

	public ushort playerNumMax;

	public string password;

	public bool ngsLogin;

	public bool bAutoSessionOpen;

	public bool bAutoSessionClose;

	public uint[] attributeValueArray;

	public uint[] attributeMinValueArray;

	public uint[] attributeMaxValueArray;

	public void Reset()
	{
	}
}
