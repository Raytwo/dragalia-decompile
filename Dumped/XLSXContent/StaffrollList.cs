using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class StaffrollList : ScriptableObject
{
	[Serializable]
	public class SheetStaffroll
	{
		public int Type;

		public string Left1;

		public string Left2;

		public string CenterLeft;

		public string Center;

		public string CenterRight;

		public string Right1;

		public string Right2;

		public float Time;

		public float Size;

		public float Speed;

		public bool Heading;

		public float Offset;
	}

	public SheetStaffroll[] Staffroll;

	public SheetStaffroll this[int index] => null;
}
