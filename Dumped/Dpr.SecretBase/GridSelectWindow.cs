using UnityEngine;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class GridSelectWindow<T, Data> : SelectWindow<T, Data> where T : SelectItemBase<Data>
{
	[SerializeField]
	protected RectTransform rectTransform;

	[SerializeField]
	protected GridLayoutGroup grid;

	protected float offset;

	[SerializeField]
	protected float scrollSpeed;

	protected Vector3 dest;

	protected MoveState moveStateHorizontal;

	protected MoveState moveStateVertical;

	private void Update()
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

	public bool SelectNextRow()
	{
		return default(bool);
	}

	public bool SelectPrevRow()
	{
		return default(bool);
	}

	public void ReleaseInput()
	{
	}

	protected void ScrollToRow(int row)
	{
	}

	protected void ScrollCalc()
	{
	}

	public bool IsNextNewLine()
	{
		return default(bool);
	}

	public bool IsPrevNewLine()
	{
		return default(bool);
	}

	public float GetCursorRatio()
	{
		return default(float);
	}
}
