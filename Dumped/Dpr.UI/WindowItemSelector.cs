using UnityEngine;

namespace Dpr.UI;

public class WindowItemSelector : AWindowItem
{
	private UIInputController inputController;

	[SerializeField]
	private UIText titleText;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private bool isLoop;

	private string[] textArray;

	public override bool IsShowArrowIcon => default(bool);

	public override ItemType ItemType => default(ItemType);

	public void SetNameArray(string[] strArray)
	{
	}

	public void SetText(string text)
	{
	}

	public void SetTitleText(string msbt, string label)
	{
	}

	public void SetTitleText(string text)
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}

	public void DecIndex()
	{
	}

	public void AddIndex()
	{
	}

	private void UpdateText()
	{
	}
}
