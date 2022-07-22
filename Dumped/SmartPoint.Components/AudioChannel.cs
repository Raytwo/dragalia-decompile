using System.Runtime.CompilerServices;
using UnityEngine;

namespace SmartPoint.Components;

public class AudioChannel
{
	private AudioChannelType _type;

	private AudioSource _source;

	private float _volume;

	public AudioClip clip
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public float time
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float volume
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool isPlaying => default(bool);

	public AudioSource source => null;

	public AudioChannelStatus status
	{
		[CompilerGenerated]
		get
		{
			return default(AudioChannelStatus);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float duration
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public float elapsedTime
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public AudioChannel(AudioChannelType type, AudioSource source)
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	public void Pause()
	{
	}

	public void ResetVolume()
	{
	}
}
