using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class PoketchAppCalender : PoketchAppBase
{
	[SerializeField]
	private Image _monthImage01;

	[SerializeField]
	private Image _monthImage10;

	[SerializeField]
	private Sprite[] _numberSprites;

	private int _minDayIndex;

	private int _maxDayIndex;

	private int _currentMonth;

	private List<int> _selectDaysList;

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

	private void LoadSelectDays()
	{
	}

	private void SaveSelectDays()
	{
	}

	private void SettingLayout()
	{
	}

	private void SelectDay(int index)
	{
	}
}
