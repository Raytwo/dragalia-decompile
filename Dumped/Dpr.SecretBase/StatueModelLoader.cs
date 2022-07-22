using System;
using System.Collections.Generic;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.SecretBase;

public class StatueModelLoader : MonoBehaviour
{
	[SerializeField]
	private PetrifyData petrifyData;

	private Shader petrifyShader;

	private Shader petrifyFireShader;

	private List<string> histories;

	private void OnEnable()
	{
	}

	public void AppendRequest(StatueEffectData statue, Action<GameObject> onLoadCompleted)
	{
	}

	public AssetRequestOperation DispatchRequests()
	{
		return null;
	}

	public void UnloadHistories()
	{
	}

	public void Load(StatueEffectData statue, Transform parent, Action<GameObject> onLoadCompleted)
	{
	}
}
