using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MemberChange : Section
{
	public class Description
	{
		public BTL_POKEPARAM outPoke;

		public byte nextPokeIdx;
	}

	public class Result
	{
		public byte inPokeID;
	}

	public Section_MemberChange([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool isPokeExist([In] ref BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private bool memberOut(BTL_POKEPARAM outPoke)
	{
		return default(bool);
	}

	private byte memberIn(BTL_POKEPARAM outPoke, byte nextPokeIdx)
	{
		return default(byte);
	}

	private void incMemberChangeCount(BTL_POKEPARAM outPoke)
	{
	}
}
