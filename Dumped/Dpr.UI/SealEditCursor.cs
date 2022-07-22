using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class SealEditCursor : MonoBehaviour
{
	[SerializeField]
	private Image image;

	[SerializeField]
	private Sprite normalSprite;

	[SerializeField]
	private Sprite selectedSprite;

	[SerializeField]
	private SealIcon sealIcon;

	[SerializeField]
	private GameObject infoTextObject;

	[SerializeField]
	private RectTransform infoTextLeftRectTransform;

	[SerializeField]
	private RectTransform infoTextRightRectTransform;

	[SerializeField]
	private UIText nameText;

	[SerializeField]
	private UIText infoText;

	[SerializeField]
	private Vector2 normalPivot;

	[SerializeField]
	private Vector2 selectedPivot;

	[SerializeField]
	private float correctBorderLessY;

	[SerializeField]
	private float baseYValue;

	[SerializeField]
	private float correctYValue;

	[SerializeField]
	private SealEditSealCountView countView;

	[SerializeField]
	private Color countDefaultColor;

	[SerializeField]
	private Color countZeroColor;

	[SerializeField]
	private Color countMaxColor;

	private RectTransform rectTransform;

	private RectTransform sealIconRectTransform;

	private RectTransform infoTextRectTransform;

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

	public int SelectedSealId
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public void Initialize()
	{
	}

	public RectTransform GetRectTransform()
	{
		return null;
	}

	public RectTransform GetInfoTextRightRectTransform()
	{
		return null;
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public void SetAnchorPosition(Vector2 pos)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public void Move(float x, float y)
	{
	}

	public void Selected(int sealId)
	{
	}

	public void Unselect()
	{
	}

	public void SetInfoText(SealInfo sealInfo, bool isShowLeft = false)
	{
	}
}
