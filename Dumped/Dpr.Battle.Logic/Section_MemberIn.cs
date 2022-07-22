using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_MemberIn : Section
{
	public class Description
	{
		public byte clientID;

		public byte posIdx;

		public byte nextPokeIdx;

		public bool isPutMessage;
	}

	public class Result
	{
		public byte inPokeID;
	}

	public Section_MemberIn([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private byte memberIn(byte clientID, byte posIdx, byte nextPokeIdx)
	{
		return default(byte);
	}

	private void checkBattleTalk(byte pokeID)
	{
	}
}
