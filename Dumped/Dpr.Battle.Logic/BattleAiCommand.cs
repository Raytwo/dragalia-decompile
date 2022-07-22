using System.Runtime.InteropServices;
using Pml;
using Pml.Battle;

namespace Dpr.Battle.Logic;

public static class BattleAiCommand
{
	public delegate long BTL_AICMD_FUNC(AiScriptCommandHandler handle, long[] args);

	private struct CMDFUNC_CHECK_WAZA_NO_EFFECT_BY_TOKUSEI_TABLE_ELEM
	{
		public PokeType wazaType;

		public TokuseiNo[] tokusei;

		public CMDFUNC_CHECK_WAZA_NO_EFFECT_BY_TOKUSEI_TABLE_ELEM(PokeType wazaType, TokuseiNo[] tokusei)
		{
		}
	}

	private const long CELL_FALSE = 0L;

	private const long CELL_TRUE = 1L;

	private static AiScriptCommandHandler[] s_pCommandHandler;

	private static readonly BTL_AICMD_FUNC[] BTL_AICMD_FUNC_TABLE;

	private const int CHECK_TOK_MAX = 4;

	private static readonly CMDFUNC_CHECK_WAZA_NO_EFFECT_BY_TOKUSEI_TABLE_ELEM[] CMDFUNC_CHECK_WAZA_NO_EFFECT_BY_TOKUSEI_TABLE;

	public static void SetCommandHandler(byte clientID, AiScriptCommandHandler pCommandHandler)
	{
	}

	public static void ClearCommandHandlers()
	{
	}

