using UnityEngine;

namespace Dpr.SequenceEditor;

public class OtherModelScaleNode : Macro
{
	public SEQ_DEF_POS trg;

	public SEQ_DEF_NODE node;

	public bool reset;

	public Vector3 scale;

	public bool relative;

	public SEQ_DEF_MOVETYPE move;

	public bool origin;

	public OtherModelScaleNode(Macro macro)
	{
	}
}
