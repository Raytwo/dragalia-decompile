using System.Collections.Generic;
using UnityEngine;

public abstract class AkObstructionOcclusion : MonoBehaviour
{
	protected class ObstructionOcclusionValue
	{
		public float currentValue;

		public float targetValue;

		public bool Update(float fadeRate)
		{
			return default(bool);
		}
	}

	private readonly List<AkAudioListener> listenersToRemove;

	protected readonly List<AkAudioListener> currentListenerList;

	private readonly Dictionary<AkAudioListener, ObstructionOcclusionValue> ObstructionOcclusionValues;

	protected float fadeRate;

	public float fadeTime;

	public LayerMask LayerMask;

	public float maxDistance;

	public float refreshInterval;

	private float refreshTime;

	protected void InitIntervalsAndFadeRates()
	{
	}

	protected abstract void UpdateCurrentListenerList();

	private void UpdateObstructionOcclusionValues()
	{
	}

	private void CastRays()
	{
	}

	protected abstract void SetObstructionOcclusion(KeyValuePair<AkAudioListener, ObstructionOcclusionValue> ObsOccPair);

	private void Update()
	{
	}
}
