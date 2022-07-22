using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class DebugAudioDatabase : ScriptableObject
{
	[Serializable]
	public class SheetState
	{
		public string NAME;

		public float STATEID;
	}

	public SheetState[] State;

	public SheetState this[int index] => null;
}
