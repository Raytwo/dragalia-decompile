using System.Collections.Generic;
using DPData.MysteryGift;
using UnityEngine;

namespace Dpr.UI;

public class GiftHistoryWindow : GiftSubWindow
{
	[SerializeField]
	private UIScrollView scrollView;

	[SerializeField]
	private GiftContentsPanel contentsPanel;

	[SerializeField]
	private Cursor cursor;

	private List<RecvData> recvDataList;

	protected override void OnInitialize()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public override void Show()
	{
	}

	public void Setup(RecvData[] recvDatas)
	{
	}

	private void OnRequiredItemData(IUIButton button)
	{
	}

	private void OnSelectItemScrollViewItem(IUIButton button)
	{
	}

	private void OnUnSelectItemScrollViewItem(IUIButton button)
	{
	}
}
