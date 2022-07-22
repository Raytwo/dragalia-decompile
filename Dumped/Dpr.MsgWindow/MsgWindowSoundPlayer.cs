using System.Collections.Generic;
using Audio;

namespace Dpr.MsgWindow;

public class MsgWindowSoundPlayer
{
	private Dictionary<int, uint> soundDataTablePtr;

	private bool bIsPlaying;

	private bool bWaiting;

	public bool WaitFinishSE => default(bool);

	public void Setup(MsgWindowDataContainer dataContainer)
	{
	}

	public void Reset()
	{
	}

	public void PlayDecideSE()
	{
	}

	public void PerformCallbackOne(float value)
	{
	}

	private void PlayCallbackSE(uint eventId)
	{
	}

	private void OnFinishCallbackSEPlay(AudioInstance seInstance)
	{
	}
}
