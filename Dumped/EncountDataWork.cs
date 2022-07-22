using DPData;
using Pml;
using Pml.PokePara;

public class EncountDataWork
{
	public enum GetPokeStatus
	{
		NoActive,
		Active,
		Kill,
		Get
	}

	public static void Create()
	{
	}

	public static bool EncDataSave_CanUseSpray()
	{
		return default(bool);
	}

	public static int GetMovePokeIndex(MonsNo monsno)
	{
		return default(int);
	}

	public static void SetMovePokeData(PokemonParam param, bool init = false)
	{
	}

	public static bool GetMovePokeData(MonsNo monsno, ref MV_POKE_DATA outData)
	{
		return default(bool);
	}

	public static bool GetMovePokeData(int index, ref MV_POKE_DATA outData)
	{
		return default(bool);
	}

	public static void SetMovePokeData_ZoneID(MonsNo monsno, ZoneID zonid)
	{
	}

	public static void SetMovePokeData_ZoneID(int index, ZoneID zonid)
	{
	}

	public static void SetMovePokeData_Status(MonsNo monsno, GetPokeStatus status)
	{
	}

	public static bool IsMovePokeData_ReActive(int index)
	{
		return default(bool);
	}

	public static void SetMovePokeData_Status(int index, GetPokeStatus status)
	{
	}

	public static void MovePoke_RandomZone(MonsNo monsno)
	{
	}

	public static void MovePoke_RandomZone()
	{
	}

	public static void MovePoke_RandomZone(int index)
	{
	}

	public static void MovePoke_PlayerEqualZoneNextZone(ZoneID zoneid)
	{
	}

	public static void MovePoke_NextZone()
	{
	}

	public static ZoneID GetMovePoke_ZoneID(int index)
	{
		return default(ZoneID);
	}

	public static void FukkatuMvPoke()
	{
	}

	public static void SetTairyouHassei(bool flag)
	{
	}

	public static bool IsTairyouHassei()
	{
		return default(bool);
	}

	public static int GetUrayamaIndex(int index)
	{
		return default(int);
	}

	public static void ChangeUrayamaIndex(int diff)
	{
	}

	public static void SetUrayamaIndex(uint num)
	{
	}

	public static void JumpMovePokeAffterBattle(ZoneID playerZone)
	{
	}
}
