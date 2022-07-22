using UnityEngine;

namespace Dpr.SequenceEditor;

public class LightDirectionControl : Macro
{
	public LIGHT_TYPE type;

	public SEQ_DEF_LIGHT_TRG_SIDE trgSide;

	public bool poke;

	public bool gpoke;

	public bool trainer;

	public bool background;

	public bool shadow;

	public Vector3 dir;

	public bool flip;

	public SEQ_DEF_POS flipTrg;

	public LightDirectionControl(Macro macro)
	{
	}
}
