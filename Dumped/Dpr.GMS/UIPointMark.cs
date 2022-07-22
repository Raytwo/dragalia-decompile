using Dpr.Contest;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIPointMark : MonoBehaviour, IPoolObject
{
	[SerializeField]
	private GameObject iconContent;

	[SerializeField]
	private Image pointImage;

	[SerializeField]
	private Image monsIconImage;

	[SerializeField]
	private Image monsShadowImage;

	private GMSPointDataModel refPointData;

	private RectTransform rect;

	private bool isShowMonsIcon;

	private bool bIconVisibleFlag;

	public Vector3 Position => default(Vector3);

	public bool IsActive()
	{
		return default(bool);
	}

	public void Initialize()
	{
	}

	public void ChangeMarkView(bool isShowMonsIcon)
	{
	}

	public void ShowPoint(GMSPointDataModel targetPointData)
	{
	}

	public void HidePointIcon()
	{
	}

	private void SetIconImageVisible(bool visible)
	{
	}

	public void OnSelect(RectTransform cursorRect)
	{
	}

	public void UnSelect()
	{
	}

	public void UpdatePosition()
	{
	}

	public void UpdateView()
	{
	}
}
