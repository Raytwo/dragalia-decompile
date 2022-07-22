using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_AddSick : Section
{
	public class Description
	{
		public byte pokeID;

		public byte targetPokeID;

		public WazaSick sickID;

		public BTL_SICKCONT sickCont;

		public SickCause sickCause;

		public SickOverWriteMode overWriteMode;

		public bool isDisplayTokuseiWindow;

		public bool isFailResultDisplay;

		public bool isEffectDisplay;

		public bool isStandardMessageDisable;

		public bool isItemReactionDisable;

		public bool isEffectiveToDeadPoke;

		public StrParam specialMessage;
	}

	public class Result
	{
		public bool isSuccessed;
	}

	public Section_AddSick([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result result, [In] ref Description description)
	{
	}

	private bool checkFail(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, BTL_SICKCONT sickCont, SickCause sickCause, uint wazaSerial, SickOverWriteMode overWriteMode, bool isFailResultDisplay)
	{
		return default(bool);
	}

	private void addSick(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, BTL_SICKCONT sickCont, bool isEffectDisplay, bool isDefaultMessageDisplay, [In] ref StrParam specialMessage, bool isItemReactionDisable)
	{
	}
}
