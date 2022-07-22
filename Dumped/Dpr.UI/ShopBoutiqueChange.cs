using System.Collections;
using System.Collections.Generic;

namespace Dpr.UI;

public class ShopBoutiqueChange : ShopBoutique
{
	public enum DressType
	{
		Default = 0,
		Contest = 1,
		Platinum = 3,
		Summer = 8,
		Bicycle = 13
	}

	public override IEnumerator OpOpen()
	{
		return null;
	}

	protected override void SetupScrollViewItemParams()
	{
	}

	public static int SetupBoutiqueItemParams(List<ShopBoutiqueItemItem.Param> itemParams)
	{
		return default(int);
	}

	protected override void OnCancel()
	{
	}

	protected override void OnDecidedSelectItem()
	{
	}
}
