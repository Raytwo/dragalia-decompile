using Dpr.Item;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BagUGItemButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private Image newIconImage;

	[SerializeField]
	private UIText stockCountValueText;

	private int index;

	private RectTransform rectTransform;

	private UgItemInfo item;

	public bool IsNull => default(bool);

	public bool IsNew => default(bool);

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

	public void Clear()
	{
	}

	public void SetInfo(UgItemInfo item)
	{
	}

	public UgItemInfo GetInfo()
	{
		return null;
	}

	public void RemoveNew()
	{
	}

	private void UpdateNew()
	{
	}

	public void UpdateStockCount()
	{
	}
}
