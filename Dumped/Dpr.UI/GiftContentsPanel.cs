using DPData.MysteryGift;
using UnityEngine;

namespace Dpr.UI;

public class GiftContentsPanel : MonoBehaviour
{
	private const int TextLineMargin = 26;

	private const string MessageFileName = "ss_net_mystery";

	private static readonly string[] ItemLabelNames;

	private static readonly string[] DressUpLabelNames;

	private static readonly string[] UnderGroundItemLabelNames;

	[SerializeField]
	private UIText titleText;

	[SerializeField]
	private UIText receiveDateText;

	[SerializeField]
	private UIText contentsText;

	public void Setup(RecvData data)
	{
	}

	private void SetupContentTextLineSpacing()
	{
	}

	private void SetReceiveDateText(long timestamp)
	{
	}

	private void SetContentsText(RecvData data)
	{
	}
}
