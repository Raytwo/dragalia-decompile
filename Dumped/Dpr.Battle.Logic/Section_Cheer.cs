using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic;

public sealed class Section_Cheer : Section
{
	public class Description
	{
		public BTL_CLIENT_ID cheerClientID;

		public uint actionSerialNo;
	}

	public class Result
	{
	}

	private struct decideRankUpEffectTableElem
	{
		public WazaRankEffect effect;

		public byte volume;

		public decideRankUpEffectTableElem(WazaRankEffect effect, byte volume)
		{
		}
	}

	private static readonly decideRankUpEffectTableElem[] decideRankUpEffectTable;

	public Section_Cheer([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description desc)
	{
	}

	private CheerEffect decideCheerEffect()
	{
		return default(CheerEffect);
	}

	private void getSelectableCheerEffects(CheerEffect[] pEffectArray, out byte pEffectCount)
	{
	}

	private bool canSelectCheerEffect(CheerEffect effect)
	{
		return default(bool);
	}

	private void applyCheerEffect(BTL_CLIENT_ID cheerClientID, uint actionSerialNo, CheerEffect effect)
	{
	}

	private bool cheerEffect_RecoverHP(BTL_CLIENT_ID cheerClientID)
	{
		return default(bool);
	}

	private bool cheerEffect_CureSick(BTL_CLIENT_ID cheerClientID)
	{
		return default(bool);
	}

	private bool cheerEffect_RankUp(BTL_CLIENT_ID cheerClientID, uint actionSerialNo)
	{
		return default(bool);
	}

	private void decideRankUpEffect(out WazaRankEffect effect, out byte volume)
	{
	}

	private bool applyRankUpEffect(BTL_POKEPARAM target, WazaRankEffect effect, byte volume, uint actionSerialNo)
	{
		return default(bool);
	}

	private bool cheerEffect_Reflector(BTL_CLIENT_ID cheerClientID)
	{
		return default(bool);
	}

	private bool cheerEffect_Hikarinokabe(BTL_CLIENT_ID cheerClientID)
	{
		return default(bool);
	}

	private bool cheerEffect_BreakGWall()
	{
		return default(bool);
	}

	private bool isCheerTarget(BTL_POKEPARAM poke, BTL_CLIENT_ID cheerClientID)
	{
		return default(bool);
	}
}
