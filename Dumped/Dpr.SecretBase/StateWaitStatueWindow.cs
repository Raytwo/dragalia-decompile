namespace Dpr.SecretBase;

public class StateWaitStatueWindow : StateBase<StatuePlacementEditController.State, StatuePlacementEditController>
{
	private enum LocalState
	{
		Press,
		Spread
	}

	private LocalState state;

	private float timer;

	private PlacementData placement;

	public void Enter_WaitStatueWindow(PlacementData statue)
	{
	}

	public override void Enter(StatuePlacementEditController owner)
	{
	}

	public override void Execute(StatuePlacementEditController owner)
	{
	}

	public override void Exit(StatuePlacementEditController owner)
	{
	}
}
