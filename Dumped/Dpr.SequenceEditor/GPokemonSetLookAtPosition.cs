using UnityEngine;

namespace Dpr.SequenceEditor;

public class GPokemonSetLookAtPosition : Macro
{
	public bool enable;

	public SEQ_DEF_POS trg;

	public Vector3 pos;

	public bool relative;

	public bool isRotPos;

	public bool isFlip;

	public bool[] enableElem;

	public GPokemonSetLookAtPosition(Macro macro)
	{
	}
}
