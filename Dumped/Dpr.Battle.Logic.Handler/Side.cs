using System.Runtime.InteropServices;
using Pml.WazaData;

namespace Dpr.Battle.Logic.Handler;

public static class Side
{
	public delegate EventFactor.EventHandlerTable[] HandlerGetFunc();

	private struct GET_FUNC_TABLE_ELEM
	{
		public BtlSideEffect eff;

		public HandlerGetFunc func;

		public GET_FUNC_TABLE_ELEM(BtlSideEffect eff, HandlerGetFunc func)
		{
		}
	}

	private const int WORKIDX_SICKCONT_HIGH = 6;

	private const int WORKIDX_SICKCONT_LOW = 5;

	private static readonly GET_FUNC_TABLE_ELEM[] GET_FUNC_TABLE;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Reflector;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Hikarinokabe;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_AuroraVeil;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Sinpinomamori;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SiroiKiri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Oikaze;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Omajinai;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_StealthRock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_StealthRock_Hagane;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_WideGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_FastGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TatamiGaeshi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_TrickGuard;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Makibisi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dokubisi;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_NebaNebaNet;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_SpotLight;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Rainbow;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Burning;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Moor;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GShock_Honoo;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_GShock_Iwa;

	public static EventFactor GetEventFactor(EventSystem pEventSystem, BtlSide side, BtlSideEffect sideEffect)
	{
		return null;
	}

	public static HandlerGetFunc getHandlerGetFunc(BtlSideEffect sideEffect)
	{
		return null;
	}

	public static void Add(EventSystem pEventSystem, BtlSide side, BtlSideEffect sideEffect, [In] ref BTL_SICKCONT contParam)
	{
	}

	public static bool Remove(EventSystem pEventSystem, BtlSide side, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public static bool Sleep(EventSystem pEventSystem, BtlSide side, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public static bool Weak(EventSystem pEventSystem, BtlSide side, BtlSideEffect sideEffect)
	{
		return default(bool);
	}

	public static bool IsExist(EventSystem pEventSystem, BtlSide side, BtlSideEffect effect)
	{
		return default(bool);
	}

	public static void GetSickCont([In] ref EventFactor.EventHandlerArgs args, out BTL_SICKCONT sickcont)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Reflector()
	{
		return null;
	}

	public static void handler_side_Reflector([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Hikarinokabe()
	{
		return null;
	}

	public static void handler_side_HikariNoKabe([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_AuroraVeil()
	{
		return null;
	}

	public static void handler_side_AuroraVeil([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void common_wallEffect([In] ref EventFactor.EventHandlerArgs args, byte mySide, WazaDamageType dmgType)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Sinpinomamori()
	{
		return null;
	}

	public static void handler_side_SinpiNoMamori_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_side_SinpiNoMamori_FixFail([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_SiroiKiri()
	{
		return null;
	}

	public static void handler_side_SiroiKiri_CheckFail([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_side_SiroiKiri_FixFail([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Oikaze()
	{
		return null;
	}

	public static void handler_side_Oikaze([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Omajinai()
	{
		return null;
	}

	public static void handler_side_Omajinai([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_StealthRock()
	{
		return null;
	}

	public static void handler_side_StealthRock([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static ushort stealthRock_CalcDamage(BTL_POKEPARAM target, byte damageType)
	{
		return default(ushort);
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_StealthRock_Hagane()
	{
		return null;
	}

	public static void handler_side_StealthRock_Hagane([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_WideGuard()
	{
		return null;
	}

	public static void handler_side_WideGuard([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_FastGuard()
	{
		return null;
	}

	public static void handler_side_FastGuard([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_side_FastGuard_Dmg([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_side_FastGuard_MsgAfterCritical([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_TatamiGaeshi()
	{
		return null;
	}

	public static void handler_side_TatamiGaeshi([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_side_TatamiGaeshi_DmgG([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_side_Tatamigaeshi_MsgAfterCritical([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_TrickGuard()
	{
		return null;
	}

	public static void handler_side_TrickGuard([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Makibisi()
	{
		return null;
	}

	public static void handler_side_Makibisi([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Dokubisi()
	{
		return null;
	}

	public static void handler_side_Dokubisi([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_NebaNebaNet()
	{
		return null;
	}

	public static void handler_side_NebaNebaNet([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_SpotLight()
	{
		return null;
	}

	public static void handler_SpotLight_TemptTarget([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Rainbow()
	{
		return null;
	}

	public static void handler_Rainbow([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static void handler_Rainbow_Shrink([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Burning()
	{
		return null;
	}

	public static void handler_side_Burning([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_Moor()
	{
		return null;
	}

	public static void handler_side_Moor([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_GShock_Honoo()
	{
		return null;
	}

	public static void handler_side_GShock_Honoo([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_SIDE_GShock_Iwa()
	{
		return null;
	}

	public static void handler_side_GShock_Iwa([In] ref EventFactor.EventHandlerArgs args, byte mySide)
	{
	}
}
