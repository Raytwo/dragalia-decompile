using System.Runtime.InteropServices;
using Dpr.Message;
using TMPro;
using UnityEngine;

public class DisplayMessage : MonoBehaviour
{
	[SerializeField]
	private int materialIndex;

	private readonly string DEFAULT_USE_MSBT_NAME;

	private TextMeshProUGUI messageText;

	private MessageMsgFile useMsgFile;

	private RectTransform messageRect;

	private GameObject noiseImage;

	private int useLabelHash;

	private bool isRedGyarados;

	private float blinkCycle;

	private float blinkWidth;

	private Color fromColor;

	private Color toColor;

	public void Initialize()
	{
	}

	private void InitTextSetting()
	{
	}

	private void OnDestroy()
	{
	}

	private void SetMessageEnabled(bool enabled)
	{
	}

	private void ChangeUseMsgFile(string newMsbtName)
	{
	}

	private bool IsUseSameMsbt(string newMsbtName)
	{
		return default(bool);
	}

	public void ShowMessage(string labelName, string msbtName = "", bool bIsUseTag = false)
	{
	}

	public void ChangeMessage(string message)
	{
	}

	public void HideMessage()
	{
	}

	private void InitializeFont([Optional] MessageTextParseDataModel textDataModel)
	{
	}

	private void SetMessageWidth(float width)
	{
	}

	private void SetFontSize(float fontSize)
	{
	}

	private void SetFontAutoSize(bool auto)
	{
	}

	private void SetFontColor(Color color)
	{
	}

	private void SetFontBold(bool bold)
	{
	}

	private void SetFontLineSpace(float space)
	{
	}

	private void SetFontSoftness(float softness)
	{
	}

	private void SetFontDilate(float dilate)
	{
	}

	public void RedGyaradosMessage(bool flag)
	{
	}

	private void Update()
	{
	}
}
