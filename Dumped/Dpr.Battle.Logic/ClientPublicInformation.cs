using Pml;
using Pml.PokePara;

namespace Dpr.Battle.Logic;

public sealed class ClientPublicInformation
{
	private class Pokemon
	{
		public byte battlePokeId;

		public MonsNo monsno;

		public ushort formno;

		public Sex sex;

		public byte level;

		public bool haveItem;

		public bool isAppearedOnBattleField;
	}

	private class Party
	{
		public Pokemon[] member;
	}

	private readonly POKECON m_pokecon;

	private Party m_party;

	public ClientPublicInformation(POKECON pokecon)
	{
	}

	private void InitPartyInformation(Party party)
	{
	}

	public byte GetPokemonID(byte memberIndex)
	{
		return default(byte);
	}

	public MonsNo GetPokemonMonsterNo(byte memberIndex)
	{
		return default(MonsNo);
	}

	public ushort GetPokemonFormNo(byte memberIndex)
	{
		return default(ushort);
	}

	public Sex GetPokemonSex(byte memberIndex)
	{
		return default(Sex);
	}

	public byte GetPokemonLevel(byte memberIndex)
	{
		return default(byte);
	}

	public Sick GetPokemonSick(byte memberIndex)
	{
		return default(Sick);
	}

	public bool HavePokemonItem(byte memberIndex)
	{
		return default(bool);
	}

	public bool IsPokemonAppearedOnBattleField(byte memberIndex)
	{
		return default(bool);
	}

	private Pokemon GetPublishedPokemonByMemberIndex(byte memberIndex)
	{
		return null;
	}

	private Pokemon GetPublishedPokemonByMemberIndexConst(byte memberIndex)
	{
		return null;
	}

	public void PublishPokemon(byte memberIndex, byte battlePokeId, MonsNo monsno, ushort formno, Sex sex, byte level, bool haveItem)
	{
	}

	public void SetPokemonAppearedOnBattleField(byte battlePokeId)
	{
	}

	public void SetPokemonHaveItem(byte battlePokeId, bool haveItem)
	{
	}

	public void SetPokemonFormNo(byte battlePokeId, ushort formno)
	{
	}

	private Pokemon GetPublishedPokemonByBattlePokeId(byte battlePokeId)
	{
		return null;
	}

	private Pokemon GetPublishedPokemonByBattlePokeIdConst(byte battlePokeId)
	{
		return null;
	}
}
