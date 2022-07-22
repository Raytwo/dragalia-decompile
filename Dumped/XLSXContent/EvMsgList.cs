using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class EvMsgList : ScriptableObject
{
	[Serializable]
	public class Sheetmsg
	{
		public string File;

		public string ID;
	}

	public Sheetmsg[] msg;

	public Sheetmsg this[int index] => null;
}
