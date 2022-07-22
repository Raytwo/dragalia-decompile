using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class StatueItem : SelectItemBase<StatueEffectData>
{
	[SerializeField]
	private Image icon;

	[SerializeField]
	private Image placementSize;

	[SerializeField]
	private Image pokeTypeIcon1;

	[SerializeField]
	private Image pokeTypeIcon2;

	[SerializeField]
	private UIText num;

	[SerializeField]
	private GameObject disable;

	[SerializeField]
	private StatueSelectWindow selectWindow;

	[SerializeField]
	private Image rareIcon;

	[SerializeField]
	private Image legendIcon;

	private bool isLoading;

	private bool isDisable;

	private bool isFilterd;

	public int Filter(int type1, int type2, int size, int category)
	{
		return default(int);
	}

	public override void SetData(StatueEffectData statueData)
	{
	}

	public void UpdateData()
	{
	}

	public void SetDisable(bool isDisable)
	{
	}

	public void SetDisableForce(bool isDisable)
	{
	}

	public bool IsDisable()
	{
		return default(bool);
	}
}
