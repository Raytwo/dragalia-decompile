using TMPro;
using UnityEngine;

namespace Dpr.MsgWindow;

public class WindowMsgText : MonoBehaviour
{
	private TextMeshProUGUI text;

	private RectTransform textRect;

	private Color defaultColor;

	public float TextHeight => default(float);

	public float FontSize => default(float);

	public void Initialize()
	{
	}

	public void ResetText()
	{
	}

	public void ResetColor()
	{
	}

	public void SetPositionYByIndex(int index, float lineSpace)
	{
	}

	public void SetTextEnable(bool enabled)
	{
	}

	public void SetTextWidth(float width)
	{
	}

	public void SetFontSize(float fontSize)
	{
	}

	public void SetFontAsset(TMP_FontAsset newFontAsset, VerticalAlignmentOptions vAlignment)
	{
	}

	public void SetText(string messageStr)
	{
	}

	public void SetTextColor(Color textColor)
	{
	}

	public void CreateStrFontTexture(string messageStr)
	{
	}
}
