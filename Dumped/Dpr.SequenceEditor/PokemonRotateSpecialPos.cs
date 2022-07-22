using UnityEngine;

namespace Dpr.SequenceEditor;

public class PokemonRotateSpecialPos : Macro
{
	public SEQ_DEF_POS trgPoke;

	public SEQ_DEF_SPPOS pos;

	public Vector3 ofs;

	public bool isFlip;

	public bool isRot;

	public float rotOfs;

	public SEQ_DEF_MOVETYPE move;

	public PokemonRotateSpecialPos(Macro macro)
	{
	}
}
