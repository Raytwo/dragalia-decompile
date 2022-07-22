using System;
using Effect;
using UnityEngine;

namespace Dpr.SubContents;

[Serializable]
public class BindModelEffect
{
	public bool StartActive;

	public Transform parent;

	public string EffectName;

	[NonSerialized]
	public EffectData EffData;

	public EffectFieldID GetEffectID()
	{
		return default(EffectFieldID);
	}

	public void Destroy()
	{
	}
}
