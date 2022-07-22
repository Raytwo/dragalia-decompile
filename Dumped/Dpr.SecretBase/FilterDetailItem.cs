using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;

namespace Dpr.SecretBase;

public class FilterDetailItem : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _enabledText;

	[SerializeField]
	private TextMeshProUGUI _disabledText;

	[SerializeField]
	private GameObject _body;

	private int _index;

	private RectTransform _rectTransform;

	public string ItemTextxt
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize(string itemText)
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
