using System.Collections.Generic;
using Dpr.Battle.Logic;
using Pml;
using Pml.Battle;

namespace Dpr.Battle.View.UI;

public class BattleAffinityInfo
{
	private static BtlvPos[] kVposList_Single_Near;

	private static BtlvPos[] kVposList_Single_Far;

	private static BtlvPos[] kVposList_Double_Near;

	private static BtlvPos[] kVposList_Double_Fa;

	private static BtlvPos[] kVposList_Raid_Near;

	private static BtlvPos[] kVposList_Raid_Far;

	private static readonly List<TypeAffinity.AboutAffinityID> AboutAffinityPriority;

	public static List<BTL_POKEPARAM> GetBattleTargets()
	{
		return null;
	}

	public static bool GetAboutAffinity(BTL_POKEPARAM bpp, WazaNo wazaNo, BTL_POKEPARAM target, out TypeAffinity.AboutAffinityID destAffinity)
	{
		return default(bool);
	}

	public static bool CheckWazaAffinity(BTL_POKEPARAM bpp, WazaNo wazaNo, List<BTL_POKEPARAM> targets, out TypeAffinity.AboutAffinityID destAffinity)
	{
		return default(bool);
	}
}
