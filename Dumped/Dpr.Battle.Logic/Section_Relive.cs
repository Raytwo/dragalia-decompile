using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_Relive : Section
{
	public class Description
	{
		public byte pokeID;

		public ushort recoverHP;

		public StrParam reliveMessage;
	}

	public class Result
	{
	}

	public Section_Relive([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private byte memberIn(byte clientID, byte posIdx, byte nextPokeIdx)
	{
		return default(byte);
	}

	private void afterMemberIn(byte inPokeID)
	{
	}
}
