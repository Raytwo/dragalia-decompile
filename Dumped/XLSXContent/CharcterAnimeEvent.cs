using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class CharcterAnimeEvent : ScriptableObject
{
	[Serializable]
	public class SheetanimeEvent
	{
		public int frame;

		public CharacterAnimEventMethod[] method;

		public int intparam;
	}

	public SheetanimeEvent[] animeEvent;

	public SheetanimeEvent this[int index] => null;
}
