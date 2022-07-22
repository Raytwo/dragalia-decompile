using DPData.MysteryGift;
using UnityEngine;

namespace Dpr.UI;

public class GiftCompleteWindow : GiftSubWindow
{
	private static readonly Vector2 MsgWindowAnchorPos;

	[SerializeField]
	private GiftContentsPanel contentsPanel;

	protected override void OnInitialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public override void Show()
	{
	}

	public void Setup(RecvData data)
	{
	}

	public void SetInputEnable(bool isEnable)
	{
	}

	public void ShowMessage(string labelName)
	{
	}
}
