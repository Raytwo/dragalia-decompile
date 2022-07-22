namespace Pml.PokePara;

public class InitialSpec
{
	public const ulong INIT_SPEC_ID_RANDOM = ulong.MaxValue;

	public const ulong INIT_SPEC_PERSONALRND_RANDOM = ulong.MaxValue;

	public const ulong INIT_SPEC_RARE_FALSE = 8589934591uL;

	public const ulong INIT_SPEC_RARE_TRUE = 12884901887uL;

	public const ulong INIT_SPEC_RARE_RANDOM = 17179869183uL;

	public ulong randomSeed;

	public bool isRandomSeedEnable;

	public ulong personalRnd;

	public ulong rareRnd;

	public ulong id;

	public MonsNo monsno;

	public ushort formno;

	public ushort level;

	public ushort sex;

	public ushort seikaku;

	public byte tokuseiIndex;

	public byte rareTryCount;

	public ushort[] talentPower;

	public uint friendship;

	public byte talentVNum;

	public ushort weight;

	public ushort height;

	public void CopyFrom(InitialSpec src)
	{
	}
}
