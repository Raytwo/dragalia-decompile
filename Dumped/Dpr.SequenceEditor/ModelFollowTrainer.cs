using UnityEngine;

namespace Dpr.SequenceEditor;

public class ModelFollowTrainer : Macro
{
	public bool isEnable;

	public SEQ_DEF_TRAINER trg;

	public string node;

	public bool isPos;

	public bool isRot;

	public bool isScl;

	public Vector3 pos;

	public Vector3 rot;

	public bool changeLight;

	public bool checkVisible;

	public ModelFollowTrainer(Macro macro)
	{
	}
}
