using Dpr.Item;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ShopItemItem : MonoBehaviour, IUIButton
{
	[SerializeField]
	protected Image _icon;

	[SerializeField]
	protected UIText _name;

	[SerializeField]
	protected UIText _price;

	protected ShopBase.ShopType _shopType;

	protected int _index;

	protected ItemInfo _itemInfo;

	protected SealInfo _sealInfo;

	protected UgItemInfo _ugItemInfo;

	public int index => default(int);

	public ItemInfo GetItemInfo()
	{
		return null;
	}

	public SealInfo GetSealInfo()
	{
		return null;
	}

	public UgItemInfo GetUgItemInfo()
	{
		return null;
	}

	public bool IsWazaMachine()
	{
		return default(bool);
	}

	public bool IsBall()
	{
		return default(bool);
	}

	public virtual int GetNumForAdd()
	{
		return default(int);
	}

	public virtual bool GetActive()
	{
		return default(bool);
	}

	public virtual void SetActive(bool isActive)
	{
	}

	public virtual int GetIndex()
	{
		return default(int);
	}

	public virtual void SetIndex(int index)
	{
	}

	public virtual RectTransform GetRectTransform()
	{
		return null;
	}

	public virtual void Select()
	{
	}

	public virtual void UnSelect()
	{
	}
}
