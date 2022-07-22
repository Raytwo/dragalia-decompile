using System;
using UnityEngine;

namespace Dpr.Message;

[Serializable]
public class FontMaterialProperty
{
	[SerializeField]
	public string name;

	[SerializeField]
	public bool useFace;

	[SerializeField]
	public Color faceColor;

	[SerializeField]
	public float faceSoftness;

	[SerializeField]
	public float faceDilate;

	public static readonly int PropFaceColor;

	public static readonly int PropOutlineSoftness;

	public static readonly int PropFaceDilate;

	[SerializeField]
	public bool useOutline;

	[SerializeField]
	public Color outlineColor;

	[SerializeField]
	public float outlineThickness;

	public static readonly int PropOutlineColor;

	public static readonly int PropOutlineWidth;

	[SerializeField]
	public bool useGlow;

	[SerializeField]
	public Color glowColor;

	[SerializeField]
	public float glowOffset;

	[SerializeField]
	public float glowInner;

	[SerializeField]
	public float glowOuter;

	[SerializeField]
	public float glowPower;

	public static readonly int PropGlowColor;

	public static readonly int PropGlowOffset;

	public static readonly int PropGlowInner;

	public static readonly int PropGlowOuter;

	public static readonly int PropGlowPower;

	[SerializeField]
	public bool useUnderlay;

	[SerializeField]
	public Color underlayColor;

	[SerializeField]
	public float underlayOffsetX;

	[SerializeField]
	public float underlayOffsetY;

	[SerializeField]
	public float underLayDilate;

	[SerializeField]
	public float underlaySoftness;

	public static readonly int PropUnderlayColor;

	public static readonly int PropUnderlayOffsetX;

	public static readonly int PropUnderlayOffsetY;

	public static readonly int PropUnderlayDilate;

	public static readonly int PropUnderlaySoftness;

	[SerializeField]
	public bool useDebugSetting;

	[SerializeField]
	public float debugSettingGradientScale;

	[SerializeField]
	public float debugSettingSharpness;

	public static readonly int PropDebugSettingGradientScale;

	public static readonly int PropDebugSettingSharpness;
}
