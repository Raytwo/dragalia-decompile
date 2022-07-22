using UnityEngine;

namespace Dpr.SequenceEditor;

public class ParticleFollowTrainer : Macro
{
	public bool isEnable;

	public SEQ_DEF_TRAINER_ADD trg;

	public string node;

	public bool isPos;

	public bool isRot;

	public bool isScl;

	public Vector3 pos;

	public Vector3 rot;

	public bool isAnimScl;

	public bool isLocalScl;

	public ParticleFollowTrainer(Macro macro)
	{
	}
}
