using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.Battle.View.Systems;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.Battle.View;

public sealed class BattleViewCore : SingletonMonoBehaviour<BattleViewCore>
{
	[SerializeField]
	private Material _shadowCastMaterial;

	private Transform _cluster;

	public BattleViewSystem ViewSystem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public BattleViewUISystem UISystem
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public Transform Cluster => null;

	public Material ShadowCastMaterial => null;

	private void OnDestroy()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void OnLateUpdate(float deltaTime)
	{
	}

	private void OnResume(int value)
	{
	}

	public IEnumerator InitializeSystem(BattleViewSystem pViewSystem)
	{
		return null;
	}
}
