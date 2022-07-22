using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusTab : MonoBehaviour
{
	[SerializeField]
	private string _messageLabelTitle;

	[SerializeField]
	private PokemonStatusPanel _panel;

	[SerializeField]
	private GameObject _active;

	[SerializeField]
	private GameObject _disable;

	[SerializeField]
	private Image _imageBg;

	[SerializeField]
	private Image _imageIcon;

	private int _index;

	private Color _color;

	private Color[] _colors;

	public Color bgColor => default(Color);

	public PokemonStatusPanel panel => null;

	public string messageLabelTitle => null;

	public void Awake()
	{
	}

	public void Setup(int index, bool isActive, PokemonParam pokemonParam, Canvas canvas)
	{
	}

	public void Select(bool enabled)
	{
	}

	public void SetEnable(bool enabled)
	{
	}
}
