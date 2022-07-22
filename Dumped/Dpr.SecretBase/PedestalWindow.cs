using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.SecretBase;

public class PedestalWindow : SelectWindow<PedestalIcon, Pedestal.SheetInfo>
{
	[SerializeField]
	protected RectTransform rectTransform;

	[SerializeField]
	protected VerticalLayoutGroup layout;

	[SerializeField]
	protected RectTransform itemRect;

	protected float offset;

	private void Start()
	{
	}

	public override bool SelectNext()
	{
		return default(bool);
	}

	public override bool SelectPrev()
	{
		return default(bool);
	}

	public void ScrollCalc(int margin = 0)
	{
	}

	public int GetIndex(int id)
	{
		return default(int);
	}

	public bool HasEnableItem()
	{
		return default(bool);
	}
}
