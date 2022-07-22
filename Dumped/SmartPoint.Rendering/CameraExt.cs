using UnityEngine;

namespace SmartPoint.Rendering;

public static class CameraExt
{
	public static PostProcessFilter GetPostProcessFilter(this Camera self)
	{
		return null;
	}

	public static T GetImageEffectObject<T>(this Camera self) where T : ImageEffectObject
	{
		return null;
	}
}
