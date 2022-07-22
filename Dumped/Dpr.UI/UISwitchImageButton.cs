using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class UISwitchImageButton : MonoBehaviour, IUIButton
{
	[SerializeField]
	private int id;

	[SerializeField]
	private Image image;

	[SerializeField]
	private Sprite unSelectSprite;

	[SerializeField]
	private Sprite selectSprite;

	private int index;

	private RectTransform rectTransform;

	public int Id => default(int);

	public bool IsSelected
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

	public int GetIndex()
	{
		return default(int);
	}

	public void SetIndex(int index)
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public bool GetActive()
	{
		return default(bool);
	}

	public void SetActive(bool isActive)
	{
	}

	public void Select()
	{
	}

	public void UnSelect()
	{
	}
}
