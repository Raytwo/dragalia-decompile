using System;
using System.Runtime.CompilerServices;
using Dpr.BallDeco;
using UnityEngine;

namespace Dpr.UI;

public class Capsule2DViewController : MonoBehaviour
{
	[SerializeField]
	private GameObject frontObject;

	[SerializeField]
	private GameObject backObject;

	[SerializeField]
	private RectTransform gridRootRectTransfrom;

	[SerializeField]
	private Color gridFrontColor;

	[SerializeField]
	private Color gridBackColor;

	[SerializeField]
	private Color affixedSealGridColor;

	private Capsule2DGridCell[] gridCells;

	private Capsule2DGridCell currentGridCell;

	private bool isFrontView;

	private RectTransform gridCenterRectTransform;

	public event Action OnReverseAction
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public void Initialize()
	{
	}

	public void Setup(CapsuleInfo capsuleInfo, bool isReset2DFrontView)
	{
	}

	public bool MoveGridCell(int x, int y)
	{
		return default(bool);
	}

	public Capsule2DGridCell GetCurrentGridCell()
	{
		return null;
	}

	public void SetCurrentGridCell(Capsule2DGridCell cell)
	{
	}

	public void ResetCurrentGridCell()
	{
	}

	public Capsule2DGridCell GetNearGridCell(Vector3 pos)
	{
		return null;
	}

	public void Reverse()
	{
	}

	private void UpdateView()
	{
	}

	private void UpdateGridCells(AffixSealData[] affixSealDatas, int sealCount)
	{
	}
}
