namespace Dpr.SecretBase;

public class StateField : StateBase<StatuePlacementEditController.State, StatuePlacementEditController>
{
	private PlacementData prev;

	public override void Enter(StatuePlacementEditController owner)
	{
	}

	public override void Execute(StatuePlacementEditController owner)
	{
	}

	public override void Exit(StatuePlacementEditController owner)
	{
	}

	private void UpdateCursor(StatuePlacementEditController owner)
	{
	}

	private bool IsEnableInput()
	{
		return default(bool);
	}
}
