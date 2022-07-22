using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace SmartPoint.Rendering;

[CreateAssetMenu]
public class DepthOfField : ImageEffectObject
{
	public delegate void OnBuildCallback();

	public delegate void OnRelaseCallback();

	private static readonly int BLUROFFSET_X;

	private static readonly int BLUROFFSET_Y;

	private static readonly int TEMPORARY_RT;

	private static readonly int DEPTH_RT;

	private static readonly int BLUR_TEX;

	private static readonly int STRONGER_BLUR_TEX;

	private static readonly int FOCUS_TEX;

	private static readonly int FOCAL_COEFF;

	public static OnBuildCallback onBuild;

	public static OnRelaseCallback onRelease;

	public static DepthOfField instance;

	private RenderTexture downscaledRT;

	private RenderTexture blurredRT;

	public float farDepth
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float focalLength
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float distance
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float sensorScale
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Vector3 targetOffset
	{
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Camera shootingCamera
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static float blurry
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public RenderTexture renderTexture => null;

	public RenderTexture strongerBlurTexture => null;

	public Material downsampleMaterial => null;

	public Material blurMaterial => null;

	public Vector4 blurOffset => default(Vector4);

	public override CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	public override void Update()
	{
	}

	public override void Destroy()
	{
	}
}
