using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class GiftDownloadWindow : GiftSubWindow
{
	[SerializeField]
	private Slider progressBar;

	protected override void OnInitialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public override void Show()
	{
	}

	public void Setup(int min, int max)
	{
	}

	public void Step(int add)
	{
	}

	public void SetProgressValue(int value)
	{
	}
}
