using System.Collections.Generic;
using Audio;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanMovingEqualizer : MonoBehaviour
{
	private class HeadParam
	{
		public Image image;
	}

	[SerializeField]
	private RectTransform _levelRoot;

	[SerializeField]
	private RectTransform _headRoot;

	private List<Image[]> _levelGauges;

	private List<HeadParam> _headParams;

	private float _headMinPosY;

	private const float _minDecibel = -48f;

	private const float _maxDecibel = 0f;

	private VoiceRTPC.VoiceRTPCDataList _voiceRtpcData;

	private uint[] _gameParamIds;

	private void Awake()
	{
	}

	public void Setup(VoiceRTPC.VoiceRTPCDataList voiceRtpcData)
	{
	}

	public void OnUpdate(float deltaTime, AudioInstance audioInstance)
	{
	}

	private void UpdateLevels(AudioInstance audioInstance)
	{
	}

	private float GetRTPCValue(AudioInstance audioInstance, uint paramId, int gaugeIndex)
	{
		return default(float);
	}

	private float ToLevelValue(float value, float min = -48f, float max = 0f)
	{
		return default(float);
	}

	private void SetLevelValue(int level, float value)
	{
	}

	private void UpdateHeads(float deltaTime)
	{
	}
}
