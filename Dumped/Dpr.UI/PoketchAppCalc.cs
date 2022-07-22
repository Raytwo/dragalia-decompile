using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppCalc : PoketchAppBase
{
	private enum CalcCode
	{
		Num_0,
		Num_1,
		Num_2,
		Num_3,
		Num_4,
		Num_5,
		Num_6,
		Num_7,
		Num_8,
		Num_9,
		Num_Point,
		Act_Plus,
		Act_Minus,
		Act_Mul,
		Act_Div,
		Act_Equrl,
		Act_Clear,
		Symbol_Asterisk,
		Symbol_Question,
		CalcCode_Null
	}

	private const int _maxDigit = 10;

	private const string _defaultDisp = "0";

	private static readonly (float, float) _cursorOffset;

	[SerializeField]
	private Sprite[] _numSprite;

	[SerializeField]
	private Image[] _numImage;

	[SerializeField]
	private Image _symbol;

	[SerializeField]
	private Image _cursor;

	private string _dispNumString;

	private decimal _currentNum;

	private decimal _targetNum;

	private CalcCode _calcCode;

	private CalcCode _preCalcCode;

	private CalcCode _lastInputCode;

	private bool _isError;

	private bool _isVoisePlayed;

	private int _cursorX;

	private int _cursorY;

	private int _currentIndex;

	private static readonly CalcCode[,] _buttonMap;

	private static readonly int _btmMapWidth;

	private static readonly int _btnMapHeight;

	protected override void OnInitialize()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	protected override void OnUpdateDraw()
	{
	}

	protected override void OnUpdateControl(bool isAppControlEnable = false, [Optional] PoketchButton targetButton, PoketchWindow.TouchState state = PoketchWindow.TouchState.None)
	{
	}

	private void InputClear()
	{
	}

	private void InputNumeric(int num)
	{
	}

	private void InputDigitPoint()
	{
	}

	private void InputAction(CalcCode action)
	{
	}

	private void InputEqual()
	{
	}

	private void ExecuteCalc(decimal num, CalcCode code)
	{
	}

	private bool UpdateNumberImage()
	{
		return default(bool);
	}

	private void ClearNumDisp()
	{
	}

	private void SetErrorDisp()
	{
	}

	private void ResetNumber()
	{
	}

	private void UpdateSymbolImage()
	{
	}

	private void PlayPokemonVoice(decimal number)
	{
	}
}
