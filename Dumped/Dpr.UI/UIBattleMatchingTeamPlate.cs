using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBattleMatchingTeamPlate : MonoBehaviour
{
	[SerializeField]
	private Image _imageFrame;

	[SerializeField]
	private Sprite[] _spriteFrames;

	[SerializeField]
	private UIText _textTitle;

	[SerializeField]
	private GameObject _objWarning;

	[SerializeField]
	private GameObject _objTeam;

	[SerializeField]
	private UIBattleMatchingPokemonSlot[] _pokemonSlots;

	private static string[] _titleLabels;

	public void Setup(PokemonParam[] pokemonParams, bool[] regurations, UIBattleMatchingPokemonSlot.SlotType type = UIBattleMatchingPokemonSlot.SlotType.Own)
	{
	}

	public void SetTitleOwn(int index)
	{
	}

	public void SetTitle(string msbt, string label)
	{
	}

	public void SetTitle(string title)
	{
	}

	public void SetActiveFrame(bool active)
	{
	}
}
