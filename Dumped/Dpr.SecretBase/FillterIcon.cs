using UnityEngine;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class FillterIcon : SelectItemBase<string>
{
	[SerializeField]
	private Text label;

	[SerializeField]
	private Text value;

	private int index;

	public override void SetData(string value)
	{
	}

	public void SetValueText(string value, int index)
	{
	}

	public int GetIndex()
	{
		return default(int);
	}
}
