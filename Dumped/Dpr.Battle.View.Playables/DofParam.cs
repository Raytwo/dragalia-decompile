using System;
using Dpr.SequenceEditor;

namespace Dpr.Battle.View.Playables;

[Serializable]
public struct DofParam
{
	public bool depthOfFieldEnable;

	public float focusDistance;

	public float fStop;

	public float focusRegionScale;

	public static DofParam Factory()
	{
		return default(DofParam);
	}

	public static DofParam Factory(EffDepthOfFieldSet other)
	{
		return default(DofParam);
	}
}
