using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public static class DEFAULT_POWERUP_DESC
{
	public static void Clear(DefaultPowerUpDesc desc)
	{
	}

	public static void Copy(DefaultPowerUpDesc dest, [In] ref DefaultPowerUpDesc src)
	{
	}

	public static uint GetRankUpParamCount([In] ref DefaultPowerUpDesc desc)
	{
		return default(uint);
	}

	public static byte GetMaxRankUpValue([In] ref DefaultPowerUpDesc desc)
	{
		return default(byte);
	}
}
