using System.Collections.Generic;
using Ug;
using UnityEngine;

namespace Dpr.Field.Walking;

public class AIUgModel : AIModel
{
	public List<Vector3> entrancePosition;

	public Vector3 InitPos;

	public Ug.MoveType moveType;

	public AIUgModel(UgPokeController controller)
	{
	}

	public override void Destroy()
	{
	}
}
