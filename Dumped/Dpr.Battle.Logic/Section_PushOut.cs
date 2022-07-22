using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_PushOut : Section
{
	public class Description
	{
		public byte attackerID;

		public byte targetID;

		public bool isForceChange;

		public bool isIgnoreLevel;

		public ushort effectNo;

		public StrParam succeedMessage;
	}

	public class Result
	{
		public bool isSuccessed;

		public bool isFailMessageDisplayed;
	}

	public Section_PushOut([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private PushOutEffect getPushOutEffect(BTL_POKEPARAM attacker, bool isForceChange)
	{
		return default(PushOutEffect);
	}

	private BtlPokePos getTargetPos(BTL_POKEPARAM target)
	{
		return default(BtlPokePos);
	}

	private bool checkFail(ref bool isFailMessageDisplayed, BTL_POKEPARAM attacker, BTL_POKEPARAM target)
	{
		return default(bool);
	}

	private bool pushOutEffect_Change(BTL_POKEPARAM target, ushort effectNo, StrParam succeedMessage)
	{
		return default(bool);
	}

	private bool pushOutEffect_Escape(BTL_POKEPARAM attacker, BTL_POKEPARAM target, ushort effectNo, bool isIgnoreLevel)
	{
		return default(bool);
	}

	private int getNextInPokeIndex(byte clientID)
	{
		return default(int);
	}

	private void memberOut(BTL_POKEPARAM target, ushort effectNo)
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
