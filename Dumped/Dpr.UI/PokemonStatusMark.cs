using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PokemonStatusMark : MonoBehaviour
{
	[SerializeField]
	private Image _image;

	private BoxMarkColor _type;

	public BoxMarkColor type => default(BoxMarkColor);

	public void Setup(BoxMarkColor type)
	{
	}

	public void SetType(BoxMarkColor type)
	{
	}
}
