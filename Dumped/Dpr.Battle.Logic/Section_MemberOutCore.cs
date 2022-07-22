using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MemberOutCore : Section
{
	public class Description
	{
		public BTL_POKEPARAM outPoke;

		public ushort effectNo;
	}

	public class Result
	{
		public bool isOutSuccessed;
	}

	public Section_MemberOutCore([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putMemberOut(BTL_POKEPARAM outPoke, ushort effectNo)
	{
	}

	private void clearPokeDependEffect(BTL_POKEPARAM poke)
	{
	}

	private void endGMode(BTL_POKEPARAM poke)
	{
	}
}
