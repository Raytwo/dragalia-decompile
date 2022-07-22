using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public static class BTL_ACTION
{
	public static void SetFightParam(ref BTL_ACTION_PARAM p, byte pokeID, WazaNo waza, BtlPokePos targetPos, bool forbidGWaza = false, bool forceGWaza = false)
	{
	}

	public static void ChangeFightTargetPos(ref BTL_ACTION_PARAM p, BtlPokePos nextTargetPos)
	{
	}

	public static void FightParamToWazaInfoMode(ref BTL_ACTION_PARAM p)
	{
	}

	public static bool IsWazaInfoMode(ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static bool IsFight(ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static bool IsFightWithG(ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static bool IsGStart(ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static bool IsItem(ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static bool IsCheer(ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static WazaNo GetWazaID(ref BTL_ACTION_PARAM act)
	{
		return default(WazaNo);
	}

	public static BtlPokePos GetWazaTargetPos(ref BTL_ACTION_PARAM act)
	{
		return default(BtlPokePos);
	}

	public static WazaNo GetOriginalWazaID(ref BTL_ACTION_PARAM act)
	{
		return default(WazaNo);
	}

	public static void SetItemParam(ref BTL_ACTION_PARAM p, byte pokeID, ushort itemNumber, byte targetID, byte wazaIdx)
	{
	}

	public static void SetChangeParam(ref BTL_ACTION_PARAM p, byte posIdx, byte memberIdx)
	{
	}

	public static void SetChangeDepleteParam(ref BTL_ACTION_PARAM p)
	{
	}

	public static bool IsDeplete([In] ref BTL_ACTION_PARAM p)
	{
		return default(bool);
	}

	public static void SetEscapeParam(ref BTL_ACTION_PARAM p, byte pokeID)
	{
	}

	public static void SetCheer(ref BTL_ACTION_PARAM p)
	{
	}

	public static void SetSafariBall(ref BTL_ACTION_PARAM p, byte pokeID)
	{
	}

	public static void SetSafariEsa(ref BTL_ACTION_PARAM p, byte pokeID)
	{
	}

	public static void SetSafariDoro(ref BTL_ACTION_PARAM p, byte pokeID)
	{
	}

	public static void SetSafariYousumi(ref BTL_ACTION_PARAM p, byte pokeID)
	{
	}

	public static void SetNULL(ref BTL_ACTION_PARAM p)
	{
	}

	public static void SetSkip(ref BTL_ACTION_PARAM p, byte pokeID)
	{
	}

	public static BtlAction GetAction([In] ref BTL_ACTION_PARAM p)
	{
		return default(BtlAction);
	}

	public static void SetRecPlayOver(ref BTL_ACTION_PARAM act)
	{
	}

	public static void SetRecPlayError(ref BTL_ACTION_PARAM act)
	{
	}
}
