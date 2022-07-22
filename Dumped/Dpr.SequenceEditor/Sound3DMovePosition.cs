using UnityEngine;

namespace Dpr.SequenceEditor;

public class Sound3DMovePosition : Macro
{
	public Vector3 pos;

	public bool relative;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public Sound3DMovePosition(Macro macro)
	{
	}
}
