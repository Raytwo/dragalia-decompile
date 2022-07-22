using System.Runtime.CompilerServices;
using Dpr.EvScript;

public class FieldEventLiftEntity : FieldEventEntity
{
	public enum LiftAxisType
	{
		X,
		Y,
		Z
	}

	public enum LiftSEType
	{
		NONE,
		DEFAULT,
		LEAGUE,
		MIO_GYM_X,
		MIO_GYM_Y
	}

	public LiftAxisType LiftAxis;

	public float LiftValueA;

	public float LiftValueB;

	public string LiftEventLabel;

	public bool LiftFixB;

	[SearchableEnum]
	public EvWork.FLAG_INDEX LiftFlag;

	public LiftSEType LiftSE;

	public bool MoveAfterWalk;

	public bool IsLiftB
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

	public bool IsLiftEnable
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

	public float LiftWorldValueA
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

	public float LiftWorldValueB
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

	public void Setup()
	{
	}

	public bool IsCompleteMoved()
	{
		return default(bool);
	}

	public void PlayStartSE()
	{
	}

	public void PlayEndSE()
	{
	}

	public void StopSE()
	{
	}
}
