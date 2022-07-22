using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using DPData;
using Dpr.EvScript;
using Dpr.UI;
using Pml;
using Pml.PokePara;
using UnityEngine;

public static class FieldPoketch
{
	public class DowsingResult
	{
		public List<Vector2> ItemPoints;

		public bool ExistItem;
	}

	public enum HidenWazaType
	{
		Iwakudaki,
		Iaigiri,
		Sorawotobu,
		Kiribarai,
		Naminori,
		Kairiki,
		Rockclimb,
		Takinobori
	}

	private static Dictionary<HidenWazaType, (EvWork.SYSFLAG_INDEX, ItemNo)> HidenWazaParams;

	public static void RegisterEvent()
	{
	}

	public static void UnregisterEvent()
	{
	}

	public static PoketchWindow CreatePoketchWindow()
	{
		return null;
	}

	public static void CreanPoketchWindow()
	{
	}

	public static void OnPushedHideButton()
	{
	}

	public static void HidePoketch(bool doCallback = false)
	{
	}

	public static void OnPushedAppearButton()
	{
	}

	public static bool IsRejectPoketch()
	{
		return default(bool);
	}

	public static bool IsCloseOncePoketch()
	{
		return default(bool);
	}

	public static void RestorePoketchWindow()
	{
	}

	private static void OpenPoketchWindow()
	{
	}

	public static bool IsControlPoketch()
	{
		return default(bool);
	}

	public static void CountPoketchPedometer(int num)
	{
	}

	public static void SetAvailablePoketchApp(POKETCH_APPID appId)
	{
	}

	public static bool IsAvailablePoketchApp(POKETCH_APPID appId)
	{
		return default(bool);
	}

	public static void AddPokemonHistory(PokemonParam pokeParam)
	{
	}

	public static void AddPokemonHistory(int monsno, int form)
	{
	}

	public static DowsingResult Dowsing(Vector2 sonarCenterPos)
	{
		return null;
	}

	public static Vector2Int DowsingScreenToGrid([In] ref Vector2 position, [In] ref Vector2Int gridOrigin)
	{
		return default(Vector2Int);
	}

	public static Vector2 GridToDowsingScreen([In] ref Vector2Int grid, [In] ref Vector2Int gridOrigin)
	{
		return default(Vector2);
	}

	private static int HitSonar([In] ref Vector2Int itemPos, [In] ref Vector2Int sonarCenterGrid, [In] ref Vector2Int gridLT, [In] ref Vector2Int gridRB)
	{
		return default(int);
	}

	public static bool IsGetHidenWaza(HidenWazaType hidenWazaType)
	{
		return default(bool);
	}

	public static bool IsGetHidenWazaMachine(HidenWazaType hidenWazaType)
	{
		return default(bool);
	}

	public static UIManager.FieldUseResult AvailableHidenWaza(HidenWazaType hidenWazaType)
	{
		return default(UIManager.FieldUseResult);
	}

	private static bool AvailableHidenWazaCore(HidenWazaType hidenWazaType)
	{
		return default(bool);
	}

	public static void UseHidenWaza(HidenWazaType hidenWazaType)
	{
	}

	public static bool CanUseHidenWaza(HidenWazaType hidenWazaType)
	{
		return default(bool);
	}

	private static bool AvailableIwakudakiObject(FieldObjectEntity obj)
	{
		return default(bool);
	}

	private static bool AvailableIaigiriObject(FieldObjectEntity obj)
	{
		return default(bool);
	}

	private static bool AvailableRockclimbObject(FieldObjectEntity obj)
	{
		return default(bool);
	}

	private static bool AvailableKairikiObject(FieldObjectEntity obj)
	{
		return default(bool);
	}

	private static FieldObjectEntity SearchCanHidenContactObject(Func<FieldObjectEntity, bool> CheckFunc, out int outIndex)
	{
		return null;
	}

	private static bool CanHidenContact(Func<FieldObjectEntity, bool> CheckFunc)
	{
		return default(bool);
	}

	private static void ContactHidenObject(int index, FieldObjectEntity entity, string label)
	{
	}

	private static void JumpHidenEvent(string label)
	{
	}
}
