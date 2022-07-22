using System.Runtime.InteropServices;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIInputButton
{
	public enum State
	{
		LongPressed,
		Clicked
	}

	private UnityAction<int, State> _onCallbacked;

	private UIInputController _input;

	private float _longPressTime;

	private int _button;

	private float _pressTime;

	public UIInputButton()
	{
	}

	public UIInputButton(int button, UnityAction<int, State> onCallbacked, [Optional] UIInputController input, bool isAutoUpdate = true, float longPressTime = 0.5f)
	{
	}

	public void Setup(int button, UnityAction<int, State> onCallbacked, [Optional] UIInputController input, bool isAutoUpdate = true, float longPressTime = 0.5f)
	{
	}

	public void OnUpdate(float deltaTime)
	{
	}
}
