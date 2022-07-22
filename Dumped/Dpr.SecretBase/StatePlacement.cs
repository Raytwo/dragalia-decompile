namespace Dpr.SecretBase;

public class StatePlacement : StateBase<StatuePlacementEditController.State, StatuePlacementEditController>
{
	private int placement_dir;

	private int tmp_placement_dir;

	private int dir_backup;

	private PlacementData placement;

	private bool bIsPrevField;

	public void Enter_Placement(PlacementData statue, bool isField)
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
