using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppHiden : PoketchAppBase
{
	[SerializeField]
	private Image _titleImage;

	[SerializeField]
	private Image[] _wazaNameImage;

	[SerializeField]
	private Transform[] _cursorRoots;

	[SerializeField]
	private GameObject _cursor;

	private int _currentIndex;

	private int _preIndex;

	private static readonly (FieldPoketch.HidenWazaType, int)[] _hidenTypes;

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

	private int MoveHorizontal(int index)
	{
		return default(int);
	}

	private int MoveUp(int index)
	{
		return default(int);
	}

	private int MoveDown(int index)
	{
		return default(int);
	}

	private void SetCursor(int index)
	{
	}

	private void CheckOpenHiden()
	{
	}
}
