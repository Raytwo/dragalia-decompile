using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class AdventureNoteItem : MonoBehaviour, IUIButton
{
	public class Param
	{
		public enum StateNew
		{
			Show,
			Hide
		}

		public AdventureNoteID noteId;

		public List<AdventureNoteData.SheetData> datas;

		public StateNew stateNew;
	}

	[SerializeField]
	private UIText _title;

	[SerializeField]
	private RectTransform _cursorRoot;

	[SerializeField]
	private Image _newIcon;

	[SerializeField]
	private Image _body;

	[SerializeField]
	private Sprite[] _spriteBodys;

	[SerializeField]
	private Color[] _colors;

	private Param _param;

	private int _index;

	public Param param => null;

	public int index => default(int);

	public RectTransform cursorRoot => null;

	public void Setup(Param param, int pageIndex = 0)
	{
	}

	public virtual bool GetActive()
	{
		return default(bool);
	}

	public virtual void SetActive(bool isActive)
	{
	}

	public virtual int GetIndex()
	{
		return default(int);
	}

	public virtual void SetIndex(int index)
	{
	}

	public virtual RectTransform GetRectTransform()
	{
		return null;
	}

	public virtual void Select()
	{
	}

	public virtual void UnSelect()
	{
	}

	public void SetNew(Param.StateNew stateNew)
	{
	}
}
