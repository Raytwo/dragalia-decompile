using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class PokeDesc
{
	public DefaultPowerUpDesc defaultPowerUpDesc;

	public bool isGEnableByNPC;

	public static void Clear(PokeDesc desc)
	{
	}

	public static void Copy(PokeDesc dest, [In] ref PokeDesc src)
	{
	}
}
