using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIBattleMatchingPokemonSlot : MonoBehaviour
{
	public enum SlotType
	{
		Own,
		OTher,
		Ban
	}

	[SerializeField]
	private Image _imageFrame;

	[SerializeField]
	private Sprite[] _spriteFrames;

	[SerializeField]
	private Image _imageItemFrame;

	[SerializeField]
	private Sprite[] _spriteItemFrames;

	[SerializeField]
	private PokemonIcon _pokemonIcon;

	[SerializeField]
	private UIText _textName;

	[SerializeField]
	private UIText _textLevel;

	[SerializeField]
	private Image _imageGender;

	[SerializeField]
	private Cursor _cursor;

	[SerializeField]
	private GameObject _objBan;

	public void Setup(SlotType type, PokemonParam param)
	{
	}
}
