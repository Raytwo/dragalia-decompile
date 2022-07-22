using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_FromEvent_Damage : Section
{
	public enum EffectPlayMode : byte
	{
		DISABLE,
		ENABLE,
		FORCE
	}

	public class Description
	{
		public byte pokeID;

		public byte targetPokeID;

		public ushort damage;

		public DamageCause damageCause;

		public byte damageCausePokeID;

		public bool canHidePokeAvoid;

		public bool disableDeadProcess;

		public bool isDisplayTokuseiWindow;

		public EffectPlayMode exEffectPlayMode;

		public ushort exEffectNo;

		public BtlPokePos exEffectPos_from;

		public BtlPokePos exEffectPos_to;

		public StrParam successMessage;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_FromEvent_Damage([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool isDamageEnable(BTL_POKEPARAM poke, uint damage, DamageCause damageCause)
	{
		return default(bool);
	}

	private void viewEffect(ushort effectNo, BtlPokePos effectPos_from, BtlPokePos effectPos_to)
	{
	}

	private void addDamage(BTL_POKEPARAM poke, uint damage, DamageCause damageCause, byte damageCausePokeID, [In] ref StrParam message, bool doDeadProcess)
	{
	}
}
