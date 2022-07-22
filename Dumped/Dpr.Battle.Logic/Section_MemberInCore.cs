using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MemberInCore : Section
{
	public class Description
	{
		public byte clientID;

		public byte posIdx;

		public byte nextPokeIdx;
	}

	public class Result
	{
		public byte inPokeID;
	}

	public Section_MemberInCore([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void checkBattleTalk(byte pokeID)
	{
	}
}
