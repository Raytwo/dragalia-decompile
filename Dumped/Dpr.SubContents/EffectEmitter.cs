using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Effect;
using UnityEngine;

namespace Dpr.SubContents;

public class EffectEmitter
{
	private class EmitEffectData
	{
		private EffectManager effectManagerPtr;

		private Transform effectManagerTransform;

		private EffectData fxData;

		private EffectInstance[] fxInstArray;

		private Transform parent;

		private int useCount;

		private int emptyIndex;

		public bool HasEmptyIndex => default(bool);

		public void Setup(Transform parent, EffectManager effectManager, EffectData fxData, int count)
		{
		}

		public EffectInstance PlayFx(Vector3 emitPos, Action onComplete)
		{
			return null;
		}

		public void StopFx(float fadeTime = 0f)
		{
		}

		public void ReleaseAll()
		{
		}

		private int FindEmptyIndex()
		{
			return default(int);
		}
	}

	private Dictionary<int, EmitEffectData> fxTable;

	private EffectManager fxManager;

	private int loadCount;

	private int loadedCount;

	private bool bReady;

	public bool IsReady => default(bool);

	public void Initialize(Transform fxParent, EmitEffectParam[] loadEffectIDArray)
	{
	}

	public void OnFinalize()
	{
	}

	public void LoadFx(EmitEffectParam param, Transform fxParent, [Optional] Action onCompletedLoad)
	{
	}

	private void OnCompleteLoad()
	{
	}

	public EffectInstance PlayFx(EffectContestID fxID, Vector3 emitPos, [Optional] Action onComplete)
	{
		return null;
	}

	public void StopFx(EffectContestID fxID, float fadeTime = 0f)
	{
	}
}
