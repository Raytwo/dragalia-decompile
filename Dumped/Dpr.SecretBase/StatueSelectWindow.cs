using System.Collections.Generic;
using UnityEngine;

namespace Dpr.SecretBase;

public class StatueSelectWindow : GridSelectWindow<StatueItem, StatueEffectData>
{
	public class StatueItemCompare : IComparer<StatueItem>
	{
		public int Compare(StatueItem a, StatueItem b)
		{
			return default(int);
		}
	}

	private class NGMotionMono : MonoBehaviour
	{
		private float length;

		private int count;

		private Vector3 initPos;

		private void Start()
		{
		}

		private void Update()
		{
		}
	}

	[SerializeField]
	private Canvas canvas;

	[SerializeField]
	private List<Sprite> placementSizeIcons;

	[SerializeField]
	private List<Sprite> typeEffectIcons;

	private int pokeType1;

	private int pokeType2;

	private int size;

	private int category;

	private int legend;

	private static int ListColumnNum_Normal;

	private static int ListColumnNum_Large;

	private static int ListContentSpacing_Normal;

	private static int ListContentSpacing_Large;

	private bool isListSizeNormal;

	private bool isBuildedLayout;

	private Vector2 baseCellSize;

	public Sprite GetPlacementSizeIcon(byte width, byte height)
	{
		return null;
	}

	public Sprite GetTypeEffectIcon(sbyte id)
	{
		return null;
	}

	private void Start()
	{
	}

	public void PreBuildLayout()
	{
	}

	public void Show()
	{
	}

	public void Close()
	{
	}

	public void SetCursorFromRatio(float ratio, bool left)
	{
	}

	public void UpdateIcon(int id)
	{
	}

	public void UpdateIconAll(bool isDisable)
	{
	}

	public void SortIcon(bool isDisable)
	{
	}

	public static int Compare(StatueItem dataA, StatueItem dataB)
	{
		return default(int);
	}

	public void SetFillter(int pokeType1, int pokeType2, int size, int category, int legend, int indexId, bool isDisable)
	{
	}

	public void UpdateListSize()
	{
	}
}