	public static long AI_CMD(byte clientID, AICmd cmd, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_RND_UNDER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_RND_OVER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_RND_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_RND_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HP_UNDER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HP_OVER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HP_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_HP_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_POKESICK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_POKESICK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_WAZASICK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_WAZASICK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_DOKUDOKU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_DOKUDOKU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_HOROBINOUTA_TURN_MAX(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_HOROBINOUTA_TURN_NOW(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_KODAWARI_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_CONTFLG(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_CONTFLG(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WEATHER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_SIDEEFF(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_SIDEEFF(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static bool check_have_damage_waza(AiScriptCommandHandler handle, BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	private static long CMDFUNC_IF_HAVE_DAMAGE_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_HAVE_DAMAGE_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_TURN(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_TYPE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WAZA_USABLE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static bool IsWazaUsable(BTL_CLIENT attackClient, BTL_POKEPARAM attackPoke, WazaNo wazano)
	{
		return default(bool);
	}

	private static long CMDFUNC_CHECK_DAMAGE_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_IRYOKU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_COMP_POWER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_CURRENT_WAZANO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WAZASEQNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WAZA_AISYOU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_WAZA_AISYOU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HAVE_WAZA_AISYOU_OVER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HAVE_WAZA_AISYOU_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static TypeAffinity.AffinityID CalcTypeAffinity([In] ref BattleEnv battleEnv, BattleSimulator pSimulator, BTL_POKEPARAM attackPoke, BTL_POKEPARAM defensePoke, WazaNo wazano)
	{
		return default(TypeAffinity.AffinityID);
	}

	private static TypeAffinity.AffinityID CalcTypeAffinityCanBench([In] ref BattleEnv battleEnv, BattleSimulator pSimulator, BTL_POKEPARAM attackPoke, BTL_POKEPARAM defensePoke, WazaNo wazano)
	{
		return default(TypeAffinity.AffinityID);
	}

	private static long CMDFUNC_CHECK_WAZA_NO_EFFECT_BY_TOKUSEI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static TokuseiNo CheckPokeTokusei([In] ref MainModule mainModule, byte myClientId, BTL_POKEPARAM targetPoke)
	{
		return default(TokuseiNo);
	}

	private static bool check_current_waza_hinsi(AiScriptCommandHandler handle, int loss_flag)
	{
		return default(bool);
	}

	private static long CMDFUNC_IF_WAZA_HINSHI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_WAZA_HINSHI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_LAST_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_TOKUSEI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static bool check_have_waza(AiScriptCommandHandler handle, int ai_side, WazaNo waza_no)
	{
		return default(bool);
	}

	private static long CMDFUNC_IF_HAVE_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_HAVE_WAZA(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_LAST_DAMAGED_WAZA_AT_PREV_TURN(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_FIRST(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_BENCH_COUNT(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static bool check_pokesick_in_bench(AiScriptCommandHandler handle, int ai_side)
	{
		return default(bool);
	}

	private static long CMDFUNC_IF_BENCH_COND(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_BENCH_COND(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static int get_poke_param(AiScriptCommandHandler handle, int ai_side, BTL_POKEPARAM.ValueID valueID)
	{
		return default(int);
	}

	private static long CMDFUNC_IF_PARA_UNDER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_PARA_OVER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_PARA_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_PARA_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static bool check_have_waza_seqno(AiScriptCommandHandler handle, int ai_side, int seq_no)
	{
		return default(bool);
	}

	private static long CMDFUNC_IF_HAVE_WAZA_SEQNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_HAVE_WAZA_SEQNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_ESCAPE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_SOUBI_ITEM(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_SOUBI_EQUIP(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_POKESEX(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_NEKODAMASI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_TAKUWAERU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_BTL_RULE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_BTL_COMPETITOR(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_RECYCLE_ITEM(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WORKWAZA_TYPE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WORKWAZA_POW(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WORKWAZA_SEQNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_MAMORU_COUNT(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_LEVEL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_CHOUHATSU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_CHOUHATSU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_MIKATA_ATTACK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_HAVE_TYPE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_HAVE_TOKUSEI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_ALREADY_MORAIBI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HAVE_ITEM(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_FLDEFF_CHECK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_SIDEEFF_COUNT(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_BENCH_HPDEC(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_BENCH_PPDEC(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_NAGETSUKERU_IRYOKU(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_PP_REMAIN(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_TOTTEOKI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_WAZA_KIND(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_LAST_WAZA_KIND(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_AGI_RANK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_SLOWSTART_TURN(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_BENCH_DAMAGE_MAX(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HAVE_BATSUGUN(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_LAST_WAZA_DAMAGE_CHECK(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_STATUS_UP(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_STATUS_DIFF(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_STATUS(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_COMP_POWER_WITH_PARTNER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HINSHI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_HINSHI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_TOKUSEI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_MIGAWARI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_MONSNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_CHECK_FORMNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_COMMONRND_UNDER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_COMMONRND_OVER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_COMMONRND_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IFN_COMMONRND_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_MIRAIYOCHI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_DMG_PHYSIC_UNDER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_DMG_PHYSIC_OVER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_DMG_PHYSIC_EQUAL(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_ATE_KINOMI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HAVE_KINOMI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_TYPE_EX(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_EXIST_GROUND(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_WEIGHT(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_MULTI(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_MEGAEVOLVED(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_CAN_MEGAEVOLVE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_WAZAHIDE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_MEZAPA_TYPE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_I_AM_SENARIO_TRAINER(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_MAX_WAZA_POWER_INCLUDE_AFFINITY(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static uint GetMaxWazaPowerIncludeAffinity([In] ref BattleEnv battleEnv, BattleSimulator pSimulator, BTL_POKEPARAM attackPoke, BTL_POKEPARAM defensePoke)
	{
		return default(uint);
	}

	private static long CMDFUNC_GET_CURRENT_ITEMNO(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_ZIDANDA_POWERUP(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_CLIENT_KILL_COUNT(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_GET_WAZA_TARGET(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_HAVE_BATSUGUN_CAN_BENCH(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_G(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_GWALL_EXIST(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_JK3_LEGEND(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_CAN_G(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_GWAZA_USE_TURN(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}

	private static long CMDFUNC_IF_CAN_CHANGE_POKE(AiScriptCommandHandler handle, long[] args)
	{
		return default(long);
	}
}
