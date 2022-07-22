namespace Pml.PokePara;

public struct CoreDataBlockA
{
	public ushort monsno;

	public ushort itemno;

	public uint id;

	public uint exp;

	public ushort tokuseino;

	public ushort _bitsA;

	public ushort boxMark;

	public uint colorRnd;

	public byte seikaku;

	public byte seikakuHosei;

	public byte _bitsB;

	public ushort formNo;

	public byte effortHp;

	public byte effortAtk;

	public byte effortDef;

	public byte effortAgi;

	public byte effortSpatk;

	public byte effortSpdef;

	public byte style;

	public byte beautiful;

	public byte cute;

	public byte clever;

	public byte strong;

	public byte fur;

	public byte pokerus;

	public uint ribbonA;

	public uint ribbonB;

	public byte lumpingRibbonA;

	public byte lumpingRibbonB;

	public uint ribbonC;

	public uint ribbonD;

	public uint _bitsC;

	public uint camp_reserved;

	public byte talentHeight;

	public byte talentWeight;

	public _003Cpadding_003Ee__FixedBuffer padding;

	private const int bitsA0_sz = 1;

	private const int bitsA0_loc = 0;

	private const int bitsA1_sz = 1;

	private const int bitsA1_loc = 1;

	private const int bitsA2_sz = 1;

	private const int bitsA2_loc = 2;

	private const int bitsA3_sz = 1;

	private const int bitsA3_loc = 3;

	private const int bitsA4_sz = 1;

	private const int bitsA4_loc = 4;

	private const int bitsA5_sz = 1;

	private const int bitsA5_loc = 5;

	private const int bitsA0_mask = 1;

	private const int bitsA1_mask = 2;

	private const int bitsA2_mask = 4;

	private const int bitsA3_mask = 8;

	private const int bitsA4_mask = 16;

	private const int bitsA5_mask = 32;

	private const int bitsB0_sz = 1;

	private const int bitsB0_loc = 0;

	private const int bitsB1_sz = 1;

	private const int bitsB1_loc = 1;

	private const int bitsB2_sz = 2;

	private const int bitsB2_loc = 2;

	private const int bitsB0_mask = 1;

	private const int bitsB1_mask = 2;

	private const int bitsB2_mask = 12;

	private const int bitsC0_sz = 8;

	private const int bitsC0_loc = 0;

	private const int bitsC0_mask = 255;

	public bool tokusei1Flag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool tokusei2Flag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool tokusei3Flag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool favoriteFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool special_g_flag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool debug_edit_flag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool eventGetFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool officialBattleEnableFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public byte sex
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public uint camp_friendship
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}
}
