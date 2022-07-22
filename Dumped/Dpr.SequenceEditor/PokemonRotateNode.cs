using UnityEngine;

namespace Dpr.SequenceEditor;

public class PokemonRotateNode : Macro
{
	public SEQ_DEF_POS trg;

	public SEQ_DEF_NODE node;

	public Vector3 scale;

	public bool relative;

	public bool isFlip;

	public SEQ_DEF_MOVETYPE move;

	public PokemonRotateNode(Macro macro)
	{
	}
}
