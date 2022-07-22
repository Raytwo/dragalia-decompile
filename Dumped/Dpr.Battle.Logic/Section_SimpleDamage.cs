using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_SimpleDamage : Section
{
	public class Description
	{
		public BTL_POKEPARAM poke;

		public uint damage;

		public DamageCause damageCause;

		public byte damageCausePokeID;

		public StrParam message;

		public bool doDeadProcess;
	}

	public class Result
	{
		public bool isDamaged;
	}

	public Section_SimpleDamage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putSimpleHp(BTL_POKEPARAM bpp, uint damage, DamageCause damageCause, byte damageCausePokeID)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM poke)
	{
	}

	private void checkPokeDead(BTL_POKEPARAM poke)
	{
	}
}
