using UnityEngine;

namespace Dpr.SequenceEditor;

public class EffLightGhostSet : Macro
{
	public SEQ_DEF_LG_LUM lumFactor;

	public SEQ_DEF_LG_SHAPE lightGhostShape;

	public Vector3 srcPos;

	public Vector3 lgColor;

	public float intensity;

	public float sizeScale;

	public float distScale;

	public float vignette;

	public float distortion;

	public SEQ_DEF_MOVETYPE move;

	public bool subCamera;

	public EffLightGhostSet(Macro macro)
	{
	}
}
