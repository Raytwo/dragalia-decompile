using UnityEngine;

namespace Dpr.SequenceEditor;

public class CameraAnimationTrainer : Macro
{
	public SEQ_DEF_TR_CAM camType;

	public string camFile;

	public string anmFile;

	public SEQ_DEF_TRAINER trg;

	public string node;

	public Vector3 pos;

	public bool isFlip;

	public bool isScale;

	public bool isRot;

	public bool forceUpdate;

	public bool isLoseCam;

	public CameraAnimationTrainer(Macro macro)
	{
	}
}
