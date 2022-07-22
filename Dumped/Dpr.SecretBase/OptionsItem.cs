using UnityEngine;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class OptionsItem : SelectItemBase<string>
{
	[SerializeField]
	private Text text;

	[SerializeField]
	private GameObject disable;

	public override void SetData(string value)
	{
	}

	public void SetDisable(bool isDisable)
	{
	}
}
