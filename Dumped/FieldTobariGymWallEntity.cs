using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using DPData;
using UnityEngine;

public class FieldTobariGymWallEntity : FieldObjectEntity
{
	public float GymWallLeftValue;

	public float GymWallRightValue;

	public string GymWallPushEventLabel;

	public bool GymWallBottomColOff_Left;

	public bool GymWallBottomColOff_Right;

	private BoxCollider[] Colliders;

	private Rect RoughlyColRect;

	private float LeftColX;

	private float RightColX;

	private bool RequestUpdateRoughlyColRect;

	public override string entityType => null;

	public bool WallIsLeftLimit
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool WallIsRightLimit
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float GymWallWorldLeftValue
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float GymWallWorldRightValue
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	public void ApplySaveData([In] ref FIELD_OBJ_SAVE_DATA saveData)
	{
	}

	public void CreateSaveData(ref FIELD_OBJ_SAVE_DATA saveData)
	{
	}

	public void Setup()
	{
	}

	public void Moved(bool isLeft)
	{
	}

	private void SetupCol()
	{
	}

	public bool CheckHit(Vector3 playerPos, Vector3 playerVec)
	{
		return default(bool);
	}
}
