using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Handler;

public static class Pos
{
	public delegate EventFactor.EventHandlerTable[] HandlerGetFunc();

	private struct GET_FUNC_TABLE_ELEM
	{
		public BtlPosEffect eff;

		public HandlerGetFunc func;

		public GET_FUNC_TABLE_ELEM(BtlPosEffect eff, HandlerGetFunc func)
		{
		}
	}

	private const int WORKIDX_USER_POKEID = 6;

	private static readonly GET_FUNC_TABLE_ELEM[] GET_FUNC_TABLE;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Negaigoto;

	private const int WORKIDX_SKIP_SPFAIL_CHECK = 0;

	private const int WORKIDX_FIRST_TURN_FLAG = 1;

	private const int WORKIDX_TURN = 2;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_MikadukiNoMai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_IyasiNoNegai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_DelayAttack;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_BatonTouch;

	public static EventFactor getEventFactor(EventSystem pEventSystem, BtlPosEffect effect, BtlPokePos pokePos)
	{
		return null;
	}

	public static bool isRegistable(EventSystem pEventSystem, BtlPosEffect effect, BtlPokePos pokePos)
	{
		return default(bool);
	}

	public static HandlerGetFunc getHandlerGetFunc(BtlPosEffect effect)
	{
		return null;
	}

	public static void Add(EventSystem pEventSystem, BtlPosEffect effect, BtlPokePos pos, byte pokeID, int[] param, byte param_cnt)
	{
	}

	public static bool Remove(EventSystem pEventSystem, BtlPosEffect eff, BtlPokePos pos)
	{
		return default(bool);
	}

	public static bool IsRegistered(EventSystem pEventSystem, BtlPosEffect eff, BtlPokePos pos)
	{
		return default(bool);
	}

	public static void common_removePosEffect([In] ref EventFactor.EventHandlerArgs args, BtlPokePos myPos)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Negaigoto()
	{
		return null;
	}

	public static void handler_pos_Negaigoto([In] ref EventFactor.EventHandlerArgs args, byte pokePos)
	{
	}

	public static void negaigoto_recoverHP([In] ref EventFactor.EventHandlerArgs args, BtlPokePos btlPokePos)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_MikadukiNoMai()
	{
		return null;
	}

	public static void handler_pos_MikadukiNoMai([In] ref EventFactor.EventHandlerArgs args, byte pokePos)
	{
	}

	public static bool mikadukiNoMai_check(BTL_POKEPARAM bpp)
	{
		return default(bool);
	}

	public static void mikadukiNoMai_recover([In] ref EventFactor.EventHandlerArgs args, byte pokeID, BTL_POKEPARAM bpp, BtlPokePos btlPokePos)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_IyasiNoNegai()
	{
		return null;
	}

	public static void handler_pos_IyasiNoNegai([In] ref EventFactor.EventHandlerArgs args, byte pokePos)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_DelayAttack()
	{
		return null;
	}

	public static void handler_pos_DelayAttack([In] ref EventFactor.EventHandlerArgs args, byte pokePos)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_BatonTouch()
	{
		return null;
	}

	public static void handler_pos_BatonTouch([In] ref EventFactor.EventHandlerArgs args, byte pokePos)
	{
	}
}
