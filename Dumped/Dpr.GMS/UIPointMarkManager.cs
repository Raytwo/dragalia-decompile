using Dpr.Contest;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIPointMarkManager : MonoBehaviour
{
	[SerializeField]
	private UINetworkIcon uiNetworkIcon;

	[SerializeField]
	private Image cursorImage;

	[SerializeField]
	private Sprite[] cursorSprArray;

	private ObjectPoolSystem<UIPointMark> markObjPool;

	private UIPointMark[] pointMarkArray;

	private UIPointMark nowSelectMark;

	private RectTransform cursorRect;

	private Canvas canvas;

	private GameObject template;

	private Transform poolParent;

	private int nowShowIconNum;

	private int currentSelectIndex;

	private int generatedCount;

	private bool isGeneratedPool;

	private bool active;

	public bool IsGeneratedPool => default(bool);

	private bool CanAddPool => default(bool);

	public void Initialize()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	public void OnFinalize()
	{
	}

	public void Setup(GMSPointDataModel[] points)
	{
	}

	public void ShowGMSMark(GMSMode gmsMode)
	{
	}

	public void ResetPoints()
	{
	}

	public Vector2 GetMarkPos()
	{
		return default(Vector2);
	}

	public void ShowUIMark()
	{
	}

	public void ShowOnlySelectMark()
	{
	}

	public void HideUIMark()
	{
	}

	public void OnSelectPoint(int dataIndex)
	{
	}

	private void UnSelectPrevPoint()
	{
	}

	public void HideAllIcon()
	{
	}

	public void ShowMatchingIcon()
	{
	}

	public void HideMatchingIcon()
	{
	}

	public void ShowAttentionIcon()
	{
	}

	public void HideAttentionIcon()
	{
	}

	public void UpdatePointPosition(int index, GMSPointDataModel pointDataModel)
	{
	}

	private void UpdatePointMark(int index, GMSPointDataModel pointDataModel)
	{
	}

	private void HidePointMark(int index)
	{
	}

	public void UpdatePointView(int index)
	{
	}
}
