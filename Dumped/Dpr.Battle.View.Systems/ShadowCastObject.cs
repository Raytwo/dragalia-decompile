using System.Runtime.CompilerServices;
using SmartPoint.AssetAssistant.UnityExtensions;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.Battle.View.Systems;

public struct ShadowCastObject
{
	public static readonly string[] PROCESS_SHADER_NAMES;

	public Transform originObject
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

	public Renderer[] renderers
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

	public ShadowCastingMode[] initializeModes
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

	public bool isDelete
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

	public Pair<Renderer, Renderer>[] linkRenderes
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

	public static ShadowCastObject Factory(Transform originObject, Renderer[] renderers)
	{
		return default(ShadowCastObject);
	}

	public void Initialize(Material shadowCastMaterial)
	{
	}

	public void UnInitialize()
	{
	}

	public void SetDraw(bool isDraw)
	{
	}

	public void Draw()
	{
	}
}
