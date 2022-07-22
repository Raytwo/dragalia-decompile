using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxListPanel : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private GridLayoutGroup _grid;

	[SerializeField]
	private BoxListNavigate[] _naviSteps;

	[SerializeField]
	private BoxListItem[] _boxes;

	private int _step;

	private float _openPosX;

	private float _closePosX;

	private readonly float[] _boxItemScales;

	public BoxListNavigate CurrentNavigates => null;

	public int SelectedIndex
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public CanvasGroup BoxCcanvasGroup => null;

	public void Initialize(int boxCount, BoxWindow.SEARCH_DATA searchData)
	{
	}

	public void Open([Optional] Action callback)
	{
	}

	public void Close([Optional] Action callback)
	{
	}

	public void SetPanel(bool isEnable, [Optional] Action callback)
	{
	}

	public bool ToggleSelectBox(int index)
	{
		return default(bool);
	}

	public void ApplyBox(int index, [Optional] BoxWindow.SEARCH_DATA searchData)
	{
	}

	public void SetBoxChips(int index, [Optional] BoxWindow.SEARCH_DATA searchData)
	{
	}

	public void SetBoxWallcolor(int index)
	{
	}
}
