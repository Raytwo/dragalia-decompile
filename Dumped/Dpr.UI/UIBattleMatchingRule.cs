using System.Collections.Generic;
using Dpr.BattleMatching;
using Dpr.Message;
using UnityEngine;

namespace Dpr.UI;

public class UIBattleMatchingRule : MonoBehaviour
{
	[SerializeField]
	private UIText _textTitle;

	[SerializeField]
	private WindowItemSelector[] _categories;

	[SerializeField]
	private WindowItemButton _decide;

	[SerializeField]
	private RectTransform _cursor;

	[SerializeField]
	private Cursor _cursorFrame;

	[SerializeField]
	private GameObject _cursorArrows;

	private MessageMsgFile _msgFile;

	private int _currentIndex;

	private List<int> _currentIndexList;

	private Dictionary<PokemonNum, string> _pokemonNumList;

	private Dictionary<Regulation.LevelRangeType, string> _pokemonLevelList;

	private List<string> _legendPokemonList;

	private List<string> _samePokemonList;

	private List<string> _sameItemList;

	public void OpenRuleWindow()
	{
	}

	public void CloseRuleWindow()
	{
	}

	public void OpenSelectRuleWindow()
	{
	}

	public void OnMoveX(bool left)
	{
	}

	public void OnMoveY(bool up)
	{
	}

	public bool OnDecide()
	{
		return default(bool);
	}

	private void SetTitle(bool select = false)
	{
	}

	private void SetDecide(bool select = false)
	{
	}

	private string GetNameStr(int no)
	{
		return null;
	}

	private string GetFormattedStr(int no)
	{
		return null;
	}

	private string GetNumStr(PokemonNum num)
	{
		return null;
	}

	private void SetCursorAnchor(RectTransform rectTr)
	{
	}
}
