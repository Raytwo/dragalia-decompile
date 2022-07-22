using DPData;
using XLSXContent;

public class FieldKinomiGrowEntity : FieldEventEntity
{
	public int KinomiPlaceIndex;

	private KinomiWork.GrowPhase NowGrowPhase;

	private bool NowWet;

	private KinomiObject KinomiObject;

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void ProcessSequence(float deltaTime)
	{
	}

	public KinomiGrow GetGrow()
	{
		return default(KinomiGrow);
	}

	public KinomiPlaceData.SheetSheet1 GetPlaceData()
	{
		return null;
	}

	public KinomiWork.GrowPhase GetGrowPhase()
	{
		return default(KinomiWork.GrowPhase);
	}

	public void UpdateStatus()
	{
	}
}
