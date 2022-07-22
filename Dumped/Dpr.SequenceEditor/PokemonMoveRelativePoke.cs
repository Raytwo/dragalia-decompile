using UnityEngine;

namespace Dpr.SequenceEditor;

public class PokemonMoveRelativePoke : Macro
{
	public SEQ_DEF_POS moveTrg;

	public SEQ_DEF_POS posTrg;

	public SEQ_DEF_NODE node;

	public Vector3 ofs;

	public int rate;

	public bool isFlip;

	public bool isRot;

	public bool isRotPos;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public bool[] enableElem;

	public PokemonMoveRelativePoke(Macro macro)
	{
	}
}
