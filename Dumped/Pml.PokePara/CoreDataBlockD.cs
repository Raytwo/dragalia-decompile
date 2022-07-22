namespace Pml.PokePara;

public struct CoreDataBlockD
{
	public const int WAZA_RECORD_FLAG_LEN = 14;

	public _003CparentsName_003Ee__FixedBuffer parentsName;

	public byte friendship;

	public byte memories_level;

	public byte memories_code;

	public ushort memories_data;

	public byte memories_feel;

	public byte eggGetYear;

	public byte eggGetMonth;

	public byte eggGetDay;

	public byte firstContactYear;

	public byte firstContactMonth;

	public byte firstContactDay;

	public ushort getPlace;

	public ushort birthPlace;

	public byte getBall;

	public byte _bitsA;

	public byte trainingFlag;

	public _003CwazaRecordFlag_003Ee__FixedBuffer wazaRecordFlag;

	public _003CbankUniqueID_003Ee__FixedBuffer bankUniqueID;

	public _003Cpadding_003Ee__FixedBuffer padding;

	private const int bitsA0_sz = 7;

	private const int bitsA0_loc = 0;

	private const int bitsA1_sz = 1;

	private const int bitsA1_loc = 7;

	private const int bitsA0_mask = 127;

	private const int bitsA1_mask = 128;

	public byte getLevel
	{
		get
		{
			return default(byte);
		}
		set
		{
		}
	}

	public byte parentsSex
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
