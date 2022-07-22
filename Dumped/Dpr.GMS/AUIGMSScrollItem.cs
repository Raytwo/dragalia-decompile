using Dpr.UI;
using UnityEngine;

namespace Dpr.GMS;

public abstract class AUIGMSScrollItem : MonoBehaviour, IUIButton
{
	protected RectTransform rectTransform;

	protected int currentIndex;

	public bool GetActive()
	{
		return default(bool);
	}

	public int GetIndex()
	{
		return default(int);
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public void SetActive(bool isActive)
	{
	}

	public void SetIndex(int index)
	{
	}

	public void Select()
	{
	}

	protected abstract void OnSelect();

	public void UnSelect()
	{
	}

	protected abstract void OnUnSelect();
}
