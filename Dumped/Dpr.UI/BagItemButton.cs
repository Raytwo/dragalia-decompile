using Dpr.Item;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BagItemButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private Image iconImage;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private Image newIconImage;

	[SerializeField]
	private Image favoriteIconImage;

	[SerializeField]
	private UIText stockCountLabelText;

	[SerializeField]
	private UIText stockCountValueText;

	[SerializeField]
	private Image registerButtonImage;

	[SerializeField]
	private Sprite[] shortcutButonSprites;

	private int index;

	private RectTransform rectTransform;

	private ItemInfo item;

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

	public void SetInfo(ItemInfo item)
	{
	}

	public ItemInfo GetInfo()
	{
		return null;
	}

	public void SwitchFavorite()
	{
	}

	public void RemoveNew()
	{
	}

	private void UpdateNew()
	{
	}

	private void UpdateFavorite()
	{
	}

	private void UpdateRegisterButton()
	{
	}

	public void UpdateStockCount()
	{
	}

	public void SetTextColor(Color color)
	{
	}

	public void SetIconColor(Color color)
	{
	}
}
