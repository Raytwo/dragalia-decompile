using System;
using System.Collections.Generic;
using UnityEngine;

namespace Dpr.Battle.View.Systems;

public sealed class BattleShadowCastSystem : IDisposable
{
	private const string SHADOW_CAST_SHADER_NAME = "Dpr/Objects/ShadowCast";

	public const string SHADOW_CAST_OBJECT_LAYER_NAME = "Field";

	private List<ShadowCastObject> _castObjects;

	private Material _shadowCastMaterial;

	private bool _isDraw;

	public bool IsDraw
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public void Dispose()
	{
	}

	public void Register(ShadowCastObject shadowCastObject)
	{
	}

	public void OnLateUpdate(float deltaTime)
	{
	}
}
