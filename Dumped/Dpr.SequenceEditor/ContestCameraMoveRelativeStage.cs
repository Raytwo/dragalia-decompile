using UnityEngine;

namespace Dpr.SequenceEditor;

public class ContestCameraMoveRelativeStage : Macro
{
	public Vector3 pos;

	public Vector3 trg;

	public float fov;

	public SEQ_DEF_MOVETYPE move;

	public bool relative;

	public bool[] enableElemPos;

	public bool[] enableElemTrg;

	public ContestCameraMoveRelativeStage(Macro macro)
	{
	}
}
