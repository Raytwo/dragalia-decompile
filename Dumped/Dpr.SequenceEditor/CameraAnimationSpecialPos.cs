using UnityEngine;

namespace Dpr.SequenceEditor;

public class CameraAnimationSpecialPos : Macro
{
	public string camFile;

	public string anmFile;

	public SEQ_DEF_SPPOS posTrg;

	public Vector3 posOfs;

	public bool isFlip;

	public bool isRot;

	public CameraAnimationSpecialPos(Macro macro)
	{
	}
}
