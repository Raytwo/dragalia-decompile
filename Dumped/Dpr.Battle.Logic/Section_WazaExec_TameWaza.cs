using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_TameWaza : Section
{
	public class Description
	{
		public BTL_POKEPARAM attacker;

		public WazaParam wazaParam;

		public PokeSet targetRec;
	}

	public class Result
	{
		public TameWazaResult resultCode;
	}

	public Section_WazaExec_TameWaza([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private bool tameStart(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targetRec)
	{
		return default(bool);
	}

	private void putTameStartCommand(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targetRec)
	{
	}

	private void putHideCommand(BTL_POKEPARAM attacker, byte hideTargetPokeID)
	{
	}

	private bool event_TameStart(ref byte pHideTargetPokeID, ref bool pIsFailMsgDisplayed, BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targetRec)
	{
		return default(bool);
	}

	private void event_TameStartFixed(BTL_POKEPARAM attacker)
	{
	}

	private void event_TameSkipFixed(BTL_POKEPARAM attacker, WazaParam wazaParam)
	{
	}

	private bool event_TameRelease(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targetRec)
	{
		return default(bool);
	}

	private void clearTameLock(BTL_POKEPARAM poke)
	{
	}
}
