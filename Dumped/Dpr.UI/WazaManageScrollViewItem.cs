using Pml;
using Pml.PokePara;
using UnityEngine;

namespace Dpr.UI;

public class WazaManageScrollViewItem : MonoBehaviour, IUIButton
{
	[SerializeField]
	private PokemonStatusWazaItem pokemonStatusWazaItem;

	[SerializeField]
	private RectTransform cursorRectTransform;

	private int index;

	private RectTransform rectTransform;

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool isActive)
	{
	}

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

	public void Select()
	{
	}

	public void UnSelect()
	{
	}

	public void Setup(PokemonParam pokemonParam, int wazaIndex, bool isContest = false)
	{
	}

	public void Setup(WazaNo wazaNo, bool isNew, bool isContest = false)
	{
	}

	public RectTransform GetCursorTransform()
	{
		return null;
	}
}
