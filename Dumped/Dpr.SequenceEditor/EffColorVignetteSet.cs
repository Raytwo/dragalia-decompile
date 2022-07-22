using UnityEngine;

namespace Dpr.SequenceEditor;

public class EffColorVignetteSet : Macro
{
	public SEQ_DEF_VIGNETTE_TYPE viType;

	public float viOffset;

	public float viFovDepe;

	public float viScale;

	public Vector3 viColor;

	public float imageCircle;

	public float imageCircleFov;

	public float widthScale;

	public float penumbraFov;

	public SEQ_DEF_MOVETYPE move;

	public bool subCamera;

	public EffColorVignetteSet(Macro macro)
	{
	}
}
