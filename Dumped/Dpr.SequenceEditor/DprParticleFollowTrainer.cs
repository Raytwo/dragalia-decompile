using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprParticleFollowTrainer : Macro
{
	public bool isEnable;

	public SEQ_DEF_TRAINER trg;

	public int nodeIndex;

	public bool isPos;

	public bool isRot;

	public bool isScl;

	public Vector3 pos;

	public Vector3 rot;

	public bool isAnimScl;

	public bool isLocalScl;

	public DprParticleFollowTrainer(Macro macro)
	{
	}
}
