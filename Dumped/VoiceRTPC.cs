using System;
using UnityEngine;

[CreateAssetMenu]
public class VoiceRTPC : ScriptableObject
{
	[Serializable]
	public class VoiceRTPCData
	{
		public byte[] equalizerValues;

		public byte waveValue;
	}

	[Serializable]
	public class VoiceRTPCDataList
	{
		public string eventName;

		public VoiceRTPCData[] values;

		public float GetEqualizerValue(float rate, int gaugeIndex)
		{
			return default(float);
		}

		public float GetSoundWaveValue(float rate)
		{
			return default(float);
		}
	}

	public VoiceRTPCDataList[] datas;
}
