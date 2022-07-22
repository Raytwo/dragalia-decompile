using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprCameraMovePosition : Macro
{
	public Vector3 pos;

	public SEQ_DEF_MOVETYPE move;

	public bool relative;

	public bool[] enableElemPos;

	public DprCameraMovePosition(Macro macro)
	{
	}
}
