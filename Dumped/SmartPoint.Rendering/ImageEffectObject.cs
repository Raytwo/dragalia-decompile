using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering;

namespace SmartPoint.Rendering;

[Serializable]
public class ImageEffectObject : ScriptableObject
{
	[SerializeField]
	private Material[] materials;

	protected Material[] materialInstances;

	private int initializedCount;

	public RenderTexture temporaryRT
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

	public bool enabled
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Camera camera
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

	public Transform target
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

	public virtual CommandBuffer Build(RenderTargetIdentifier sourceRT, out RenderTargetIdentifier resultRT, bool feedbackCameraTarget = true)
	{
		return null;
	}

	protected void InstantiateMaterials()
	{
	}

	public virtual void Update()
	{
	}

	public virtual void Destroy()
	{
	}
}
