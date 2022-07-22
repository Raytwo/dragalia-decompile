using UnityEngine;

namespace Dpr.SequenceEditor;

public class Sound3DFollowModel : Macro
{
	public SEQ_DEF_FOLLOW type;

	public int grpNo;

	public string node;

	public bool isPos;

	public bool isRot;

	public bool isScl;

	public Vector3 pos;

	public Vector3 rot;

	public Sound3DFollowModel(Macro macro)
	{
	}
}
