using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.EvScript;
using Dpr.RouteSearch;
using UnityEngine;

public class FieldObjectEntity : BaseEntity
{
	public new class SequenceID : BaseEntity.SequenceID
	{
		public const int Active = 4096;

		public const int ScriptMove = 8193;

		public const int ScriptStop = 8194;

		protected new const int User = 8192;
	}

	[NonSerialized]
	public Vector3 moveVector;

	[NonSerialized]
	public bool isExtruded;

	[NonSerialized]
	public bool isLanding;

	private FieldObjectRouteMove _routeMove;

	public bool IsIgnorePlayerCollision;

	private EvEntityCommand _evEntityCmd;

	[NonSerialized]
	public Vector3[] logPosition;

	[NonSerialized]
	public byte logcount;

	private bool _scaleChangeFlag;

	private float _scaleStart;

	private float _scaleEnd;

	private float _scaleTime;

	private float _scaleProgressTime;

	[NonSerialized]
	public EvDataManager.EntityParam EventParams;

	public override string entityType => null;

	public Vector3 oldMoveVector
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Vector4 locatorDirect
	{
		set
		{
		}
	}

	public FieldObjectRouteMove RouteMove => null;

	public bool IsBusyRouteMove => default(bool);

	public Vector2Int gridPosition
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	public Vector2Int gridPositionDirect
	{
		get
		{
			return default(Vector2Int);
		}
		set
		{
		}
	}

	public EvEntityCommand EvEntityCmd => null;

	public Vector2Int oldGridPosition
	{
		[CompilerGenerated]
		get
		{
			return default(Vector2Int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public float Height
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public static Vector2 GridToPosition(Vector2Int grid)
	{
		return default(Vector2);
	}

	public static Vector2Int PositionToGrid(Vector3 position)
	{
		return default(Vector2Int);
	}

	public static Vector3 Vec2ToVec3Position([In] ref Vector2 position, float height)
	{
		return default(Vector3);
	}

	public static Vector2 Vec3ToVec2Position([In] ref Vector3 position)
	{
		return default(Vector2);
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	protected override void OnLateUpdate(float deltaTime)
	{
	}

	protected override bool SwitchToNext()
	{
		return default(bool);
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	public DIR GetDir()
	{
		return default(DIR);
	}

	public static DIR GetDir(float dir)
	{
		return default(DIR);
	}

	public void SetDir(DIR dir)
	{
	}

	public static int GetIdleAnimation(FieldObjectEntity entity)
	{
		return default(int);
	}

	public static int GetWalkAnimation(FieldObjectEntity entity)
	{
		return default(int);
	}

	public void SetScaleData(float start = 1f, float end = 1f, float time = 0f)
	{
	}

	private void ChangeScale(float deltaTime)
	{
	}
}
