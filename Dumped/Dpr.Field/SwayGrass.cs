using Audio;
using Dpr.Battle.Logic;
using Pml;
using UnityEngine;

namespace Dpr.Field;

public static class SwayGrass
{
	public class GrassData
	{
		public bool enable;

		public float effectTime;

		public bool rensaMons;

		public int rank;

		public int random_iro;

		public int random_kakure;

		public Vector3 position;

		public int attricode;

		public GameObject transObject;
	}

	public const uint MAX_RENSA_COUNT = 99999999u;

	private const int SWAY_GRASS_MAX = 4;

	private const int SWAY_GRASS_SEARCH_SIZE = 9;

	private static bool is_swaygrass_flag;

	private static ZoneID swayZone;

	private static GrassData[] grass_data;

	private static AudioInstance[] _grassAudio;

	public static GrassData work_data;

	public static uint rensa_count;

	public static MonsNo rensa_mons;

	public static uint rensa_lv;

	public static bool BattleEndRensaStart;

	public static GameObject RootGrass;

	public const int POKETORE_CHARGE_MAX = 50;

	public static bool _callSwayBGM;

	public static bool _callStopSwayBGM;

	public const int LOT_NO_GRASS = 0;

	public const int LOT_FAIL = 1;

	public const int LOT_OK = 2;

	public static void SwayGrass_InitSwayGrass()
	{
	}

	public static void StopSE()
	{
	}

	public static bool SwayGrass_CheckSpEncount(ref FieldEncount.SWAY_ENC_INFO info, ref Vector3 pos, float size)
	{
		return default(bool);
	}

	public static bool SwayGrass_CheckValid()
	{
		return default(bool);
	}

	public static int CheckSwayGrass(ref Vector3 pos, float size)
	{
		return default(int);
	}

	private static bool GetChainFlg(int inRound, BtlResult inBattleResult)
	{
		return default(bool);
	}

	public static void SwayGrass_ChargePokeSearcher(byte diff)
	{
	}

	public static int LotSwayGrass(ref Vector2Int grid, float height)
	{
		return default(int);
	}

	public static bool SwayZone()
	{
		return default(bool);
	}

	public static void Update(float deltatime)
	{
	}

	private static void PlayEffect(float deltatime, int i)
	{
	}

	public static int RensaNum(uint rensa, bool omamori = false)
	{
		return default(int);
	}

	public static void BtlResultRensa(BtlResult result)
	{
	}

	public static byte RensaTalent()
	{
		return default(byte);
	}
}
