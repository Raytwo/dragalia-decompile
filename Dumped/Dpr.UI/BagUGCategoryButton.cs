using Dpr.Item;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BagUGCategoryButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private Image newIconImage;

	[SerializeField]
	private GameObject unselectObject;

	[SerializeField]
	private GameObject selectObject;

	[SerializeField]
	private UgItemInfo.CategoryType categoryType;

	private int index;

	private RectTransform rectTransform;

	public UgItemInfo.CategoryType CategoryType => default(UgItemInfo.CategoryType);

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

	public void SetNewIconEnable(bool isEnable)
	{
	}
}
