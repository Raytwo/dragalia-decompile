using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxWallPaperItem : MonoBehaviour, IUIButton
{
	[SerializeField]
	private UIText _enabledText;

	[SerializeField]
	private UIText _disabledText;

	[SerializeField]
	private Image _mark;

	[SerializeField]
	private GameObject _body;

	private int _index;

	private RectTransform _rectTransform;

	private static Vector3 _markPosition;

	private static Vector3 _iconPosition;

	public string ItemText => null;

	public void Initialize(int no)
	{
	}

	public void Initialize(int no, string itemText, bool isEnable = true)
	{
	}

	public void Initialize(int no, Sprite mark, BoxMarkColor markColor = BoxMarkColor.NONE)
	{
	}

	public void ChangeMarkColor()
	{
	}

	public void SetPokemonIcon(Sprite iconSprite)
	{
	}

	public void SetSelect(bool isEnable)
	{
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
