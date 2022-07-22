using DPData;
using UnityEngine;

namespace Dpr.SecretBase;

public struct StatueItemData
{
	public int statueId;

	public int pedestalId;

	public int dir;

	public Vector2Int pos;

	public StatueItemData(int statueId)
	{
	}

	public StatueItemData(UgStoneStatue saveData)
	{
	}

	public UgStoneStatue ToSaveData()
	{
		return default(UgStoneStatue);
	}
}
