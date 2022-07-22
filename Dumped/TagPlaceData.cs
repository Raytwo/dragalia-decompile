using System;
using UnityEngine;

[CreateAssetMenu]
public class TagPlaceData : ScriptableObject
{
	[Serializable]
	public class TagData
	{
		public string ID;

		public string ParentID;

		public int TagType;
	}

	public TagData[] data;
}
