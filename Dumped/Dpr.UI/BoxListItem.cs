using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxListItem : MonoBehaviour
{
	[SerializeField]
	private Image _bodyImage;

	[SerializeField]
	private Image _bottomImage;

	[SerializeField]
	private Image[] _pokemonChips;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Transform _boxRoot;

	[SerializeField]
	private Color32 _grayColor;

	private bool[] _isHitSearch;

	private bool _isSearchActive;

	public bool IsSelected
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void SetPokemonChips(int index, [Optional] BoxWindow.SEARCH_DATA searchData)
	{
	}

	public void SetWallColor(int tray, Color32 wallColor)
	{
	}

	public bool ToggleSelect()
	{
		return default(bool);
	}
}
