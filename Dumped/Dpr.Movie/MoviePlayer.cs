using UnityEngine;
using UnityEngine.Switch;
using UnityEngine.UI;
using UnityEngine.Video;

namespace Dpr.Movie;

public class MoviePlayer : MonoBehaviour
{
	[SerializeField]
	public Material movieMaterial;

	private VideoPlayer _videoPlayer;

	private SwitchVideoPlayer _switchVideoPlayer;

	private SwitchFMVTexture _lumaTex;

	private SwitchFMVTexture _chromaTex;

	private const int ResX = 1280;

	private const int ResY = 720;

	private RawImage _rendererImage;

	private bool _isPlaying;

	private bool isUpdateVideoOnThisFrame;

	public void Initialize(GameObject rendererObject)
	{
	}

	public void Uninitialize()
	{
	}

	public void PlayStreaming(string path, bool loop = false)
	{
	}

	public void Stop()
	{
	}

	public bool IsPlaying()
	{
		return default(bool);
	}

	public float GetTime()
	{
		return default(float);
	}

	public float GetLength()
	{
		return default(float);
	}

	public void JumpTo(float sec)
	{
	}

	public bool IsLoop()
	{
		return default(bool);
	}

	private void Update()
	{
	}

	private void OnRenderObject()
	{
	}

	private void OnMovieEvent(SwitchVideoPlayer.Event FMVevent)
	{
	}

	private void InitializeEditor(RawImage image, VideoPlayer videoPlayer)
	{
	}

	private void UninitializeEditor()
	{
	}

	private void UpdateEditor()
	{
	}

	private void PlayStreamingEditor(string path, bool loop)
	{
	}

	private void StopEditor()
	{
	}

	private bool IsPlayingEditor()
	{
		return default(bool);
	}

	private float GetTimeEditor()
	{
		return default(float);
	}

	private float GetLengthEditor()
	{
		return default(float);
	}

	private void JumpToEditor(float sec)
	{
	}

	private bool IsLoopEditor()
	{
		return default(bool);
	}

	private void InitializeSwitch(RawImage image)
	{
	}

	private void UninitializeSwitch()
	{
	}

	private void UpdateSwitch()
	{
	}

	private void PlayStreamingSwitch(string path, bool loop)
	{
	}

	private void StopSwitch()
	{
	}

	private bool IsPlayingSwitch()
	{
		return default(bool);
	}

	private float GetTimeSwitch()
	{
		return default(float);
	}

	private float GetLengthSwitch()
	{
		return default(float);
	}

	private void JumpToSwitch(float sec)
	{
	}

	private bool IsLoopSwitch()
	{
		return default(bool);
	}
}
