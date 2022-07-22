using System.Collections;
using Dpr.SubContents;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.Demo;

public class Demo_Evolve : DemoBase
{
	public class Param
	{
		public PokemonParam pokemonParam;

		public MonsNo nextMonsNo;

		public bool useCancel;

		public uint evoRoute;

		public void Evolve()
		{
		}

		public void Destroy()
		{
		}
	}

	public enum Result
	{
		None,
		Cancel,
		Complete
	}

	private enum EvoState
	{
		Start,
		Evo1,
		Evo2,
		Stop,
		EvoEnd
	}

	public UnityAction<Result> OnResult;

	private TimeLineBinder timeLine;

	private Result _result;

	private EvoState nowState;

	private Param _param;

	private float EvolvedDistance;

	private GameObject Poke3D;

	private GameObject NextPoke3D;

	public bool IsTradeAffter;

	public bool IsGetEvolveMonsNo;

	public bool IsGetPokemon;

	public UnionTradeManager.BoxPokeData TradeAfter_RealPokeParam;

	private MarkerReceiver receiver;

	private bool isAutoInput;

	private float messageElapsed;

	public Demo_Evolve(Param param)
	{
	}

	public Demo_Evolve()
	{
	}

	public override void Destroy()
	{
	}

	public override void Init()
	{
	}

	public override IEnumerator Enter()
	{
		return null;
	}

	public override IEnumerator Main()
	{
		return null;
	}

	private IEnumerator WazaOboe(WazaLearningResult result, WazaNo wazaNo, PokemonParam pokeParam)
	{
		return null;
	}

	public bool AddNukenin()
	{
		return default(bool);
	}

	public override IEnumerator Exit()
	{
		return null;
	}

	private IEnumerator Evolve()
	{
		return null;
	}

	private void AnimationUpdate(float deltaTime)
	{
	}

	private void GoNextState()
	{
	}
}
