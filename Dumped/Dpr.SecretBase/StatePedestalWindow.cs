using DG.Tweening;
using UnityEngine;
using XLSXContent;

namespace Dpr.SecretBase;

public class StatePedestalWindow : StateBase<StatuePlacementEditController.State, StatuePlacementEditController>
{
	private PlacementData placement;

	private Pedestal.SheetInfo prevPedestal;

	private bool hasEnableItem;

	private bool isPedestalInstalled;

	private Tweener windowAnimationhandler;

	private Vector3 baseWindowPos;

	public void Enter_PedestalWindow(PlacementData placement)
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

	private void UpdateModelView(StatuePlacementEditController owner)
	{
	}

	private void SetLayerRecursively(GameObject gameObject, int layer)
	{
	}
}
