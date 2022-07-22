using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class PoffinNakayoshiScoreHosei : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int NakayoshiRank;

		public float ScoreHosei;

		public float teamworkScore;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
