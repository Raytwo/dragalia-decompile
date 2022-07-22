using UnityEngine;

namespace Dpr.SequenceEditor;

public class ModelMovePosition : Macro
{
	public Vector3 pos;

	public bool relative;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public ModelMovePosition(Macro macro)
	{
	}
}
