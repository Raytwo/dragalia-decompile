using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Dpr.Field.Walking;
using Pml;
using Pml.PokePara;

namespace Dpr.FureaiHiroba;

public sealed class FureaiPokeModel : WalkingCharacterModel
{
	public delegate List<FureaiPokeModel> GetFureaiPokes();

	public bool isSelectPoke;

	public float stateTime;

	public bool isCollided;

	public List<int> CanAnimationList;

	public int CollisionHitCount;

	public int MonohiroiItemNo;

	public int MonohiroiSealNo;

	private FureaiDataManager dataManager;

	public GetFureaiPokes GetHirobaPokes;

	private PokemonParam pokeParam;

	public new FureaiPokeController controller => null;

	public PokeSanpoModel sanpoModel
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public uint TemotiNo => default(uint);

	public uint nakayoshi => default(uint);

	public uint pokeID => default(uint);

	public MonsNo monsNo => default(MonsNo);

	public Seikaku seikaku => default(Seikaku);

	public string NickName => null;

	public PokemonParam GetPokeParam()
	{
		return null;
	}

	public FieldPokemonEntity GetEntity()
	{
		return null;
	}

	public FureaiPokeModel(WalkData walkData, PokemonParam pokeParam, FureaiDataManager dataMng)
	{
	}

	public override void Destroy()
	{
	}

	public void PokeCollisionUpdate()
	{
	}

	public void Debug_SetNakayoshi(uint nakayoshi)
	{
	}

	private void SetNakayoshiRandom()
	{
	}

	public void SetSanpoModel(PokeSanpoModel sanpoModel)
	{
	}

	public void Log()
	{
	}

	public int GetAnimRandom()
	{
		return default(int);
	}

	public bool LottMonohiroiItemID()
	{
		return default(bool);
	}
}
