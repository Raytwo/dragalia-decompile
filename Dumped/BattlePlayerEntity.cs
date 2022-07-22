using Dpr.Battle.View;
using UnityEngine;

public sealed class BattlePlayerEntity : BattleCharacterEntity
{
	[SerializeField]
	private Renderer _watchRenderer;

	[SerializeField]
	private Renderer[] _hatRenderers;

	[SerializeField]
	private Renderer[] _shoesRenderers;

	public int HatVariationParam;

	public int ShoesVariationParam;

	private bool isCaputureDemo;

	public ColorVariation ColorVariation => null;

	public override string entityType => null;

	public bool watchVisibility
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public int HatVariation
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int ShoesVariation
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public override void Initialize(TrainerSimpleParam param, bool isContest = false)
	{
	}

	public override void SetCaputureDemo()
	{
	}

	public override void SetRenderActive(bool isActive)
	{
	}

	protected override void Awake()
	{
	}
}
