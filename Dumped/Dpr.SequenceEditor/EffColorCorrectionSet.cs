using UnityEngine;

namespace Dpr.SequenceEditor;

public class EffColorCorrectionSet : Macro
{
	public Vector3 colorScale;

	public Vector3 colorBias;

	public float brightness;

	public float saturation;

	public float contrast;

	public float temperature;

	public float sepiaTone;

	public bool inversion;

	public SEQ_DEF_MOVETYPE move;

	public bool subCamera;

	public bool isReset;

	public EffColorCorrectionSet(Macro macro)
	{
	}
}
