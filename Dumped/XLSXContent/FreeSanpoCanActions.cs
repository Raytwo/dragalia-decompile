using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class FreeSanpoCanActions : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int PokeID;

		public bool IsCanRun;

		public bool IsCanSleepAnimation;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
