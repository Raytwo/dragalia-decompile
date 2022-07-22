using Pml;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonIcon : MonoBehaviour
{
	[SerializeField]
	private Image _imageMonsIcon;

	[SerializeField]
	private Image _imageItemIcon;

	[SerializeField]
	private Image _imageBallDecoIcon;

	public Image monsIcon => null;

	public Image itemIcon => null;

	public Image ballDecoIcon => null;

	public void Load(PokemonParam pokemonParam)
	{
	}

	public void Load(PokemonParam pokemonParam, ItemNo itemNo)
	{
	}

	public void Copy(PokemonIcon src)
	{
	}

	public void SwapItemIcon(PokemonIcon from)
	{
	}
}
