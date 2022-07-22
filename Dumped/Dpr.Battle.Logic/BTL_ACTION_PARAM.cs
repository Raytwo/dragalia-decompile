namespace Dpr.Battle.Logic;

public struct BTL_ACTION_PARAM
{
	public long raw;

	private const int gen_sz0 = 4;

	private const int gen_loc0 = 0;

	private const int gen_sz1 = 5;

	private const int gen_loc1 = 4;

	private const int gen_sz2 = 55;

	private const int gen_loc2 = 9;

	private const long gen_mask0 = 15L;

	private const long gen_mask1 = 496L;

	private const long gen_mask2 = -512L;

	private const int fight_sz0 = 4;

	private const int fight_loc0 = 0;

	private const int fight_sz1 = 5;

	private const int fight_loc1 = 4;

	private const int fight_sz2 = 4;

	private const int fight_loc2 = 9;

	private const int fight_sz3 = 16;

	private const int fight_loc3 = 13;

	private const int fight_sz4 = 1;

	private const int fight_loc4 = 29;

	private const int fight_sz5 = 1;

	private const int fight_loc5 = 30;

	private const int fight_sz6 = 1;

	private const int fight_loc6 = 31;

	private const int fight_sz7 = 1;

	private const int fight_loc7 = 32;

	private const int fight_sz8 = 1;

	private const int fight_loc8 = 33;

	private const long fight_mask0 = 15L;

	private const long fight_mask1 = 496L;

	private const long fight_mask2 = 7680L;

	private const long fight_mask3 = 536862720L;

	private const long fight_mask4 = 536870912L;

	private const long fight_mask5 = 1073741824L;

	private const long fight_mask6 = 2147483648L;

	private const long fight_mask7 = 4294967296L;

	private const long fight_mask8 = 8589934592L;

	private const int item_sz0 = 4;

	private const int item_loc0 = 0;

	private const int item_sz1 = 5;

	private const int item_loc1 = 4;

	private const int item_sz2 = 8;

	private const int item_loc2 = 9;

	private const int item_sz3 = 16;

	private const int item_loc3 = 17;

	private const int item_sz4 = 8;

	private const int item_loc4 = 33;

	private const long item_mask0 = 15L;

	private const long item_mask1 = 496L;

	private const long item_mask2 = 130560L;

	private const long item_mask3 = 8589803520L;

	private const long item_mask4 = 2190433320960L;

	private const int change_sz0 = 4;

	private const int change_loc0 = 0;

	private const int change_sz1 = 5;

	private const int change_loc1 = 4;

	private const int change_sz2 = 3;

	private const int change_loc2 = 9;

	private const int change_sz3 = 3;

	private const int change_loc3 = 12;

	private const int change_sz4 = 1;

	private const int change_loc4 = 15;

	private const long change_mask0 = 15L;

	private const long change_mask1 = 496L;

	private const long change_mask2 = 3584L;

	private const long change_mask3 = 28672L;

	private const long change_mask4 = 32768L;

	private const int escape_sz0 = 4;

	private const int escape_loc0 = 0;

	private const int escape_sz1 = 5;

	private const int escape_loc1 = 4;

	private const long escape_mask0 = 15L;

	private const long escape_mask1 = 496L;

	private const int g_start_sz0 = 4;

	private const int g_start_loc0 = 0;

	private const int g_start_sz1 = 5;

	private const int g_start_loc1 = 4;

	private const long g_start_mask0 = 15L;

	private const long g_start_mask1 = 496L;

	private const int cheer_sz0 = 4;

	private const int cheer_loc0 = 0;

	private const int cheer_sz1 = 5;

	private const int cheer_loc1 = 4;

	private const long cheer_mask0 = 15L;

	private const long cheer_mask1 = 496L;

	public byte gen_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte gen_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public ulong gen_param
	{
		get
		{
			return default(ulong);
		}
		set
		{
		}
	}

	public byte fight_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte fight_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte fight_targetPos
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public ushort fight_waza
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public bool fight_wazaInfoFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool fight_ultraBurstFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool fight_gFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool fight_forbidGWaza
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool fight_forceGWaza
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public byte item_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte item_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte item_targetID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public ushort item_number
	{
		get
		{
			return default(ushort);
		}
		set
		{
		}
	}

	public byte item_param
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte change_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte change_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte change_posIdx
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte change_memberIdx
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public bool change_depleteFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public byte escape_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte escape_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte g_start_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte g_start_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte cheer_cmd
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte cheer_pokeID
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}
}
