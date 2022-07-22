using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_ViewEffect : Section
{
	public class Description
	{
		public ushort effectNo;

		public BtlPokePos pos_from;

		public BtlPokePos pos_to;

		public bool fQueResereved;

		public uint reservedPos;
	}

	public class Result
	{
	}

	private const int EFF_SIMPLE = 0;

	private const int EFF_POS = 1;

	private const int EFF_VECTOR = 2;

	public Section_ViewEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}
}
