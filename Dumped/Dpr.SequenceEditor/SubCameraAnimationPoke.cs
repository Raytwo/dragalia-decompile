using UnityEngine;

namespace Dpr.SequenceEditor;

public class SubCameraAnimationPoke : Macro
{
	public string camFile;

	public string anmFile;

	public SEQ_DEF_POS trg;

	public SEQ_DEF_NODE node;

	public Vector3 pos;

	public bool isFlip;

	public bool isScale;

	public bool isRot;

	public bool forceUpdate;

	public SubCameraAnimationPoke(Macro macro)
	{
	}
}
