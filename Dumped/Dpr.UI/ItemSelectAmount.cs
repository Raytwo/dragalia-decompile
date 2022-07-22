using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Dpr.UI;

public class ItemSelectAmount : MonoBehaviour
{
	[SerializeField]
	protected RectTransform upArrowRectTransform;

	[SerializeField]
	protected RectTransform downArrowRectTransform;

	[SerializeField]
	protected TextMeshProUGUI amountValueText;

	[SerializeField]
	protected TextMeshProUGUI descriptionText;

	[SerializeField]
	protected IndexSelector indexSelector;

	public bool IsShow
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public int CurrentAmount => default(int);

	public void Show()
	{
	}

	public void Hide()
	{
	}

	public void Set(int min, int max)
	{
	}

	public void SetDescriptionText(string text)
	{
	}

	public bool ChangeAmount(int value)
	{
		return default(bool);
	}

	public void ResumeChangeAmount()
	{
	}

	protected bool AddAmount(int value)
	{
		return default(bool);
	}

	protected void UpdateAmountValueText()
	{
	}
}
