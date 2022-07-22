using UnityEngine;

namespace Dpr.SequenceEditor;

public class EffFixParamSetVector : Macro
{
	public SEQ_DEF_POS trg;

	public bool trgPoke;

	public bool trgTra;

	public string name;

	public Vector3 startVec;

	public Vector3 endVec;

	public SEQ_DEF_MOVETYPE move;

	public SEQ_DEF_FIXPARAM_CALC calc;

	public EffFixParamSetVector(Macro macro)
	{
	}
}
