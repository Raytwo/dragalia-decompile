using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprCameraMovePositionBezier : Macro
{
	public bool relative;

	public Vector3 p0;

	public Vector3 p1;

	public Vector3 p2;

	public Vector3 p3;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public DprCameraMovePositionBezier(Macro macro)
	{
	}
}
