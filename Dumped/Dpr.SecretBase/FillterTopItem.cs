using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class FillterTopItem : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _enabledTitle;

	[SerializeField]
	private TextMeshProUGUI _enabledText;

	[SerializeField]
	private TextMeshProUGUI _disabledTitle;

	[SerializeField]
	private TextMeshProUGUI _disabledText;

	[SerializeField]
	private Image _enabledMark;

	[SerializeField]
	private Image _disabledMark;

	[SerializeField]
	private GameObject _body;

	private int _index;

	private RectTransform _rectTransform;

	public void Initialize(string titleText, string text)
	{
	}

	public void SetText(string text)
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
