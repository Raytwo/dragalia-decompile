using UnityEngine;

namespace Dpr.SequenceEditor;

public class PostEffectRadialBlurSet : Macro
{
	public Vector3 center;

	public float intensity;

	public int numSamples;

	public SEQ_DEF_MOVETYPE move;

	public PostEffectRadialBlurSet(Macro macro)
	{
	}
}
