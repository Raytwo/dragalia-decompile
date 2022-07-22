using System;
using UnityEngine;

namespace Dpr.Battle.View;

[Serializable]
public struct PfxParam
{
	public const bool DEFAULT_DOF_ENABLED = true;

	public const bool DEFAULT_CHROMATIC_ABERRATION_MAGNIFICATION_ENABLED = false;

	public const float DEFAULT_CHROMATIC_ABERRATION_MAGNIFICATION_DISPERSION = 0f;

	public const bool DEFAULT_RADIAL_BLUR_ENABLED = false;

	public const float DEFAULT_RADIAL_BLUR_CENTER = 0.5f;

	public const float DEFAULT_RADIAL_BLUR_INTENSITY = 0f;

	public const int DEFAULT_RADIAL_BLUR_NUM_SAMPLES = 1;

	public const bool DEFAULT_FEEDBACK_EFFECT_ENABLED = false;

	public const float DEFAULT_FEEDBACK_EFFECT_WEIGHT = 0f;

	public const float DEFAULT_FEEDBACK_EFFECT_ROTATION = 0f;

	public const float DEFAULT_FEEDBACK_EFFECT_SCALE = 1f;

	public const bool DEFAULT_COLOR_CORRECTION_ENABLED = false;

	public const float DEFAULT_HUE = 0f;

	public const float DEFAULT_SATURATION = 1f;

	public const float DEFAULT_BRIGHTNESS = 1f;

	public const float DEFAULT_COLOR_SCALE = 1f;

	public const float DEFAULT_COLOR_BIAS = 0f;

	public const float DEFAULT_CONTRAST = 1f;

	public const float DEFAULT_COLOR_TEMPERATURE = 6500f;

	public const float DEFAULT_SEPIA_TONE_WEIGHT = 0f;

	public const bool DEFAULT_COLOR_INVERSION = false;

	public bool isDofEnabled;

	public Transform dofTarget;

	public float dofFocalLength;

	public float dofFarDepth;

	public float dofDistance;

	public bool isColorFilterEnabled;

	public float colorFilterR;

	public float colorFilterG;

	public float colorFilterB;

	public float colorFilterA;

	public bool isChromaticAberrationMagnificationEnabled;

	public Vector2 chromaticAberrationMagnificationDispersion;

	public bool isRadialBlurEnabled;

	public Vector2 radialBlurCenter;

	public float radialBlurIntensity;

	public int radialBlurNumSamples;

	public bool isFeedbackEffectEnabled;

	public float feedbackEffectWeight;

	public float feedbackEffectRotation;

	public float feedbackEffectScale;

	public float feedbackEffectHue;

	public float feedbackEffectSaturation;

	public float feedbackEffectBrightness;

	public float feedbackEffectContrast;

	public bool isColorCorrectionEnabled;

	public float colorHue;

	public float colorBiasR;

	public float colorBiasG;

	public float colorBiasB;

	public float colorSaturation;

	public float colorContrast;

	public float colorBrightness;

	public float colorScaleR;

	public float colorScaleG;

	public float colorScaleB;

	public float sepiaToneWeight;

	public float colorTemperature;

	public float whiteBalance;

	public float gammaValue;

	public bool colorInversion;

	public void SetDefualt()
	{
	}

	public void SetDefaultColorFilter()
	{
	}

	public void SetDefaultDepthOfField()
	{
	}

	public void SetDefaultChromaticAberrationMagnification()
	{
	}

	public void SetDefaultRadialBlur()
	{
	}

	public void SetDefaultFeedbackBlur()
	{
	}

	public void SetDefaultColorCorrection()
	{
	}

	public static PfxParam Factory()
	{
		return default(PfxParam);
	}
}
