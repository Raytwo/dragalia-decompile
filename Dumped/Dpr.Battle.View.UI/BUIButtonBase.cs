using System;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dpr.Battle.View.UI;

public abstract class BUIButtonBase<T> : UIBehaviour, IBattleUIButton<T> where T : BUIButtonBase<T>
{
	public enum TransitionType
	{
		Scale,
		Sprite
	}

	public enum StateType
	{
		None,
		Selected
	}

	private static readonly Color DisableColor;

	[SerializeField]
	protected Image _backgroundImage;

	[SerializeField]
	protected Image _foregroundImage;

	[SerializeField]
	protected TextMeshProUGUI _text;

	[SerializeField]
	protected int _index;

	[SerializeField]
	protected TransitionType _transition;

	[SerializeField]
	protected StateType _state;

	protected bool _isSelected;

	protected bool _isEnabele;

	private RectTransform _cachedRectTransform;

	protected Action _onSelected;

	protected Action _onSubmit;

	public bool IsSelected
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public RectTransform rectTransform => null;

	public StateType State => default(StateType);

	public int Index
	{
		get
		{
			return default(int);
		}
		protected set
		{
		}
	}

	public string Text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	protected override void OnDestroy()
	{
	}

	public T SetOnSelected(Action onSelected)
	{
		return null;
	}

	public T SetOnSubmit(Action onSubmit)
	{
		return null;
	}

	public bool Submit()
	{
		return default(bool);
	}

	protected virtual void OnChangeState(StateType type)
	{
	}
}
