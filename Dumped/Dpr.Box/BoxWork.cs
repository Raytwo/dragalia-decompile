namespace Dpr.Box;

public static class BoxWork
{
	public const int TRAY_NUM_1ST = 18;

	public const int TRAY_NUM_2ND = 24;

	public const int TRAY_NUM_3RD = 30;

	public const int TRAY_NUM_4TH = 35;

	public const int TRAY_NUM_5TH = 40;

	public const int TRAY_MAX = 40;

	public const int TRAY_NAME_LEN = 16;

	public const int TRAY_NAME_BUFSIZE = 17;

	public const int TRAY_POKE_MAX = 30;

	public const int NORMAL_WALLPAPER_MAX = 32;

	private const int BATTLE_BOX_TRAY_NUMBER = 255;

	public const int TEAM_POKE_NONE = 65535;

	public const int TEAM_MAX = 6;

	public const int TEAM_POKE_MAX = 6;

	public const int TEAM_NAME_LEN = 10;

	public const int TEAM_NAME_BUFSIZE = 11;

	public static SaveBoxData m_boxData => default(SaveBoxData);

	public static void SwapTray(int tray1, int tray2)
	{
	}

	public static void SetTrayName(string str, int tray)
	{
	}

	public static string GetTrayName(int tray)
	{
		return null;
	}

	public static void ChangePokemon(int tray1, int pos1, int tray2, int pos2)
	{
	}

	public static void ChangeTeam(int tray1, int tray2)
	{
	}

	public static void SetTeamName(string str, int team)
	{
	}

	public static string GetTeamName(int team)
	{
		return null;
	}

	public static int GetTeamPokeBoxTray(int team, int pos)
	{
		return default(int);
	}

	public static int GetTeamPokeBoxPos(int team, int pos)
	{
		return default(int);
	}

	public static bool IsTeam(int team)
	{
		return default(bool);
	}

	public static bool IsTeamPos(int team, int pos)
	{
		return default(bool);
	}

	public static bool IsPokeTeam(int tray, int pos)
	{
		return default(bool);
	}

	public static bool IsPokeTeam(int tray, int pos, int team)
	{
		return default(bool);
	}

	public static int GetPokeTeamPos(int tray, int pos, int team)
	{
		return default(int);
	}

	public static int GetTeamPokeCount(int team)
	{
		return default(int);
	}

	public static void DeleteTeam(int tray, int pos, bool isPack = false)
	{
	}

	public static void DeletePackTeam(int team, int pos)
	{
	}

	public static void PackTeam(int team)
	{
	}

	public static bool IsTeamLock(int team)
	{
		return default(bool);
	}

	public static bool IsPokeLock(int tray, int pos)
	{
		return default(bool);
	}

	public static int SetTeamPokePos(int team, int team_pos, int tray, int tray_pos)
	{
		return default(int);
	}

	public static void SetTeamLock(int team, bool is_lock)
	{
	}

	public static void SetWallPaper(int tray, int val)
	{
	}

	public static int GetWallPaper(int tray)
	{
		return default(int);
	}

	public static void SetTrayMax(int max)
	{
	}

	public static int GetOpenTrayMax()
	{
		return default(int);
	}

	public static int GetTrayMax()
	{
		return default(int);
	}

	public static void SetCurrentTray(int tray)
	{
	}

	public static int GetCurrentTray()
	{
		return default(int);
	}

	public static void SetStatusPut(int mode)
	{
	}

	public static int GetStatusPut()
	{
		return default(int);
	}
}
