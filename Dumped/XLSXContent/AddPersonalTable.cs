using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class AddPersonalTable : ScriptableObject
{
	[Serializable]
	public class SheetAddPersonal
	{
		public bool valid_flag;

		public ushort monsno;

		public ushort formno;

		public bool isEnableSynchronize;

		public byte escape;

		public bool isDisableReverce;
	}

	public SheetAddPersonal[] AddPersonal;

	public SheetAddPersonal this[int index] => null;
}
