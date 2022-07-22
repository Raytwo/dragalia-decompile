using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_CheckItemReaction : Section
{
	public class Description
	{
		public byte pokeID;

		public byte reactionType;
	}

	public class Result
	{
	}

	public Section_CheckItemReaction([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}
}
