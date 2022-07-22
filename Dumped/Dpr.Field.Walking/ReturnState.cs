using Dpr.FureaiHiroba;

namespace Dpr.Field.Walking;

public class ReturnState : AIStateBase
{
	private float time;

	private bool isNearPlayer;

	private const int happy1 = 43;

	private const int happy2 = 44;

	private const int happy3 = 45;

	private static readonly int[] Happys;

	private FureaiPokeModel fureaiModel => null;

	private PokeSanpoModel sanpoModel => null;

	private new AIFureaiModel model => null;

	public ReturnState(AIFureaiModel model)
	{
	}

	public override void CommonUpdate()
	{
	}

	protected override void StateUpdate()
	{
	}

	public override void Enter()
	{
	}
}
