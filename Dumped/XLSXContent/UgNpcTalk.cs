using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class UgNpcTalk : ScriptableObject
{
	[Serializable]
	public class SheetSheet1
	{
		public ushort TalkId;

		public bool IsPatch;

		public string MaleTalkLabel;

		public string FemaleTalkLabel;
	}

	public SheetSheet1[] Sheet1;

	public SheetSheet1 this[int index] => null;
}
