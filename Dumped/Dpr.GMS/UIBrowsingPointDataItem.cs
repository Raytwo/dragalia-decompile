using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIBrowsingPointDataItem : AUIGMSScrollItem
{
	[SerializeField]
	private Image monsIconImage;

	[SerializeField]
	private Image selectBGImage;

	[SerializeField]
	private Image newIconImage;

	[SerializeField]
	private UIText iconTitleText;

	[SerializeField]
	private UIText monsNameText;

	public void ShowPointDataItem(string pointTitle, string monsName, Sprite monsIconSpr, bool isNew)
	{
	}

	public void ShowEmptyPointDataItem(string pointTitle, string nameText)
	{
	}

	private void SetPointTitleStr(string title)
	{
	}

	private void SetNameText(string name)
	{
	}

	private void SetMonsIconSpr(Sprite monsIconSpr)
	{
	}

	private void SetTextColor(Color color)
	{
	}

	private void SetNewImageEnabled(bool enabled)
	{
	}

	protected override void OnSelect()
	{
	}

	protected override void OnUnSelect()
	{
	}
}
