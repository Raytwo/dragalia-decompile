using System.Collections.Generic;
using Dpr.Message;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxStatusPanel : MonoBehaviour
{
	private enum StatusType
	{
		Hp,
		Attack,
		Defence,
		SpAttack,
		SpDefence,
		Speed,
		Personality,
		Tokusei,
		Item,
		JudgeHP,
		JudgeAttack,
		JudgeDefence,
		JudgeSpAttack,
		JudgeSpDefence,
		JudgeSpeed,
		Num
	}

	[SerializeField]
	private Image _ballImage;

	[SerializeField]
	private UIText _nickNameText;

	[SerializeField]
	private Image _sexImage;

	[SerializeField]
	private UIText _levelText;

	[SerializeField]
	private GameObject _statusFrame;

	[SerializeField]
	private GameObject _judgeFrame;

	[SerializeField]
	private UIText _noText;

	[SerializeField]
	private UIText _nameText;

	[SerializeField]
	private Image _langIcon;

	[SerializeField]
	private TypePanel[] _types;

	[SerializeField]
	private Image _pokerusImage;

	[SerializeField]
	private Image _RereImage;

	[SerializeField]
	private PokemonSick _condition;

	[SerializeField]
	private Sprite[] _pokerusSprites;

	[SerializeField]
	private UIText[] _statusValues;

	[SerializeField]
	private GameObject _wazaFrame;

	[SerializeField]
	private UIText _judgeTotalText;

	[SerializeField]
	private Image[] _wazaBgs;

	[SerializeField]
	private UIText[] _wazaTexts;

	[SerializeField]
	private Sprite[] _wazaTypeSprites;

	[SerializeField]
	private Image[] _markImages;

	private Color32[] _markColorSet;

	private float _openPosX;

	private float _closePosX;

	private const string _msgCodeBaseString = "SS_box_";

	private const int _msgItemNo = 30;

	private const int _msgJudgeTotalBaseNo = 228;

	private const int _msgJudgeBaseNo = 232;

	private const int _msgTraningedNo = 577;

	private const string langIconSoriteNameBase = "cmn_ico_txt_lang_{0}_00";

	private static Dictionary<MessageEnumData.MsgLangId, string> LangageIconSpriteNames;

	public void Initialize()
	{
	}

	public void Open(BoxWindow.StatusType mode, PokemonParam pokemonParam)
	{
	}

	public void Close()
	{
	}

	public bool SetUp(BoxWindow.StatusType mode, PokemonParam pokemonParam)
	{
		return default(bool);
	}

	public void SetMarks(PokemonParam pokemonParam)
	{
	}

	private void OpenProc()
	{
	}

	private string GetJudgeTextCode(PokemonParam pokemonParam, PowerID powerId)
	{
		return null;
	}
}
