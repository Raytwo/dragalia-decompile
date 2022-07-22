using UnityEngine;

namespace Dpr.SequenceEditor;

public class SubCameraAnimationTrainer : CameraAnimationTrainer
{
	public new SEQ_DEF_TR_CAM camType;

	public new string camFile;

	public new string anmFile;

	public new SEQ_DEF_TRAINER trg;

	public new string node;

	public new Vector3 pos;

	public new bool isFlip;

	public new bool isRot;

	public new bool forceUpdate;

	public new bool isLoseCam;

	public SubCameraAnimationTrainer(Macro macro)
	{
	}
}
