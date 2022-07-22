using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppKichenTimer : PoketchAppBase
{
	private enum TimerState
	{
		Idle,
		Stop,
		CountDown,
		Finished,
		End
	}

	private enum TimerButtonType
	{
		Start,
		Stop,
		Reset,
		Seconds01_Up,
		Seconds01_Down,
		Seconds10_Up,
		Seconds10_Down,
		Minutes01_Up,
		Minutes01_Down,
		Minutes10_Up,
		Minutes10_Down,
		End
	}

	private enum TimerBgState
	{
		Idle,
		Finished01,
		Finished02,
		CountDown
	}

	[SerializeField]
	private float _bgAniamationTime;

	[SerializeField]
	private float _buttonBlinkTime;

	[SerializeField]
	private Image _secondsImage01;

	[SerializeField]
	private Image _secondsImage10;

	[SerializeField]
	private Image _minutesImage01;

	[SerializeField]
	private Image _minutesImage10;

	[SerializeField]
	private Sprite[] _numberSprites;

	[SerializeField]
	private Image _bgImage01;

	[SerializeField]
	private Image _bgImage02;

	[SerializeField]
	private Image _bgImage03;

	[SerializeField]
	private Sprite[] _bgSprites01;

	[SerializeField]
	private Sprite[] _bgSprites02;

	[SerializeField]
	private Sprite[] _bgSprites03;

	private TimerState _state;

	private float _timer;

	private int _displayMinutes;

	private int _displaySeconds;

	private TimerBgState _bgState;

	private float _bgAnimationTimeCount;

	private bool _isButtonVisible;

	private const float PRESSED_OFFSET_Y = -10f;

	private float _buttonBlinkTimeCount;

	private Vector3 _defaultStartButtonPosition;

	private Vector3 _defaultStopButtonPosition;

	private Vector3 _pressedStartButtonPosition;

	private Vector3 _pressedStopButtonPosition;

	protected override void OnInitialize()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose()
	{
	}

	public override void OnSizeChanged(bool isLarge)
	{
	}

	public override void OnAppChanged()
	{
	}

	protected override void OnUpdateDraw()
	{
	}

	protected override void OnUpdateControl(bool isAppControlEnable = false, [Optional] PoketchButton targetButton, PoketchWindow.TouchState state = PoketchWindow.TouchState.None)
	{
	}

	private void StartTimer()
	{
	}

	private void StopTimer()
	{
	}

	private void ResetTimer(bool isPlaySE = true)
	{
	}

	private void OnCountFinished()
	{
	}

	private void SetTimer(int minutes, int seconds)
	{
	}

	private void AddTimerSeconds01(int addSeconds01)
	{
	}

	private void AddTimerSeconds10(int addSeconds10)
	{
	}

	private void AddTimerMinutes01(int addMinutes01)
	{
	}

	private void AddTimerMinutes10(int addMinutes10)
	{
	}

	private void SetTimerDisplay(float seconds)
	{
	}

	private void SetTimerDisplay(int minutes, int seconds)
	{
	}

	private void SetBgSprites(TimerBgState state)
	{
	}

	private void SetButtonsVisible(bool visible)
	{
	}
}
