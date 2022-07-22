using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class Townmap : MonoBehaviour
{
	[Serializable]
	protected class NoticeParam
	{
		public RectTransform root;

		public TownmapIcon prefab;
	}

	[Serializable]
	protected class HiddenMapParam
	{
		public Vector2Int cell;

		public RectTransform map;
	}

	[Serializable]
	protected class Patch0DayParam
	{
		public Image _cloud;

		public Image _road;

		public void Enable(bool enabled)
		{
		}
	}

	public enum TownmapType
	{
		Default,
		Field,
		Fly
	}

	public enum NoticeType
	{
		None = -1,
		Kinomi,
		Tree,
		TreeWithHoneyWait,
		TreeWithHoney,
		Num
	}

	public class Cell
	{
		public class Kinomi
		{
			public KinomiData.SheetData data;

			public KinomiPlaceData.SheetSheet1 placeData;
		}

		[Flags]
		public enum HabitatBits
		{
			Fishing = 1,
			PokemonTraser = 2,
			HoneyTree = 4,
			Normal = 8,
			Set = 0x10,
			All = 0xF
		}

		public TownMapTable.SheetData data;

		public List<TownmapSymbol> symbols;

		public int[] habitats;

		public static bool UseData(Cell cell)
		{
			return default(bool);
		}

		public bool IsView()
		{
			return default(bool);
		}

		public bool IsArrive()
		{
			return default(bool);
		}

		public bool IsFly(bool useArrive)
		{
			return default(bool);
		}

		public static int GetHabitatIndex(SheetDistributionTable.HabitatType type, SheetDistributionTable.TimeZoneType timeZone)
		{
			return default(int);
		}

		public int GetHabitatBits(SheetDistributionTable.HabitatType habitatType, SheetDistributionTable.TimeZoneType timeZone)
		{
			return default(int);
		}
	}

	[SerializeField]
	protected float _cursorSpeed;

	[SerializeField]
	protected RectTransform _cellRoot;

	[SerializeField]
	protected TownmapPlayerIcon _player;

	[SerializeField]
	protected TownmapIcon _goal;

	[SerializeField]
	protected RectTransform _symbolRoot;

	[SerializeField]
	protected RectTransform _noticeRoot;

	[SerializeField]
	protected NoticeParam[] _noticeParams;

	[SerializeField]
	protected HiddenMapParam[] _hiddenMapParams;

	[SerializeField]
	protected Patch0DayParam _patch0DayParam;

	[SerializeField]
	protected float _snapDistance;

	public const int CellNumX = 34;

	public const int CellNumY = 27;

	public const int CellSize = 24;

	public const float CellSizeHalf = 12f;

	protected static Cell[,] _cells;

	protected static Dictionary<ZoneID, List<TownMapTable.SheetData>> _dataDictByZoneId;

	protected Vector3 _cursorPos;

	protected Vector2 _moveVec;

	protected bool _isAnalogCellChanged;

	protected UnityAction<Cell, bool> _onCellChanged;

	protected List<List<UIManager.DuplicateImageMaterialParam>> _duplicates;

	public RectTransform cellRoot => null;

	public Vector3 cursorPos => default(Vector3);

	public void Setup(TownmapType type, TownMapGuideTable.SheetGuide guideData, UnityAction<Cell, bool> onCellChanged)
	{
	}

	protected void OnDestroy()
	{
	}

	protected TownMapTable.SheetData GetMapDataByPlayer()
	{
		return null;
	}

	protected void SetupDatas()
	{
	}

	protected void SetupSymbols()
	{
	}

	protected void SetupKinomis()
	{
	}

	protected void SetupHoneyTrees()
	{
	}

	protected void SetupHiddenMap()
	{
	}

	protected bool CanKinomiHarvest(KinomiPlaceData.SheetSheet1 placeData)
	{
		return default(bool);
	}

	protected int GetIndex(TownMapTable.SheetData data, Vector2Int pos)
	{
		return default(int);
	}

	protected TownMapTable.SheetData GetData(ZoneID zoneId, Vector2Int pos)
	{
		return null;
	}

	protected TownMapTable.SheetData GetData(ZoneID zoneId, int index1)
	{
		return null;
	}

	protected Cell GetCell(Vector2 cellPos)
	{
		return null;
	}

	public void SetCell(Vector2 cellPos, Cell cell)
	{
	}

	public Cell GetCurrentCell()
	{
		return null;
	}

	public Vector3 ToCellIconPos(Vector2 cellPos)
	{
		return default(Vector3);
	}

	public Vector2 ToCellPos(Vector3 iconPos)
	{
		return default(Vector2);
	}

	protected void SetPlayerPos(Vector2 cellPos)
	{
	}

	protected void SetCursorPos(Vector2 cellPos)
	{
	}

	public void ResetCursorPos(bool isForce = false)
	{
	}

	public virtual bool OnUpdate(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	protected virtual bool UpdateMove(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	protected bool UpdateDigitalMove(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	protected void PlayCellChangeSe(Cell cell)
	{
	}

	protected void ClampCursorPos()
	{
	}

	protected bool UpdateAnalogMove(float deltaTime, UIInputController input)
	{
		return default(bool);
	}

	private static int GetAnalogStickIndex(Vector2 analogStick)
	{
		return default(int);
	}

	public void SetNoticeType(NoticeType type)
	{
	}

	private void CellChanged(Cell cell, bool isReset, bool isAnalogMoveing)
	{
	}
}
