using System;
using System.Collections;
using Audio;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.UI;

public class ZukanMovingWindow : UIWindow
{
	[Serializable]
	private class RepeatParam
	{
		public Image image;

		public Sprite[] sprites;

		[NonSerialized]
		public float delayTime;

		public bool isRepeat => default(bool);

		public void Setup()
		{
		}

		public void SetRepeat(bool enabled)
		{
		}
	}

	public class Param
	{
		public PokemonParam pokemonParam;
	}

	public class AudioEffectParam
	{
		public float chorus;

		public float pan;

		public float filter;

		public float reverb;
	}

	[SerializeField]
	private PokemonModelView _modelView;

	[SerializeField]
	private ZukanMovingEqualizer _equalizer;

	[SerializeField]
	private ZukanMovingSoundWave _soundWave;

	[SerializeField]
	private ZukanMovingPan _pan;

	[SerializeField]
	private ZukanMovingChorus _chorus;

	[SerializeField]
	private ZukanMovingFilter _filter;

	[SerializeField]
	private RepeatParam _repeat;

	private AudioInstance _voiceInstance;

	private bool _animPaused;

	private Param _param;

	private UIDatabase.SheetPokemonVoice _voiceData;

	public AudioEffectParam _saveAudioEffectParam;

	public override void OnCreate()
	{
	}

	public void Open(Param param, UIWindowID prevWindowId)
	{
	}

	public IEnumerator OpOpen(Param param, UIWindowID prevWindowId)
	{
		return null;
	}

	private void SetupKeyguide()
	{
	}

	private void SaveAudioEffectParam()
	{
	}

	private void RestoreAudioEffectParam()
	{
	}

	public void Close(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
	}

	public IEnumerator OpClose(UnityAction<UIWindow> onClosed_, UIWindowID nextWindowId)
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void UpdateVoice(float deltaTime, bool isRepeatChecked = true)
	{
	}

	private void PlayVoice()
	{
	}
}
