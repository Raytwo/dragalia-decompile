using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class PokeWalkingActionNakayoshi : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int NakayoshiRank;

		public float PositionHosei;

		public float SpeedDownStartDistanceHosei;

		public float SpeedDownEndDistanceHosei;

		public float WalkStartDistanceHosei;

		public float RunStartDistanceHosei;

		public float KutibueSpeedHosei;

		public int StopKakurituHosei;

		public int KyoroKakurituHosei;

		public int LookOtherPokeKakurituHosei;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
