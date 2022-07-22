using UnityEngine;
using UnityEngine.Events;

namespace Dpr.UI;

public class ContextMenuItem : MonoBehaviour, IUIButton
{
	public class Param
	{
		public enum ColorType
		{
			Default,
			FieldWaza
		}

		public const ContextMenuID ContextMenuIdUser = (ContextMenuID)10000;

		public ContextMenuID menuId;

		public string messageFile;

		public string messageLabel;

		public int messageIndex;

		public string text;

		public ColorType colorType;
	}

	[SerializeField]
	private UIText _text;

	private Color[] _fontColors;

	private Param _param;

	private int _index;

	public Param param => null;

	public int index => default(int);

	public void Setup(Param param, Color[] fontColors, int index, UnityAction<int, Param> onSetupMessageArgs)
	{
	}

	public float GetWidth()
	{
		return default(float);
	}

	public void SetWidth(float width)
	{
	}

	public void Select(bool enabled)
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
}
