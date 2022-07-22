using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class Section_MagicCoat : Section
{
	public class Description
	{
		public WazaNo waza;
	}

	public class Result
	{
	}

	public Section_MagicCoat([In] ref CommonParam commonParam)
	{
	}

	public void Execute(Result pResult, [In] ref Description description)
	{
	}

	private void executeMagicCoat(byte robPokeID, byte targetPokeID, BtlPokePos targetPos, WazaNo waza)
	{
	}

	private void event_WazaReflect(BTL_POKEPARAM robPoke, BTL_POKEPARAM targetPoke, WazaNo waza)
	{
	}

	private void getWazaParam(WazaParam wazaParam, BTL_POKEPARAM attacker, WazaNo waza)
	{
	}

	private void registerTarget(PokeSet pokeSet, BTL_POKEPARAM attacker, WazaParam wazaParam, BtlPokePos targetPos)
	{
	}

	private void wazaExec(BTL_POKEPARAM attacker, WazaParam wazaParam, PokeSet targets)
	{
	}
}
