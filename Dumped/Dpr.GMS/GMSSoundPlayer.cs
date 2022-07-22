using System.Collections.Generic;
using Audio;

namespace Dpr.GMS;

public class GMSSoundPlayer
{
	public enum PlaySE_ID
	{
		Logo,
		Connecting,
		FoundPlayer,
		NotFoundPlayer,
		ZoomIn,
		ZoomOut,
		SnapPoint,
		MarkPoint,
		Decide
	}

	public static GMSSoundPlayer player;

	private readonly Dictionary<int, uint> PLAY_SE_TABLE;

	private AudioManager audioManager;

	public static void CreateInstance()
	{
	}

	public static void DestroyInstance()
	{
	}

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	public void PlaySeByID(PlaySE_ID seID)
	{
	}

	private void SendAudioEvent(uint seId)
	{
	}
}
