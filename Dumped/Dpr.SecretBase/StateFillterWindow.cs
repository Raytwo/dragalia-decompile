namespace Dpr.SecretBase;

public class StateFillterWindow : StateBase<StatuePlacementEditController.State, StatuePlacementEditController>
{
	public enum State
	{
		FillterSelect,
		PokeType1,
		PokeType2,
		Size,
		Category,
		Legend
	}

	private string prevFooter;

	public StatuePlacementEditController Owner;

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
