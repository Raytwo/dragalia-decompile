using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class EffectPosData
{
	public int MstID;

	public string Name;

	public List<string> Path;

	public List<Vector3> Position;

	public List<Vector3> Angles;

	public EffectPosData(int mstID)
	{
	}
}
