using UnityEngine;

namespace Dpr.SequenceEditor;

public class DprCameraRotate : Macro
{
	public Vector3 rot;

	public SEQ_DEF_MOVETYPE move;

	public bool relative;

	public bool[] enableElemRot;

	public DprCameraRotate(Macro macro)
	{
	}
}
