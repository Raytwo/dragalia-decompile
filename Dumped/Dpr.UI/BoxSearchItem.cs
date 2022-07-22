using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class BoxSearchItem : MonoBehaviour, IUIButton
{
	[SerializeField]
	private UIText _enabledTitle;

	[SerializeField]
	private UIText _enabledText;

	[SerializeField]
	private UIText _disabledTitle;

	[SerializeField]
	private UIText _disabledText;

	[SerializeField]
	private GameObject _mark;

	[SerializeField]
	private Image[] _markImages;

	[SerializeField]
	private GameObject _body;

	private int _index;

	private RectTransform _rectTransform;

	public Image[] MarkImages => null;

	public void Initialize(int no, string selectItemText)
	{
	}

	public void SetMark(int data)
	{
	}

	public void ResetStatus()
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
