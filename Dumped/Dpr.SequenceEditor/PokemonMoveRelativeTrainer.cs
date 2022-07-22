using UnityEngine;

namespace Dpr.SequenceEditor;

public class PokemonMoveRelativeTrainer : Macro
{
	public SEQ_DEF_POS moveTrg;

	public SEQ_DEF_TRAINER trg;

	public string node;

	public Vector3 pos;

	public bool isRot;

	public bool forceUpdate;

	public SEQ_DEF_MOVETYPE move;

	public PokemonMoveRelativeTrainer(Macro macro)
	{
	}
}
