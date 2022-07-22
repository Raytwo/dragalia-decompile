using System.Collections;
using System.Collections.Generic;
using Dpr.UI;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class XMenuTopItem : MonoBehaviour
{
	[SerializeField]
	private RectTransform _root;

	[SerializeField]
	private Image _icon;

	[SerializeField]
	private Image _newIcon;

	[SerializeField]
	private Image _imageShadow;

	[SerializeField]
	private UIText _name;

	[SerializeField]
	private Sprite[] _spriteIcons;

	private Animator _animator;

	private static readonly int _animStateSelect;

	private static readonly int _animStateNormal;

	private static readonly int _animStateDecide;

	public static readonly int animStateIn;

	public static readonly int animStateOut;

	private XMenuTop.ItemType _itemType;

	private List<UIManager.DuplicateImageMaterialParam> _duplicate;

	public XMenuTop.ItemType itemType => default(XMenuTop.ItemType);

	public bool isNew => default(bool);

	public void Setup(XMenuTop.ItemType itemType, bool isActived, bool isNew, bool enabled)
	{
	}

	private void OnDestroy()
	{
	}

	public void PlayAnimation(int shortNameHash)
	{
	}

	public void EnableSwapMode(bool enabled)
	{
	}

	public void Select(bool enabled)
	{
	}

	public void ShowName(bool enabled)
	{
	}

	public void Decide(UnityAction<XMenuTopItem> onDecided)
	{
	}

	private IEnumerator OpDecide(UnityAction<XMenuTopItem> onDecided)
	{
		return null;
	}
}
