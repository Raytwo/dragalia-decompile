using TMPro;
using UnityEngine;

namespace Dpr.MsgWindow;

public class MsgTextContainer : MonoBehaviour
{
	[SerializeField]
	private RectTransform contentRect;

	[SerializeField]
	private WindowMsgText[] uiTextArray;

	[SerializeField]
	private WindowMsgText sizeTagText;

	[SerializeField]
	private TMP_FontAsset emptyFont;

	private WaitTimer msgTimer;

	private Vector2 startPosition;

	private float textHight;

	private float scrollTextDuration;

	private float textLinePaddingOffset;

	private int topTextObjIndex;

	private int defaultTextNum;

	public float FontSize => default(float);

	private int LastTextIndex => default(int);

	public void Initialize(float scrollTextDuration, float textLinePaddingOffset)
	{
	}

	public void ResetUIText()
	{
	}

	public void Clear()
	{
	}

	public void ResetTextColor()
	{
	}

	public void OnFinalize()
	{
	}

	public void SetTextEnabled(bool hasSizetag)
	{
	}

	public void SetUseFontAsset(TMP_FontAsset useFontAsset)
	{
	}

	public void ChangeUnknownFont()
	{
	}

	public void SetTextParam(float fontSize, float width)
	{
	}

	public void SetFontSize(float fontSize)
	{
	}

	public void SetTextColor(Color newColor)
	{
	}

	public void SetMessage(int textIndex, string message, bool hasSizetag)
	{
	}

	public void StartMovePositionY()
	{
	}

	public bool MovingPosition(float deltaTime)
	{
		return default(bool);
	}
}
