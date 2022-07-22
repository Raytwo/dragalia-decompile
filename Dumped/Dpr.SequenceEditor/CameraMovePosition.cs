using UnityEngine;

namespace Dpr.SequenceEditor;

public class CameraMovePosition : Macro
{
	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public SEQ_DEF_MOVETYPE move;

	public bool relative;

	public bool[] enableElemPos;

	public bool[] enableElemTrg;

	public CameraMovePosition(Macro macro)
	{
	}
}
