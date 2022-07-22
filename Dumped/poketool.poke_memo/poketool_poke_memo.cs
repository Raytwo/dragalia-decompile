using System.Runtime.InteropServices;
using DPData;
using Pml.PokePara;
using poketool.pokeplace;

namespace poketool.poke_memo;

public static class poketool_poke_memo
{
	public static void SetFromCapture(CoreParam pParam, [In] ref MYSTATUS pMystatus, uint placeNo)
	{
	}

	public static void SetFromCapture(CoreParam pParam, [In] ref MYSTATUS pMystatus, ZoneID zoneID)
	{
	}

	public static void SetFromEggTaken(CoreParam pParam, [In] ref MYSTATUS pMystatus, uint placeNo)
	{
	}

	public static void SetFromEggTaken(CoreParam pParam, [In] ref MYSTATUS pMystatus, PlaceNo placeNo)
	{
	}

	public static void SetFromEggBirth(CoreParam pParam, [In] ref MYSTATUS pMystatus, uint placeNo)
	{
	}

	public static void SetFromEggBirth(CoreParam pParam, [In] ref MYSTATUS pMystatus, ZoneID zoneId)
	{
	}

	public static bool IsMyPokemon(CoreParam pParam, [In] ref MYSTATUS pMystatus)
	{
		return default(bool);
	}

	public static void SetMyStatus(CoreParam pParam, [In] ref MYSTATUS pMystatus)
	{
	}

	public static void SetFromDistribution(CoreParam pParam, uint placeNo, uint year, uint month, uint day)
	{
	}

	public static void SetPlaceTime(CoreParam pParam, uint placeNo, DataType dataType)
	{
	}

	public static void SetPlaceTime(CoreParam pParam, ZoneID zoneID, DataType dataType)
	{
	}

	public static void SetPlaceTime(CoreParam pParam, uint placeNo, uint year, uint month, uint day, DataType dataType)
	{
	}

	public static void SetPlaceTime(CoreParam pParam, ZoneID zoneID, uint year, uint month, uint day, DataType dataType)
	{
	}

	public static void ClearPlaceTime(CoreParam pParam, DataType type)
	{
	}

	public static void CopyPlaceTime(CoreParam pParam)
	{
	}

	public static void SetGetLevel(CoreParam pParam)
	{
	}

	public static void SetVersion(CoreParam pParam)
	{
	}
}
