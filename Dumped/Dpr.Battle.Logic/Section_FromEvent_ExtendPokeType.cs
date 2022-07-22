using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ExtendPokeType : Section
{
	public class Description
	{
		public byte pokeID;

		public byte exType;

		public BTL_POKEPARAM.ExTypeCause exTypeCause;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_ExtendPokeType([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
