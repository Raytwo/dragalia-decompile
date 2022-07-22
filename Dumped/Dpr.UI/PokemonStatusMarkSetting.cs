using System.Collections;
using System.Collections.Generic;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class PokemonStatusMarkSetting : MonoBehaviour
{
	private enum OpenState
	{
		Closed,
		Opening,
		Opened,
		Closing
	}

	[SerializeField]
	private RectTransform _markRoot;

	[SerializeField]
	private Cursor _cursor;

	public UnityAction onClosed;

	private List<PokemonStatusMark> _marks;

	private int _selectIndex;

	private Animator _animator;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private OpenState _openState;

	public List<PokemonStatusMark> marks => null;

	private void Awake()
	{
	}

	public void Open(BoxMarkColor[] types)
	{
	}

	private IEnumerator OpOpen(BoxMarkColor[] types)
	{
		return null;
	}

	private void Close(UnityAction onClosed_)
	{
	}

	public IEnumerator OpClose(UnityAction onClosed_)
	{
		return null;
	}

	public bool OnUpdate(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	private bool SetSelectIndex(int selectIndex, bool isInitialize = false)
	{
		return default(bool);
	}
}
