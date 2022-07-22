using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_AddSick_Core : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public BTL_POKEPARAM target;

		public WazaSick sick;

		public BTL_SICKCONT sickCont;

		public bool isEffectDisplay;

		public bool isDefaultMessageDisplay;

		public StrParam specialMessage;

		public bool isItemReactionDisable;
	}

	public class Result
	{
	}

	public Section_AddSick_Core([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void putEffect(BTL_POKEPARAM target, WazaSick sick)
	{
	}

	private void putMessage(BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont, bool isDefaultMessageDisplay, StrParam specialMessage)
	{
	}

	private void makeDefaultMessage(StrParam str, BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
	}

	private int getDefaultSickStrID(WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
		return default(int);
	}

	private void changeSheimiForm(WazaSick sick, BTL_POKEPARAM target)
	{
	}

	private void sickFixedEvent(BTL_POKEPARAM attacker, BTL_POKEPARAM target, WazaSick sick, [In] ref BTL_SICKCONT sickCont)
	{
	}

	private void onIekiFixed(BTL_POKEPARAM target)
	{
	}

	private void checkItemReaction(BTL_POKEPARAM target)
	{
	}
}
