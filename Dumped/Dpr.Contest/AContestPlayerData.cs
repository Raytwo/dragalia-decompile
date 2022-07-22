using Dpr.Battle.View;
using Dpr.Trainer;

namespace Dpr.Contest;

public class AContestPlayerData
{
	public PlayerType playerType;

	public int index;

	public PlayerInfo playerInfo;

	public PokemonInfo pokemonInfo;

	public BtlvBallInfo ballInfo;

	public PlayerVisualDataModel visualDataModel;

	public PlayerDanceDataModel danceDataModel;

	public int modelColorID;

	public TrainerType trainerType;

	public string trainerModelPath;

	public string pokemonModelPath;

	public string ballModelPath;
}
