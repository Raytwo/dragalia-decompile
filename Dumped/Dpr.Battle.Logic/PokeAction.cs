using System.Runtime.InteropServices;
using Pml;

namespace Dpr.Battle.Logic;

public sealed class PokeAction
{
	public BTL_POKEPARAM bpp;

	public PokeActionCategory actionCategory;

	public PokeActionParam_Fight actionParam_Fight;

	public PokeActionParam_Item actionParam_Item;

	public PokeActionParam_PokeChange actionParam_PokeChange;

	public ActionDesc actionDesc;

	public uint priority;

	public byte clientID;

	public bool fDone;

	public bool fIntrCheck;

	public bool fRecalcPriority;

	public void CopyFrom(PokeAction src)
	{
	}

	public void Clear()
	{
	}

	public static void Copy(PokeAction dest, [In] ref PokeAction src)
	{
	}

	public static void Swap(PokeAction action1, PokeAction action2)
	{
	}

	public static void Clear(PokeAction action)
	{
	}

	public static WazaNo GetWazaID(PokeAction action)
	{
		return default(WazaNo);
	}

	public static bool IsGWazaFight(PokeAction action)
	{
		return default(bool);
	}

	public static bool IsRaidBossFight(PokeAction action)
	{
		return default(bool);
	}

	public static bool IsRaidBossGWaza(PokeAction action)
	{
		return default(bool);
	}
}
