using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIPokeStatusSelectPanel : MonoBehaviour
{
	[SerializeField]
	private UIText _name;

	[SerializeField]
	private UIText _level;

	[SerializeField]
	private Image _imageMonsterBall;

	[SerializeField]
	private Image _sex;

	[SerializeField]
	private Image _language;

	[SerializeField]
	private GameObject _selectArrowRoot;

	[SerializeField]
	private GameObject _infoStatusRoot;

	[SerializeField]
	private Image[] _arrows;

	[SerializeField]
	private PokemonSick _sick;

	public void Setup(PokemonParam pokemonParam)
	{
	}

	private void SetInfoStatusRootActive(bool active)
	{
	}

	public void SetArrowAcitve(bool active)
	{
	}

	public void PlayAnimArrow(int move)
	{
	}
}
