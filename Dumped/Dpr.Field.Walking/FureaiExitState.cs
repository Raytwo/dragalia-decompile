using System;
using Dpr.FureaiHiroba;

namespace Dpr.Field.Walking;

public class FureaiExitState : AIStateBase
{
	public Action OnPlayerNear;

	private float time;

	private bool isRouteNull;

	private FureaiPokeModel fureaiModel => null;

	private new AIFureaiModel model => null;

	public FureaiExitState(AIFureaiModel model)
	{
	}

	protected override void StateUpdate()
	{
	}
}
