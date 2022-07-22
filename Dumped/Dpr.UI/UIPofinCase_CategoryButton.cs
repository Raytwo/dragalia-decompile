using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UIPofinCase_CategoryButton : MonoBehaviour
{
	public UIPofinCase_CategorySelector.Category category;

	public Action OnEnableCallback;

	private Image image;

	private UIText text;

	private static readonly Color OffColor;

	public Sprite SelectedImage;

	public Sprite UnselectedImage;

	public bool isOn
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private void Awake()
	{
	}

	public void SetOn()
	{
	}

	public void SetOff()
	{
	}
}
