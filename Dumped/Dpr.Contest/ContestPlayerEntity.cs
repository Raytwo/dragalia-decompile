using System.Collections.Generic;
using Dpr.Battle.View.Objects;
using Dpr.Trainer;
using UnityEngine;
using XLSXContent;

namespace Dpr.Contest;

public class ContestPlayerEntity
{
	private readonly Vector3 RESET_BALL_POS;

	private XLSXContent.PokemonInfo.SheetCatalog catalog;

	private Object assetPokeModel;

	private List<BtlvEffectInstance> iPtrSealEffects;

	private BtlvEffectInstance iPtrLightEffect;

	private BOPokemon wazaPoke;

	private BOTrainer boTrainer;

	private BOPokemon boPokemon;

	private ObjectEntity ballEntity;

	private AContestPlayerData playerData;

	private Sprite pmIconSpr;

	private Sprite wazaTypeIconSpr;

	private Vector3 defaultTrainerPos;

	private Vector3 defaultPokemonPos;

	private TrainerType trainerType;

	private int colorID;

	private string characterModelPath;

	private string pokeModelPath;

	private string ballModelPath;

	private string pokeIconPath;

	public AContestPlayerData PlayerData => null;

	public int Index => default(int);

	public PlayerType PlayerType => default(PlayerType);

	public BOTrainer BoTrainer => null;

	public BOPokemon BoPokemon => null;

	public ObjectEntity BallEntity => null;

	public XLSXContent.PokemonInfo.SheetCatalog Catalog => null;

	public bool IsActiveBOPokemon => default(bool);

	public bool IsActiveWazaPokemon => default(bool);

	public List<BtlvEffectInstance> SealEffects => null;

	public BtlvEffectInstance LightEffect => null;

	public BOPokemon WazaPokemon => null;

	public ContestPlayerEntity(AContestPlayerData playerData)
	{
	}

	public void Setup()
	{
	}

	private void SetupTrainerModel()
	{
	}

	private void SetupPokeModel()
	{
	}

	public void Dispose()
	{
	}

	public void ResetParam(Vector3 trainerPos, Vector3 pokemonPos)
	{
	}

	public Sprite GetPmIconSpr()
	{
		return null;
	}

	public Sprite GetWazaTypeIconSpr()
	{
		return null;
	}

	public int CalcTotalScore()
	{
		return default(int);
	}

	public void AppendLoadResource(Transform cluster, Transform parent, Vector3 trainerPos, Vector3 pokemonPos, int colorID, TrainerType trainerType, bool isUser)
	{
	}

	private void AppendLoadTrainerModel(string path, Transform cluster, Vector3 pos, int colorID, TrainerType trainerType)
	{
	}

	private void AppendLoadPokemonModel(string path, Transform parent, Vector3 pos, bool isUser)
	{
	}

	public void CreateCopyModel(Transform parent)
	{
	}

	private void AppendLoadBallModel(string path, Transform cluster)
	{
	}

	private void CreateSealEffectInstance()
	{
	}

	private void ReleaseBallEffects()
	{
	}

	private void AppendLoadWazaTypeIcon()
	{
	}

	private void AppendLoadPokemonIcon()
	{
	}

	public void ReplaceWazaPokemon(BOPokemon boPokemon)
	{
	}

	public void OnLaunchWazaAnimation(Vector3 pos)
	{
	}

	public void OnFinishWazaAnimation()
	{
	}

	public void SetModelRenderActive(bool active)
	{
	}

	private void UnloadAssetBundle()
	{
	}

	private void ReleaseBallResource()
	{
	}
}
