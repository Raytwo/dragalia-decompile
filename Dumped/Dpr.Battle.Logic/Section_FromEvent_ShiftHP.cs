using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_ShiftHP : Section
{
	public class Description
	{
		public byte pokeID;

		public bool isEffectDisable;

		public bool isItemReactionDisable;

		public byte targetPokeCount;

		public byte[] targetPokeID;

		public int[] volume;

		public DamageCause damageCause;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_ShiftHP([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}
}
