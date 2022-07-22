using System.Collections;
using UnityEngine;

namespace Dpr.SecretBase;

public class StatuePlacementManger : MonoBehaviour
{
	public enum CursorMode
	{
		Field,
		Placement
	}

	[SerializeField]
	private SecretBaseMasterDataManager masterData;

	[SerializeField]
	private GameObject placementGuide;

	[SerializeField]
	private StatuePlacementGridManager gridManager;

	[SerializeField]
	private FieldCursor fieldCursor;

	[SerializeField]
	private FieldCursor placementCursor;

	[SerializeField]
	private FieldCursor placementCursorSelect;

	[SerializeField]
	private FieldCursor impossibleField;

	[SerializeField]
	private Transform statueRoot;

	[SerializeField]
	private StatuePlacementCrystal crystal;

	[SerializeField]
	private StatuePlacementEffectManager effectManager;

	[SerializeField]
	private SecretBaseAudioManager audioManager;

	private FieldCursor currentCursor;

	private Vector2Int gridPosition;

	private CursorMode cursorMode;

	public FieldCursor FieldCursor => null;

	public FieldCursor PlacementCursor => null;

	public Transform StatueRoot => null;

	public Vector2Int GridPosition => default(Vector2Int);

	public IEnumerator Load()
	{
		return null;
	}

	public bool IsLoadCompleted()
	{
		return default(bool);
	}

	public void Initialize()
	{
	}

	public void SetCursorMode(CursorMode mode)
	{
	}

	public void SetActivePlaceMentGuide(bool isActive)
	{
	}

	public void CursorMoveToLeft()
	{
	}

	public void CursorMoveToRight()
	{
	}

	public void CursorMoveToUp()
	{
	}

	public void CursorMoveToDown()
	{
	}

	private void ApplyCursorPos()
	{
	}

	public void AddStatue(PlacementData info)
	{
	}

	public void SetPlacementCursorRect(RectInt rect)
	{
	}

	public bool IsCanBePlacement()
	{
		return default(bool);
	}

	public bool IsCanBeSelectedField()
	{
		return default(bool);
	}

	public PlacementData GetOverlapedPlacementData()
	{
		return null;
	}

	public bool SetStatueDir(PlacementData target, int placement_dir)
	{
		return default(bool);
	}

	public void UpdateCrystalColor()
	{
	}

	private void SetCurrentCursor(FieldCursor current)
	{
	}

	public void SetSelectPedestalMode(bool isPedestalMode)
	{
	}
}
