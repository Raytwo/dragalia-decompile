using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_FriendshipEffect : Section
{
	public class Description
	{
		public byte pokeID;

		public FriendshipEffect effectType;

		public StrParam message;
	}

	public class Result
	{
	}

	public Section_FromEvent_FriendshipEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
