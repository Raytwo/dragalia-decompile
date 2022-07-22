using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaSick : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public WazaSick sick;

		public BTL_SICKCONT sickCont;

		public SickCause cause;

		public uint actionSerialNo;

		public bool isFailResultDisplay_ByBasicRules;

		public bool isFailResultDisplay_BySpecialFactors;

		public bool isOtherEffectDisplayed;
	}

	public class Result
	{
		public bool isSuccess;
	}

	public Section_WazaSick([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool addSickCheckFail(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, BTL_SICKCONTOBJ sickCont, SickCause cause, uint actionSerialNo, bool isFailResultDisplay_ByBasicRules, bool isFailResultDisplay_BySpecialFactors, bool isOtherEffectDisplayed)
	{
		return default(bool);
	}

	private void addSick(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, BTL_SICKCONTOBJ sickCont, StrParam specialMessage)
	{
	}
}
