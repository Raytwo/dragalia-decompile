using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CalcActionPriority : Section
{
	public class Description
	{
		public PokeAction pokeAction;

		public DominantPriority dominantPriority;

		public BtlSpecialPri specialPriority;
	}

	public class Result
	{
		public uint priority;
	}

	public Section_CalcActionPriority([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private OperationPriority calcOperationPriority(PokeAction pAction)
	{
		return default(OperationPriority);
	}

	private ushort calcAgility(BTL_POKEPARAM poke)
	{
		return default(ushort);
	}

	private byte calcWazaPriority([In] ref PokeAction pokeAction)
	{
		return default(byte);
	}
}
