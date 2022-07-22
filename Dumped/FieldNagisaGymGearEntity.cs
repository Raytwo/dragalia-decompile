using Dpr;
using UnityEngine;

public class FieldNagisaGymGearEntity : FieldEventEntity
{
	public enum GearRotateDegType
	{
		None,
		Plus90,
		Minus90,
		Plus180,
		Minus180
	}

	public enum GearRotateAxisType
	{
		X,
		Y
	}

	public enum InitSequenceType
	{
		None,
		Wait,
		TempShift,
		Fix
	}

	[SerializeField]
	public int GearGroupNo;

	public GearRotateDegType GearRotateButton;

	public GearRotateAxisType GearRotateAxis;

	public string GearRotateEventLabel;

	private FieldFloatMove DegMove;

	private Vector3 originalLocalEulerAngles;

	private bool IsSetuped;

	private InitSequenceType InitSequence;

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	public void Setup(AreaID areaId)
	{
	}

	public void SceneStart()
	{
	}

	public static float GetDegRotateType(GearRotateDegType rotateType)
	{
		return default(float);
	}

	public void Rotate(GearRotateDegType rotateType, int triggerGroupNo)
	{
	}

	public bool IsRotating()
	{
		return default(bool);
	}

	private void SetRotate(float angle)
	{
	}
}
