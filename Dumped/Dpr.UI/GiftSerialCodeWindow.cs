using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class GiftSerialCodeWindow : GiftSubWindow
{
	private const int CodeMinLength = 5;

	private const int CodeMaxLength = 16;

	private const int SplitCodeLength = 4;

	[SerializeField]
	private UIText[] codeTexts;

	private bool isShowSoftwareKeyboard;

	public string InputSerialCode
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	protected override void OnInitialize()
	{
	}

	public override void Show()
	{
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public void ClearTexts()
	{
	}

	private (bool, string) OnInputCheck(string resultText, SoftwareKeyboard.ErrorState errorState)
	{
		return default((bool, string));
	}

	private void SetSerialCodeText(string text)
	{
	}

	private void ShowSoftwareKeyboard()
	{
	}
}
