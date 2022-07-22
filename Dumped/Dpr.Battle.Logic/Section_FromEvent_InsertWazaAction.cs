using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_InsertWazaAction : Section
{
	public class Description
	{
		public ActionDesc actionDesc;

		public byte actPokeID;

		public WazaNo actWazaNo;

		public BtlPokePos targetPos;
	}

	public class Result
	{
		public bool isAdded;
	}

	public Section_FromEvent_InsertWazaAction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private uint calcActionPriority(PokeAction pokeAction)
	{
		return default(uint);
	}
}
