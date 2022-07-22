using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic.Handler;

public static class Field
{
	public delegate EventFactor.EventHandlerTable[] HandlerGetFunc(byte subParam);

	private struct GET_FUNC_TABLE_ELEM
	{
		public EffectType effect;

		public HandlerGetFunc func;

		public GET_FUNC_TABLE_ELEM(EffectType effect, HandlerGetFunc func)
		{
		}
	}

	private static readonly GET_FUNC_TABLE_ELEM[] getHandlerGetFuncTable;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Ooame;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Oohideri;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Rankiryuu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Dammy;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_TrickRoom;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_Juryoku;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_Sawagu;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_WonderRoom;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_Fuin;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_MagicRoom;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_FairyLock;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_PlasmaShower;

	private static readonly EventFactor.EventHandlerTable[] HandlerTable_Fld_KagakuhenkaGas;

	private static readonly EventFactor.EventHandlerTable[] GrassHandlerTable;

	private static readonly EventFactor.EventHandlerTable[] MistHandlerTable;

	private static readonly EventFactor.EventHandlerTable[] ElecHandlerTable;

	private static readonly EventFactor.EventHandlerTable[] PhychoHandlerTable;

	private static readonly EventFactor.EventHandlerTable[] DammyHandlerTable;

	public static HandlerGetFunc getHandlerGetFunc(EffectType effect)
	{
		return null;
	}

	public static bool Add(EventSystem pEventSystem, EffectType effect, byte subParam)
	{
		return default(bool);
	}

	public static void Remove(EventSystem pEventSystem, EffectType effect)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_Weather(byte sub_param)
	{
		return null;
	}

	public static void handler_fld_Weather([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_ooame_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_oohideri_CheckExe([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_rankiryuu_CheckAff([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_rankiryuu_AfterDamage([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_TrickRoom(byte sub_param)
	{
		return null;
	}

	public static void handler_fld_TrickRoom([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_Juryoku(byte sub_param)
	{
		return null;
	}

	public static void handler_fld_Jyuryoku_AdjustDmg([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_fld_Jyuryoku_CheckAff([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_Sawagu(byte sub_param)
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_WonderRoom(byte sub_param)
	{
		return null;
	}

	public static void handler_fld_WonderRoom([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_Fuin(byte sub_param)
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_MagicRoom(byte sub_param)
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_FairyLock(byte sub_param)
	{
		return null;
	}

	public static void handler_fld_dummy([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_PlasmaShower(byte sub_param)
	{
		return null;
	}

	public static void handler_plasma_shower([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_plasmaShower_ChangeGWaza([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_KagakuhenkaGas(byte sub_param)
	{
		return null;
	}

	public static EventFactor.EventHandlerTable[] ADD_Fld_Ground(byte sub_param)
	{
		return null;
	}

	public static bool common_isGroundEffective([In] ref EventFactor.EventHandlerArgs args, byte pokeID)
	{
		return default(bool);
	}

	public static void handler_grass_power([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_grass_turncheck([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_mist_power([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_mist_checkFail([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_mist_sickFailed([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_elec_power([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_elec_checkFail([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_elec_sickFailed([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void common_field_sickGuardSucceed([In] ref EventFactor.EventHandlerArgs args, ContFlag pokeContFlag, ushort strID)
	{
	}

	public static void handler_phycho_power([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}

	public static void handler_phycho_noEffectCheck([In] ref EventFactor.EventHandlerArgs args, byte subParam)
	{
	}
}
