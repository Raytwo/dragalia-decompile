using UnityEngine;

namespace Dpr.SequenceEditor;

public class ParticleFollowOtherModel : Macro
{
	public bool isEnable;

	public SEQ_DEF_POS pos;

	public SEQ_DEF_NODE node;

	public Vector3 posOfs;

	public bool isRot;

	public bool isScl;

	public ParticleFollowOtherModel(Macro macro)
	{
	}
}
