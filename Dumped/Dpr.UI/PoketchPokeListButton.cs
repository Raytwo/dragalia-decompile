using DG.Tweening;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchPokeListButton : PoketchButton
{
	[SerializeField]
	private PokemonIcon _pokemonIcon;

	[SerializeField]
	private Image _itemIcon;

	[SerializeField]
	private Slider _hpGuage;

	[SerializeField]
	private static Vector3 _vibrationValue;

	[SerializeField]
	private static float _vibrationTime;

	public PokemonParam PokeParam;

	private DG.Tweening.Sequence _sequence;

	public PokemonIcon PokeIcon => null;

	public Slider HpGauge => null;

	public Image MonsIcon => null;

	public Image ItemIcon => null;

	public DG.Tweening.Sequence SetVibration()
	{
		return null;
	}

	public void StopVibration()
	{
	}
}
