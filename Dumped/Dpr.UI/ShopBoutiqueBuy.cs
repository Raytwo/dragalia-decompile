using System.Collections;

namespace Dpr.UI;

public class ShopBoutiqueBuy : ShopBoutique
{
	public override IEnumerator OpOpen()
	{
		return null;
	}

	protected override void SetupScrollViewItemParams()
	{
	}

	protected override void OnCancel()
	{
	}

	protected override void OnDecidedSelectItem()
	{
	}

	private void SequencePurchase(int amount)
	{
	}
}
