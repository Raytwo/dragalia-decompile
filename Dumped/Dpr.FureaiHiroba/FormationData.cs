using System.Collections.Generic;
using UnityEngine;

namespace Dpr.FureaiHiroba;

internal class FormationData
{
	private Dictionary<int, List<Vector2>> FormationOffsets;

	public void SetFormationOffsets(int pokeNum, List<Vector2> formation)
	{
	}

	public Vector3 GetOffset(int pokeNum, int positionNo)
	{
		return default(Vector3);
	}
}
