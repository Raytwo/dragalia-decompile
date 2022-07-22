using SmartPoint.Components;
using TMPro;

public class LayoutWatchObserver : LayoutCellObserver
{
	public LayoutScrollView.Cell _cell;

	public TextMeshProUGUI _contentText;

	public override void OnUpdate(float deltaTime)
	{
	}

	public void OnClick()
	{
	}

	public override bool IsReady()
	{
		return default(bool);
	}

	public override bool OnRebuildLayout()
	{
		return default(bool);
	}

	public override void OnClose()
	{
	}
}
