using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealTemplateItemButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private Image sealIconImage;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private UIText countText;

	private int index;

	private RectTransform rectTransform;

	public int GetIndex()
	{
		return default(int);
	}

	public void SetIndex(int index)
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool isActive)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void Set(int sealId, int count)
	{
	}
}
