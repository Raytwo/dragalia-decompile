using UnityEngine;

namespace Dpr.SequenceEditor;

public class SubCameraAnimationDoubleIntro : Macro
{
	public string envfile;

	public string motfileA;

	public string motfileB;

	public string motfileC;

	public SEQ_DEF_POS trgA;

	public SEQ_DEF_POS trgB;

	public SEQ_DEF_NODE node;

	public Vector3 pos;

	public bool isFlip;

	public bool isRot;

	public bool forceUpdate;

	public SubCameraAnimationDoubleIntro(Macro macro)
	{
	}
}
