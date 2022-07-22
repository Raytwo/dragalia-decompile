using System;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class ShopBoutiqueItemItem : ShopItemItem
{
	[Serializable]
	private class Purchased
	{
		public RectTransform root;
	}

	public class Param
	{
		public ShopTable.SheetBoutiqueShop data;

		public CharacterDressData.SheetData dressData;
	}

	[SerializeField]
	private Image _waredIcon;

	[SerializeField]
	private Purchased _purchased;

	[SerializeField]
	private Color[] _colors;

	private Param _param;

	private CharacterDressData.SheetData _characterDressData;

	private ShopBoutique.BoutiqueType _boutiqueType;

	public Param param => null;

	public CharacterDressData.SheetData characterDressData => null;

	public void Setup(ShopBoutique.BoutiqueType boutiqueType, Param param)
	{
	}

	private void SetupNameColor()
	{
	}

	private bool IsWaredDress()
	{
		return default(bool);
	}

	public void SetupWared()
	{
	}

	private bool IsShowPurchased()
	{
		return default(bool);
	}

	private void SetupPurchased()
	{
	}

	public override int GetNumForAdd()
	{
		return default(int);
	}

	public void AddItem(int amount)
	{
	}
}
