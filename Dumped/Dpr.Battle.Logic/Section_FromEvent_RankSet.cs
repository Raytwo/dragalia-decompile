using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_RankSet : Section
{
	public class Description
	{
		public byte pokeID;

		public byte attack;

		public byte defence;

		public byte sp_attack;

		public byte sp_defence;

		public byte agility;

		public byte hit_ratio;

		public byte avoid_ratio;

		public byte critical_rank;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_RankSet([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}
}
