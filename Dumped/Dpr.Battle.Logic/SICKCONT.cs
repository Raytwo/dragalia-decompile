using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public static class SICKCONT
{
	public static BTL_SICKCONT MakeNull()
	{
		return default(BTL_SICKCONT);
	}

	public static bool IsNull([In] ref BTL_SICKCONT cont)
	{
		return default(bool);
	}

	public static BTL_SICKCONT MakeTurn(byte causePokeID, byte turns)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakeTurnParam(byte causePokeID, byte turns, ushort param)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePoke(byte causePokeID, byte pokeID)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePermanent(byte causePokeID)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePermanentInc(byte causePokeID, byte count_max)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePermanentParam(byte causePokeID, ushort param)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePermanentIncParam(byte causePokeID, byte count_max, ushort param)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePokeTurn(byte causePokeID, byte pokeID, byte turns)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakePokeTurnParam(byte causePokeID, byte pokeID, byte turns, ushort param)
	{
		return default(BTL_SICKCONT);
	}

	public static BTL_SICKCONT MakeMoudokuCont(byte causePokeID)
	{
		return default(BTL_SICKCONT);
	}

	public static bool IsMoudokuCont([In] ref BTL_SICKCONT cont)
	{
		return default(bool);
	}

	public static byte GetPokeID([In] ref BTL_SICKCONT cont)
	{
		return default(byte);
	}

	public static void SetPokeID(ref BTL_SICKCONT cont, byte pokeID)
	{
	}

	public static byte GetTurnMax([In] ref BTL_SICKCONT cont)
	{
		return default(byte);
	}

	public static void AddParam(ref BTL_SICKCONT cont, ushort param)
	{
	}

	public static ushort GetParam([In] ref BTL_SICKCONT cont)
	{
		return default(ushort);
	}

	public static void SetFlag(ref BTL_SICKCONT cont, bool flag)
	{
	}

	public static bool GetFlag([In] ref BTL_SICKCONT cont)
	{
		return default(bool);
	}

	public static void IncTurn(ref BTL_SICKCONT cont, byte inc)
	{
	}

	public static void SetTurn(ref BTL_SICKCONT cont, byte turn)
	{
	}

	public static byte GetCausePokeID([In] ref BTL_SICKCONT cont)
	{
		return default(byte);
	}

	public static void SetCausePokeID(ref BTL_SICKCONT cont, byte pokeID)
	{
	}

	public static void Split32bit([In] ref BTL_SICKCONT cont, out uint high, out uint low)
	{
	}

	public static void Unite32bit(out BTL_SICKCONT cont, uint high, uint low)
	{
	}
}
