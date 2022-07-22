using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_AddSickCheckFail : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public WazaSick sick;

		public BTL_SICKCONT sickCont;

		public SickCause sickCause;

		public uint wazaSerial;

		public SickOverWriteMode overWriteMode;

		public bool isFailResultDisplay_ByBasicRules;

		public bool isFailResultDisplay_BySpecialFactors;

		public bool isOtherEffectDisplayed;
	}

	public class Result
	{
		public bool isFail;
	}

	public Section_AddSickCheckFail([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private AddSickFailCode checkFail(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont, SickCause sickCause, SickOverWriteMode overWriteMode)
	{
		return default(AddSickFailCode);
	}

	private AddSickFailCode checkFail_byOverwriteMode(BTL_POKEPARAM target, WazaSick sick, SickOverWriteMode overWriteMode)
	{
		return default(AddSickFailCode);
	}

	private AddSickFailCode checkFail_byBasicRules(BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
		return default(AddSickFailCode);
	}

	private bool isLoaclShineWeather(BTL_POKEPARAM poke)
	{
		return default(bool);
	}

	private bool isFailMessageEnable(AddSickFailCode failCode, SickCause sickCause, bool isOtherEffectDisplayed)
	{
		return default(bool);
	}

	private void putFailMessage(BTL_POKEPARAM target, AddSickFailCode failCode, WazaSick sick, SickCause sickCause)
	{
	}

	private void checkFail_Special(ref bool isFailed, ref bool canFailResultDisplay, BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, SickCause sickCause)
	{
	}
}
