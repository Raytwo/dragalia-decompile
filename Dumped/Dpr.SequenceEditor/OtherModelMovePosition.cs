using UnityEngine;

namespace Dpr.SequenceEditor;

public class OtherModelMovePosition : Macro
{
	public SEQ_DEF_POS trg;

	public Vector3 pos;

	public bool relative;

	public bool isRotPos;

	public bool isFlip;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public OtherModelMovePosition(Macro macro)
	{
	}
}
