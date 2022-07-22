using Dpr.Message;
using Pml.UgFather;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SellUgItemPanel : MonoBehaviour
{
	[SerializeField]
	private Image itemIconImage;

	[SerializeField]
	private UIText itemNameText;

	[SerializeField]
	private UIText tradeInfoText;

	[SerializeField]
	private UIText haveCountText;

	private MessageMsgFile msgFile;

	public void Initialize()
	{
	}

	public void ShowSellItemPanel(UgFatherDataManager.SellItemData data)
	{
	}

	public void HideSellItemPanel()
	{
	}

	private void SetPanelActive(bool active)
	{
	}
}
