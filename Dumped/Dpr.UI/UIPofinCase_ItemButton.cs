using System.Runtime.CompilerServices;
using DPData;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIPofinCase_ItemButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private UIText levelText;

	[SerializeField]
	private Image newImage;

	private int index;

	public PoffinData Data
	{
		[CompilerGenerated]
		get
		{
			return default(PoffinData);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int GetIndex()
	{
		return default(int);
	}

	public void SetIndex(int index)
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool isActive)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void Setup(PoffinData data, string poffinName)
	{
	}

	public void SetNewIconEnable(bool isEnable)
	{
	}
}
