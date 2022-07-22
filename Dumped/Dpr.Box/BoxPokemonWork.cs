using Pml.PokePara;

namespace Dpr.Box;

public static class BoxPokemonWork
{
	public const int TRAY_H_LINE = 5;

	public const int TRAY_W_LINE = 6;

	public const int TRAY_POKE_MAX = 30;

	public const int TRAY_MAX = 40;

	public static void GetPokemon(PokemonParam pp, int tray, int pos)
	{
	}

	public static PokemonParam GetPokemon(int tray, int pos)
	{
		return null;
	}

	public static bool CheckPokemon(int tray, int pos, PokemonParam tmp_pp, bool is_egg = true)
	{
		return default(bool);
	}

	public static bool CheckPokemon(int tray, int pos, bool is_egg = true)
	{
		return default(bool);
	}

	public static bool GetPokemonNullPos(int tray, out int pos, PokemonParam tmp_pp)
	{
		return default(bool);
	}

	public static bool PutPokemonEmptyTrayAll(PokemonParam pp, PokemonParam tmp_pp, ref int tray, out int pos)
	{
		return default(bool);
	}

	public static bool PutPokemonEmptyTrayAll(PokemonParam pp, ref int tray, out int pos)
	{
		return default(bool);
	}

	public static bool PutPokemonEmptyTray(PokemonParam pp, PokemonParam tmp_pp, int tray, out int pos)
	{
		return default(bool);
	}

	public static bool PutPokemonEmptyTray(PokemonParam pp, int tray, out int pos)
	{
		return default(bool);
	}

	public static bool PutPokemon(PokemonParam pp, PokemonParam tmp_pp, int tray, int pos)
	{
		return default(bool);
	}

	public static bool PutPokemon(PokemonParam pp, int tray, int pos)
	{
		return default(bool);
	}

	private static bool PutPokemonImpl(PokemonParam pp, PokemonParam tmp_pp, int tray, int pos, bool isLogError = false)
	{
		return default(bool);
	}

	public static void SwapPokemon(int tray1, int pos1, int tray2, int pos2)
	{
	}

	public static void SwapTray(int tray1, int tray2)
	{
	}

	public static void MovePokemon(int tray1, int pos1, int tray2, int pos2, int width, int height, PokemonParam tmp_pp)
	{
	}

	public static void UpdatePokemon(PokemonParam pp, int tray, int pos)
	{
	}

	public static void ClearPokemon(int tray, int pos, PokemonParam tmp_pp)
	{
	}

	public static void ClearPokemon(int tray, int pos)
	{
	}

	public static int GetPokemonCountAll(PokemonParam tmp_pp, bool is_egg = true)
	{
		return default(int);
	}

	public static int GetPokemonCountAll(bool is_egg = true)
	{
		return default(int);
	}

	public static int GetPokemonCount(int tray, PokemonParam tmp_pp, bool is_egg = true)
	{
		return default(int);
	}

	public static int GetPokemonCount(int tray, bool is_egg = true)
	{
		return default(int);
	}

	public static int GetSpaceCountAll(PokemonParam tmp_pp)
	{
		return default(int);
	}

	public static int GetSpaceCountAll()
	{
		return default(int);
	}

	public static int GetSpaceCount(int tray, PokemonParam tmp_pp)
	{
		return default(int);
	}

	public static int GetSpaceCount(int tray)
	{
		return default(int);
	}

	public static bool GetSpacePos(ref int tray, ref int pos, PokemonParam tmp_pp)
	{
		return default(bool);
	}

	public static bool GetSpacePos(ref int tray, ref int pos)
	{
		return default(bool);
	}

	public static int UpdateTrayMax(PokemonParam tmp_pp)
	{
		return default(int);
	}

	public static int UpdateTrayMax()
	{
		return default(int);
	}

	public static void RecoverAll()
	{
	}
}
