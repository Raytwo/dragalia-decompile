using UnityEngine;

namespace Dpr.UI;

public class WindowItemButton : AWindowItem
{
	[SerializeField]
	private UIText buttonNameText;

	private UIInputController inputController;

	public override bool IsShowArrowIcon => default(bool);

	public override ItemType ItemType => default(ItemType);

	public void SetButtonText(string text)
	{
	}

	public override bool OnUpdate(float deltaTime)
	{
		return default(bool);
	}
}
