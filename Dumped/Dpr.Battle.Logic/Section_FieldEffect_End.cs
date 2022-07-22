using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FieldEffect_End : Section
{
	public class Description
	{
		public EffectType effect;

		public BTL_POKEPARAM pDependPoke;
	}

	public class Result
	{
		public bool isRemoved;
	}

	public Section_FieldEffect_End([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool remove(EffectType effect, BTL_POKEPARAM pDependPoke)
	{
		return default(bool);
	}

	private void putRemovedMessage(EffectType effect)
	{
	}

	private void checkItemReaction_All()
	{
	}

	private void getFrontPokeSetByAgilityOrder(PokeSet targets)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}

	private void resetGround()
	{
	}

	private void resetKagakuhenkaGas()
	{
	}
}
