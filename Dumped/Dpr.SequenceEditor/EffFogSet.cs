using UnityEngine;

namespace Dpr.SequenceEditor;

public class EffFogSet : Macro
{
	public SEQ_DEF_FOG_MODE mode;

	public float nearLen;

	public float maxLen;

	public float strength;

	public Vector3 colorScale;

	public SEQ_DEF_MOVETYPE move;

	public bool subCamera;

	public EffFogSet(Macro macro)
	{
	}
}
