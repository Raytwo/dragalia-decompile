using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_AddViewEffect : Section
{
	public class Description
	{
		public ushort effectNo;

		public BtlPokePos pos_from;

		public BtlPokePos pos_to;

		public ushort reservedQueuePos;

		public bool isQueueReserved;

		public bool isMessageWindowVanish;

		public StrParam afterMessage;
	}

	public class Result
	{
	}

	public Section_FromEvent_AddViewEffect([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void addVewEffect(ushort effectNo, BtlPokePos effectPos_from, BtlPokePos effectPos_to, bool isQueueReserved, uint reservedQueuePos)
	{
	}
}
