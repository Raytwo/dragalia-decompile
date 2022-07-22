using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SortActionOrder : Section
{
	public class Description
	{
		public PokeActionContainer actionContainer;
	}

	public class Result
	{
	}

	public Section_SortActionOrder([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void setPriority(PokeActionContainer actionContainer)
	{
	}

	private uint calcActionPriority(PokeAction pokeAction)
	{
		return default(uint);
	}

	private BtlSpecialPri getSpActPriority(PokeAction pokeAction)
	{
		return default(BtlSpecialPri);
	}

	private void sort(PokeActionContainer actionContainer)
	{
	}
}
