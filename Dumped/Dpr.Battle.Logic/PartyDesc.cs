using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class PartyDesc
{
	public PokeDesc[] pokeDesc;

	public static void Clear(PartyDesc desc)
	{
	}

	public static void Copy(PartyDesc dest, [In] ref PartyDesc src)
	{
	}
}
