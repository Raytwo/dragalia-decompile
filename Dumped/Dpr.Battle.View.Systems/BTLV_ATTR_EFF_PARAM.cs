namespace Dpr.Battle.View.Systems;

public struct BTLV_ATTR_EFF_PARAM
{
	public EffectBattleID attrEffectID;

	public EffectBattleID streamLineEffectID;

	public void SetStreamLineEffectID(PeriodOfDay day, EffectBattleID[] ids)
	{
	}

	public static BTLV_ATTR_EFF_PARAM Factory()
	{
		return default(BTLV_ATTR_EFF_PARAM);
	}
}
