using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_WazaExec_Failed : Section
{
	public class Description
	{
		public BTL_POKEPARAM pAttacker;

		public WazaNo waza;

		public WazaFailCause failCause;
	}

	public class Result
	{
	}

	public Section_WazaExec_Failed([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void section_ConfDamage(BTL_POKEPARAM pPoke)
	{
	}

	private bool section_CheckPokeDead(BTL_POKEPARAM pPoke)
	{
		return default(bool);
	}

	private void put_WazaFail(BTL_POKEPARAM pAttacker, WazaNo waza, WazaFailCause failCause)
	{
	}

	private void event_CheckWazaExeFail(BTL_POKEPARAM pAttacker, WazaNo waza, WazaFailCause failCause)
	{
	}
}
