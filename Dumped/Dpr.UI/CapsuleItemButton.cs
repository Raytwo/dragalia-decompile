using UnityEngine;

namespace Dpr.UI;

public class CapsuleItemButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private PokemonIcon pokemonIcon;

	[SerializeField]
	private GameObject swapSelectedObject;

	[SerializeField]
	private GameObject contextOpenObject;

	[SerializeField]
	private GameObject onSealObject;

	[SerializeField]
	private GameObject onNotSelectableObject;

	private int index;

	private RectTransform rectTransform;

	private CapsuleInfo info;

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

	public void SetInfo(CapsuleInfo info)
	{
	}

	public CapsuleInfo GetInfo()
	{
		return null;
	}

	public void OnSwapStart()
	{
	}

	public void OnSwapEnd()
	{
	}

	public void OnNotSelectable()
	{
	}

	public void OnContextMenuOpen()
	{
	}

	public void OnContextMenuClose()
	{
	}
}
