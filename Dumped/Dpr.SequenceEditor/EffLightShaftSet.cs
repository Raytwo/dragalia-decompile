using UnityEngine;

namespace Dpr.SequenceEditor;

public class EffLightShaftSet : Macro
{
	public float intensity;

	public Vector3 lsColor;

	public Vector3 srcPos;

	public float length;

	public float glareRatio;

	public float attenuation;

	public float noiseMask;

	public float noiseMaskFrequency;

	public float ringIntensity;

	public Vector3 ringOutClr;

	public float ringRadius;

	public float ringAttenua;

	public SEQ_DEF_MOVETYPE move;

	public bool subCamera;

	public EffLightShaftSet(Macro macro)
	{
	}
}
