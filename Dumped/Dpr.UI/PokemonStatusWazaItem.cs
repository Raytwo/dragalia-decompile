using System;
using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusWazaItem : MonoBehaviour
{
	[Serializable]
	private class Condition
	{
		public RectTransform root;

		public Image plate;

		public UIText name;
	}

	[Serializable]
	private class BodyParam
	{
		public Sprite sprite;

		public Color nameColor;
	}

	[SerializeField]
	private UIText _name;

	[SerializeField]
	private UIText _pp;

	[SerializeField]
	private TypePanel _type;

	[SerializeField]
	private Condition _condition;

	[SerializeField]
	private Image _new;

	[SerializeField]
	private Image _imageBody;

	[SerializeField]
	private BodyParam[] _bodyParams;

	[SerializeField]
	private Color[] _ppColors;

	[SerializeField]
	private Cursor _cursorSwap;

	private int _wazaIndex;

	public int wazaIndex => default(int);

	public void Setup(PokemonParam pokemonParam, int wazaIndex, bool isContest = false)
	{
	}

	private Color GetPpColor(int pp, int ppMax)
	{
		return default(Color);
	}

	public void Setup(WazaNo wazaNo, bool isNew, bool isContest = false)
	{
	}

	public void EnableCondition(bool enabled)
	{
	}

	public void Select(bool enabled)
	{
	}

	public void EnableSwapMode(bool enabled)
	{
	}

	public void SwapWazaIndex(PokemonParam pokemonParam, PokemonStatusWazaItem fromSwapItem)
	{
	}
}
