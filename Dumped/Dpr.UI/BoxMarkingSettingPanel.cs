using System;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxMarkingSettingPanel : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Image[] _markImages;

	[SerializeField]
	private Cursor _cursor;

	private int _markIndex;

	private PokemonParam _pokemonParam;

	private BoxMarkColor[] _markColors;

	private int _trayIndex;

	private int _posIndex;

	private Action<PokemonParam, int, int> _onClosed;

	public void Initialize(Action<PokemonParam, int, int> onClosed)
	{
	}

	public void Open(PokemonParam param, int trayIndex, int posIndex)
	{
	}

	public void Close()
	{
	}

	public void OnUpdate()
	{
	}

	private void SetCursor(int index)
	{
	}
}
