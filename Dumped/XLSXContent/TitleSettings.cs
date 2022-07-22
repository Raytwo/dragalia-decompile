using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class TitleSettings : ScriptableObject
{
	[Serializable]
	public class SheetStaffroll
	{
		public float LogoX;

		public float LogoY;

		public float LogoScale;

		public float TextX;

		public float TextY;

		public float TextScale;
	}

	public SheetStaffroll[] Staffroll;

	public SheetStaffroll this[int index] => null;
}
