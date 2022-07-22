using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Effect;
using UnityEngine;

namespace Dpr.Battle.View.Objects;

public sealed class BattleModelParticleEntity : EffectActivator
{
	[SerializeField]
	[SearchableEnum]
	private EffectBattleID _effectBattleId;

	[SerializeField]
	private EffectInstance _effectInstance;

	private static Dictionary<int, EffectData> _effectDataDic;

	private EffectData _effectData;

	public bool IsLoaded
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public EffectBattleID EffectBattleId => default(EffectBattleID);

	private bool isManualEffectDataRelease => default(bool);

	protected override IEnumerator OnActivateOperation()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	public void Play([Optional] Action onComplete)
	{
	}

	public void Stop(float fadeTime = 0f)
	{
	}

	public static void ReleaseEffectData()
	{
	}
}
