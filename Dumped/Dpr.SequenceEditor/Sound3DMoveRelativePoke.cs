using UnityEngine;

namespace Dpr.SequenceEditor;

public class Sound3DMoveRelativePoke : Macro
{
	public SEQ_DEF_POS trg;

	public SEQ_DEF_NODE node;

	public Vector3 pos;

	public int rate;

	public bool isFlip;

	public bool isScale;

	public bool isRot;

	public bool isRotPos;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public Sound3DMoveRelativePoke(Macro macro)
	{
	}
}
