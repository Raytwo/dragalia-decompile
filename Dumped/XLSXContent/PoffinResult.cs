using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class PoffinResult : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public int MstID;

		public string LabelName;

		public int LabelID;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
