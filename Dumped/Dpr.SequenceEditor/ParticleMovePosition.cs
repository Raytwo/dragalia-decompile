using UnityEngine;

namespace Dpr.SequenceEditor;

public class ParticleMovePosition : Macro
{
	public Vector3 pos;

	public bool relative;

	public bool isRotPos;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public ParticleMovePosition(Macro macro)
	{
	}
}
