using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.SecretBase;

public class PedestalIcon : SelectItemBase<Pedestal.SheetInfo>
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private UIText text;

	[SerializeField]
	private GameObject xText;

	[SerializeField]
	private UIText numText;

	[SerializeField]
	private GameObject disable;

	public override void SetData(Pedestal.SheetInfo value)
	{
	}

	public void SetDisable(bool isDisable)
	{
	}

	public bool IsDisable()
	{
		return default(bool);
	}
}
