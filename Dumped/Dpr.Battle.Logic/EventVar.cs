namespace Dpr.Battle.Logic;

public sealed class EventVar
{
	public enum Label : ushort
	{
		INVALID,
		SYS_SEPARATE,
		POKEID,
		POKEID_ATK,
		POKEID_DEF,
		TARGET_POKECNT,
		POKEID_TARGET1,
		POKEID_TARGET2,
		POKEID_TARGET3,
		POKEID_TARGET4,
		POKEID_TARGET5,
		POKEID_TARGET6,
		ACTION,
		POKEPOS,
		POKEPOS_ORG,
		TOKUSEI_PREV,
		TOKUSEI_NEXT,
		SP_PRIORITY,
		WAZAID,
		EFFECT_WAZAID,
		ORG_WAZAID,
		POKE_TYPE,
		WAZA_TYPE,
		WAZA_TYPE_EX,
		WAZA_IDX,
		WAZA_PRI,
		WAZA_SERIAL,
		DAMAGE_TYPE,
		TARGET_TYPE,
		USER_TYPE,
		SICKID,
		SICK_CONT_ADRS,
		SICK_CONT_ADRS_HIGH,
		SICK_CONT_ADRS_LOW,
		STATUS_TYPE,
		VOLUME,
		POKE_HIDE,
		FAIL_CAUSE,
		CONF_DMG,
		TURN_COUNT,
		ADD_DEFAULT_PER,
		ADD_PER,
		HIT_RANK,
		AVOID_RANK,
		HITCOUNT_MAX,
		HITCOUNT,
		HIT_PER,
		CRITICAL_RANK,
		ITEM,
		ITEM_REACTION,
		AGILITY,
		WAZA_POWER,
		WAZA_POWER_RATIO,
		DAMAGE,
		POWER,
		GUARD,
		RATIO,
		RATIO_EX,
		FIX_DAMAGE,
		FIX_DAMAGE_FLAG,
		ZERO_DAMAGE_FLAG,
		TYPEAFF,
		WEATHER,
		KORAERU_CAUSE,
		SWAP_POKEID,
		VID,
		VID_SWAP_CNT,
		ENABLE_MODE,
		WORK_ADRS,
		WORK_ADRS_HIGH,
		WORK_ADRS_LOW,
		NOEFFECT_FLAG,
		FAIL_FLAG,
		AVOID_FLAG,
		ALMOST_FLAG,
		TYPEMATCH_FLAG,
		CRITICAL_FLAG,
		MIGAWARI_FLAG,
		RINPUNGUARD_FLG,
		TIKARAZUKU_FLG,
		ITEMUSE_FLAG,
		TRICK_FLAG,
		FLAT_FLAG,
		FLATMASTER_FLAG,
		DELAY_ATTACK_FLAG,
		MAGICCOAT_FLAG,
		MSG_FLAG,
		FIX_FLAG,
		KINOMI_FLAG,
		GEN_FLAG,
		DISABLE_YAKEDO_FLAG,
		SIDE,
		SIDE_EFFECT,
		AURA_BREAK_FLAG,
		AURA_RESERVE_FLAG,
		EFFECT_NO,
		KINOMI_EFFECT_UP,
		TEMPT_TARGET_PRIORITY,
		TEMPT_TARGET_CAUSE,
		WAZA_TOUCH_FLAG,
		WALL_EFFECT_FLAG_PHYSIC,
		WALL_EFFECT_FLAG_SPECIAL,
		GROUND,
		FIELD,
		RANKEFFECT_CAUSE,
		DAMAGE_CAUSE,
		DAMAGE_CAUSE_POKEID,
		SICK_CAUSE,
		TOKUSEI_CHANGE_CAUSE,
		ITAZURAGOKORO_EFFECT,
		OIUTI_INTERRUPT_FLAG,
		ACTION_DESC_IS_YOKODORI_ROB_ACTION,
		ACTION_DESC_IS_MAGICCOAT_REACTION,
		ACTION_DESC_IS_ODORIKO_REACTION,
		ACTION_DESC_IS_OIUTI_INTERRUPT_ACTION,
		ENABLE_FLAG,
		REFLECT_FLAG,
		MESSAGE_DISPLAYED,
		TOKUSEI_WINDOW_DISPLAY,
		CAN_AIM_TARGET,
		SUCCESS_FLAG,
		CHANGE_FLAG,
		INVALID_MESSAGE_FLAG,
		NEED_ITEM_CONSUME_MESSAGE_DISPLAY,
		NUM
	}

	public enum RewriteState : byte
	{
		FREE,
		ONCE,
		END,
		MUL,
		LOCK
	}

	private Label m_label;

	private RewriteState m_rewriteState;

	private int m_value;

	private int m_mulMin;

	private int m_mulMax;

	private object m_address;

	public void SetLabel(Label label)
	{
	}

	public void SetValue(int value)
	{
	}

	public void SetConstValue(int value)
	{
	}

	public void SetRewriteOnceValue(int value)
	{
	}

	public bool RewriteValue(int value)
	{
		return default(bool);
	}

	public void RecoveryRewriteOncePermission()
	{
	}

	public void SetMulValue(int value, int min, int max)
	{
	}

	public void MulValue(int mulValue)
	{
	}

	public void SetAddress(object ptr)
	{
	}

	public Label GetLabel()
	{
		return default(Label);
	}

	public int GetValue()
	{
		return default(int);
	}

	public object GetAddress()
	{
		return null;
	}
}
