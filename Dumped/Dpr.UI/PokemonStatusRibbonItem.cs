using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusRibbonItem : MonoBehaviour, IUIButton
{
	public class Param
	{
		public int ribbonNo;
	}

	[SerializeField]
	private Image _image;

	private int _index;

	private Param _param;

	public Param param => null;

	public int index => default(int);

	public void Setup(Param param, PokemonParam pokemonParam)
	{
	}

	bool IUIButton.GetActive()
	{
		return default(bool);
	}

	void IUIButton.SetActive(bool isActive)
	{
	}

	int IUIButton.GetIndex()
	{
		return default(int);
	}

	void IUIButton.SetIndex(int index)
	{
	}

	RectTransform IUIButton.GetRectTransform()
	{
		return null;
	}

	void IUIButton.Select()
	{
	}

	void IUIButton.UnSelect()
	{
	}
}
