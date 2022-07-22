using Dpr;
using UnityEngine;

public class FieldTvEntity : FieldEventEntity
{
	private static readonly string FrameIndexName;

	private static readonly string AutoSwitchName;

	public int FixFrameIndex;

	private Material MonitorMaterial;

	private bool Contacted;

	private int[] CommercialList;

	private int CommercialIndex;

	private FieldFloatMove Time;

	public void SetView(int frameIndex)
	{
	}

	public void ResetView()
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnUpdate(float deltaTime)
	{
	}

	private void PlayCommercial()
	{
	}

	private void ResetCommercialList()
	{
	}

	private void InitMaterial()
	{
	}

	private void SetViewCore(int frameIndex)
	{
	}
}
