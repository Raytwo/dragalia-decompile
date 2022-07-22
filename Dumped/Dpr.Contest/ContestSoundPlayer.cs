using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Audio;
using UnityEngine;

namespace Dpr.Contest;

public class ContestSoundPlayer
{
	public enum PlaySE_ID
	{
		CheerIntro,
		Cheer_S,
		Cheer_M,
		TapSuccess,
		TapMiss,
		PointHeart,
		PokeHeartM,
		PokeHeartL,
		Point,
		Waza_L,
		Waza_R,
		Waza_SameType,
		Success,
		GaugeFix,
		Rankup,
		DrumRoll1,
		DrumRoll2,
		Medal,
		Num
	}

	public enum PlayLoopSE_ID
	{
		TapLong,
		Gauge,
		Cheer
	}

	public enum StopSE_ID
	{
		TapLong,
		Gauge,
		Cheer
	}

	public static ContestSoundPlayer player;

	private readonly Dictionary<int, uint> PLAY_SE_TABLE;

	private readonly Dictionary<int, uint> PLAY_LOOP_SE_TABLE;

	private readonly Dictionary<int, uint> STOP_SE_TABLE;

	private const float FADE_DURATION = 0.3f;

	private AudioManager audioManager;

	private AudioInstance contestBGMInstance;

	private float diffVolume;

	private float fadeTimer;

	private float currentVolume;

	private float baseVolume;

	private bool playingMusic;

	private bool bFading;

	public bool PlayingMusic => default(bool);

	public static void CreateInstance()
	{
	}

	public static void DestroyInstance()
	{
	}

	private void Initialize()
	{
	}

	private void OnFinalize()
	{
	}

	public static void Stop()
	{
	}

	public void SetBGMVolumeRatio(float ratio)
	{
	}

	public void ResetBGMVolume()
	{
	}

	private void StartBGMFade(float volume)
	{
	}

	private float GetBGMOptionVolume()
	{
		return default(float);
	}

	public void StopBGM()
	{
	}

	public void PlayTitleBgm()
	{
	}

	public void PlayVisualBgm(Action onFinished)
	{
	}

	public void PlayBGM(uint eventId, [Optional] Action onFinished)
	{
	}

	public void PlayResultBGM(bool isBestPerformer)
	{
	}

	public void StopResultBGM(bool isBestPerformer)
	{
	}

	public float GetBGMPlayPosition()
	{
		return default(float);
	}

	public void PlaySeByID(PlaySE_ID seID)
	{
	}

	public void PlayLoopSeByID(PlayLoopSE_ID seID)
	{
	}

	public void PlayTapNoteSE(NoteTapTimingID timingId)
	{
	}

	public void StopSE(StopSE_ID seID)
	{
	}

	public void PlayVoice(string eventName, Vector3 position, Quaternion rotation)
	{
	}

	private void SendAudioEvent(uint seId)
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private float UpdateFadeTimer(float deltaTime)
	{
		return default(float);
	}

	private void SetBGMVolume(float volume)
	{
	}
}
