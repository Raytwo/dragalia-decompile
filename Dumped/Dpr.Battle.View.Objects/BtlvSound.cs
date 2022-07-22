using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;

namespace Dpr.Battle.View.Objects;

public sealed class BtlvSound : BtlvPureObject
{
	private AudioInstance _instance;

	private uint _playEventId;

	private bool _isPerpetuate;

	private Action _onComplete;

	private bool isVoice;

	public bool IsPlaying
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

	public BtlvSound(string name)
	{
	}

	public override void Dispose()
	{
	}

	public void CreateSound(string registerName, bool isVoice = false)
	{
	}

	public static BtlvSound CreatePerpetuateSound(uint playEventId)
	{
		return null;
	}

	public void SetVoiceFlag()
	{
	}

	public void SetSEFlag()
	{
	}

	public bool Register(string name, bool isVoice)
	{
		return default(bool);
	}

	public bool Unregister()
	{
		return default(bool);
	}

	public void SetRTPC(uint trpcName, float value, int interpolationMs)
	{
	}

	public bool SetSwitch(string switchGroup, string switchName)
	{
		return default(bool);
	}

	public bool SetSwitch(uint switchGroup, uint switchName)
	{
		return default(bool);
	}

	private bool CheckAkResult(AKRESULT result)
	{
		return default(bool);
	}

	public INVALID_AUDIO PostEvent(uint postEventId, [Optional] Action onComplete)
	{
		return default(INVALID_AUDIO);
	}

	public INVALID_AUDIO PostEvent(string eventName, [Optional] Action onComplete)
	{
		return default(INVALID_AUDIO);
	}

	public INVALID_AUDIO PostEvent([Optional] Action onComplete)
	{
		return default(INVALID_AUDIO);
	}

	private void OnPostEventComplete(object in_cookie, AkCallbackType in_type, AkCallbackInfo in_info)
	{
	}

	public override void OnUpdatePostJob(float deltaTime)
	{
	}

	protected override void UpdateSRT()
	{
	}

	public override bool IsActive()
	{
		return default(bool);
	}
}
