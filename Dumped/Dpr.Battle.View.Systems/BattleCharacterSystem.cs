using System;
using System.Collections;
using System.Runtime.InteropServices;
using Dpr.Battle.Logic;
using Dpr.Battle.View.Objects;
using Pml.PokePara;

namespace Dpr.Battle.View.Systems;

public class BattleCharacterSystem
{
	private BattleViewSystem _viewSystem;

	private BOTrainer[] _trainers;

	private BOPokemon[] _pokemons;

	public BOTrainer[] Trainers
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public BOPokemon[] Pokemons
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public BattleCharacterSystem(BattleViewSystem pViewSystem)
	{
	}

	public void Dispose()
	{
	}

	public IEnumerator StartLoadAllCharacter(bool[] isPokemonSetupFlags, bool[] isTrainerSetupFlags, [Optional] Action onComplete)
	{
		return null;
	}

	public IEnumerator StartLoadPoke(BtlvPos vPos, bool IsVisible, [Optional] Action onComplete)
	{
		return null;
	}

	public IEnumerator StartLoadPoke(BtlvPos vPos, bool IsVisible, BtlvPos vPosTarget, [Optional] Action onComplete)
	{
		return null;
	}

	public IEnumerator StartLoadPoke(BtlvPos vPos, PokemonParam param, bool IsVisible, [Optional] Action onComplete)
	{
		return null;
	}

	public IEnumerator StartLoadExceptionPoke(BtlvPos vPos, PokemonParam param, string AssetBundleName, bool IsVisible, [Optional] Action onComplete)
	{
		return null;
	}

	public void StartDelete(BOPokemon pokemon)
	{
	}

	public bool IsFinishDelete(BOPokemon pokemon)
	{
		return default(bool);
	}

	private IEnumerator StartLoadTrainer(BtlvPos vPos, TRAINER_DATA data, TrainerSimpleParam param, [Optional] Action onComplete)
	{
		return null;
	}

	public BOPokemon GetPokemonModel(BtlvPos vPos)
	{
		return null;
	}

	public BOTrainer GetTrainerModel(BtlvPos vPos)
	{
		return null;
	}

	public IEnumerator StartLoadMigawari([Optional] Action onComplete)
	{
		return null;
	}

	public IEnumerator StartLoadDigudaStone([Optional] Action onComplete)
	{
		return null;
	}
}
