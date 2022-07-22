using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TowerBattlePoint : ScriptableObject
{
	[Serializable]
	public class Sheetpoint
	{
		public int[] BattlePoint;
	}

	public Sheetpoint[] point;

	public Sheetpoint this[int index] => null;
}
