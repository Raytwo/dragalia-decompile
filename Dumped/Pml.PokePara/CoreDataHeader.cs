namespace Pml.PokePara;

public struct CoreDataHeader
{
	public const int SIZE = 8;

	public uint personalRnd;

	public ushort _bitsA;

	public ushort checksum;

	private const int bitsA0_sz = 1;

	private const int bitsA0_loc = 0;

	private const int bitsA1_sz = 1;

	private const int bitsA1_loc = 1;

	private const int bitsA2_sz = 1;

	private const int bitsA2_loc = 2;

	private const int bitsA0_mask = 1;

	private const int bitsA1_mask = 2;

	private const int bitsA2_mask = 4;

	public bool ppFastMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool pppFastMode
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool fuseiTamagoFlag
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
