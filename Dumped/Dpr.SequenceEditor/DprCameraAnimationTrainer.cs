using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprCameraAnimationTrainer : Macro
{
	public SEQ_DEF_TR_CAM camType;

	public string camFile;

	public SEQ_DEF_TRAINER trg;

	public SEQ_DEF_NODE_MODEL node;

	public Vector3 pos;

	public bool isFlip;

	public bool isScale;

	public bool isRot;

	public bool forceUpdate;

	public bool isLoseCam;

	public DprCameraAnimationTrainer(Macro macro)
	{
	}
}
