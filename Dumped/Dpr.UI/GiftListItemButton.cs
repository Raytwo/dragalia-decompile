using DPData.MysteryGift;
using UnityEngine;

namespace Dpr.UI;

public class GiftListItemButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private UIText activeNameText;

	[SerializeField]
	private UIText disableNameText;

	[SerializeField]
	private GameObject activeObject;

	[SerializeField]
	private GameObject disableObject;

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

	public void Set(RecvData data)
	{
	}
}
