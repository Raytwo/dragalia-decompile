using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_DecideWazaTargetAuto : Section
{
	public class Description
	{
		public byte pokeID;

		public WazaNo waza;
	}

	public class Result
	{
		public BtlPokePos targetPos;
	}

	public Section_FromEvent_DecideWazaTargetAuto([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
