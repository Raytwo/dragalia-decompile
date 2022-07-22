using Dpr.UI;

namespace Dpr.UnderGround.UgFather;

public class UgFatherHealing : UgFatherBase
{
	private enum State
	{
		None,
		ChoicesMessage,
		BeginMessage,
		BeginMessageWait,
		HealingFadOut,
		HealingWait,
		HealingFadIn,
		EndMessage,
		EndMessageWait
	}

	private float waitTime;

	private const float HealingWaitTime = 1f;

	private ContextMenuItem selectedItem;

	private State state;

	private ContextMenuID[] contextMenuIds;

	public override void OnTalkEvent()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	private void ShowPcContextMenu()
	{
	}

	private void ChangeState(State state)
	{
	}

	private void EventEnd()
	{
	}
}
