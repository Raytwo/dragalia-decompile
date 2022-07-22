using Dpr.FureaiHiroba;

namespace Dpr.Field.Walking;

public class PokeWalkingState : WalkingState
{
	private FureaiPokeModel fureaiModel => null;

	private new AIFureaiModel model => null;

	public PokeWalkingState(AIModel model)
	{
	}

	protected override void StateUpdate()
	{
	}
}
