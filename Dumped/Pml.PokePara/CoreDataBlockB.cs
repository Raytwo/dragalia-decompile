namespace Pml.PokePara;

public struct CoreDataBlockB
{
	public _003Cnickname_003Ee__FixedBuffer nickname;

	public _003Cwaza_003Ee__FixedBuffer waza;

	public _003Cpp_003Ee__FixedBuffer pp;

	public _003CpointupUsedCount_003Ee__FixedBuffer pointupUsedCount;

	public _003CtamagoWaza_003Ee__FixedBuffer tamagoWaza;

	public ushort hp;

	public uint _bitsA;

	public byte effortG;

	public uint sick;

	public uint palma;

	public _003Cpadding_003Ee__FixedBuffer padding;

	private const int bitsA0_sz = 5;

	private const int bitsA0_loc = 0;

	private const int bitsA1_sz = 5;

	private const int bitsA1_loc = 5;

	private const int bitsA2_sz = 5;

	private const int bitsA2_loc = 10;

	private const int bitsA3_sz = 5;

	private const int bitsA3_loc = 15;

	private const int bitsA4_sz = 5;

	private const int bitsA4_loc = 20;

	private const int bitsA5_sz = 5;

	private const int bitsA5_loc = 25;

	private const int bitsA6_sz = 1;

	private const int bitsA6_loc = 30;

	private const int bitsA7_sz = 1;

	private const int bitsA7_loc = 31;

	private const int bitsA0_mask = 31;

	private const int bitsA1_mask = 992;

	private const int bitsA2_mask = 31744;

	private const int bitsA3_mask = 1015808;

	private const int bitsA4_mask = 32505856;

	private const int bitsA5_mask = 1040187392;

	private const int bitsA6_mask = 1073741824;

	private const int bitsA7_mask = int.MinValue;

	public uint talentHp
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint talentAtk
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint talentDef
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint talentAgi
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint talentSpatk
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint talentSpdef
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public bool tamagoFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool nicknameFlag
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}
}
