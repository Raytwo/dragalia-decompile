namespace Dpr.NetworkUtils;

public struct BattleMatchingPokeData
{
	public byte[] pokeData;

	public byte index;

	public byte num;

	public SealParam[] sealData;

	public byte is3DEditMode;

	public byte isAppliedTemplate;

	public byte affixSealCount;

	public uint attachPokemonId;

	public uint attachPersonalRnd;
}
