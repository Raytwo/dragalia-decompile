using SmartPoint.Components;
using TMPro;
using UnityEngine;

public class LayoutLogObserver : LayoutCellObserver
{
	public LayoutScrollView.Cell _cell;

	public TextMeshProUGUI _contentText;

	public override Vector2 sizeDelta => default(Vector2);

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
