using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBattleMatchingPokemonItem : MonoBehaviour
{
	[SerializeField]
	private GameObject _objNo;

	[SerializeField]
	private UIText _textNo;

	[SerializeField]
	private GameObject _objItem;

	[SerializeField]
	private UIText _textItem;

	[SerializeField]
	private Image _imageItem;

	private readonly string NO_MSBT;

	private readonly string[] NO_LABELS;

	public void Setup(PokemonParam param)
	{
	}

	public void SetEnableNumber(int index)
	{
	}

	public void SetDisableNumber()
	{
	}
}
