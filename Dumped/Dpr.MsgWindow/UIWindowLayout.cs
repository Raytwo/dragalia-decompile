using UnityEngine;
using UnityEngine.UI;

namespace Dpr.MsgWindow;

public class UIWindowLayout
{
	private RectTransform msgTextRect;

	private RectTransform frameRect;

	private RectTransform windowRect;

	private Image frameImage;

	private Canvas canvas;

	private Sprite currentWndFrameSpr;

	public int SortingOrder => default(int);

	public void Setup(RectTransform msgTextRect, RectTransform windowRect, Canvas canvas, GameObject frameObj)
	{
	}

	public void SetWindowPos(Vector2 anchorPos)
	{
	}

	public void SetSortingOrder(int sortingOrder)
	{
	}

	public void SetOffsetPosX(float posX)
	{
	}

	public void SetWindowFrameSpr(Sprite newFrameSpr)
	{
	}

	public void SetCurrentSelectWindowSpr()
	{
	}

	public void SetBoardFrameSpr(Sprite newBoardSpr)
	{
	}

	public void SetWindowWidth(float width)
	{
	}
}
