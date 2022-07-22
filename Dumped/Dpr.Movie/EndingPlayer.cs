using System.Collections;
using Dpr.Message;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Dpr.Movie;

public class EndingPlayer : MonoBehaviour
{
	private enum EndingState
	{
		None,
		PlayingMovie,
		WaitInput,
		End
	}

	private RawImage _fadeImage;

	private UnityAction _endCallback;

	private StaffrollPlayer _staffrollPlayer;

	private EndingState _state;

	private float _timeCounter;

	private bool _enableSkip;

	private const float _waitInputTime = 0f;

	private bool _diaVersion;

	private MessageEnumData.MsgLangId _lang;

	private bool _male;

	private int _bodyType;

	private MoviePlayer _moviePlayer;

	private string _moviePath;

	private string _logoPath;

	private string _endTextPath;

	private bool _isLoadedAssets;

	public void Initialize(MoviePlayer moviePlayer, bool diaVersion, MessageEnumData.MsgLangId lang, bool male, int bodyType, RawImage fadeImage, UnityAction endCallback, StaffrollPlayer staffrollPlayer)
	{
	}

	private IEnumerator LoadAssets()
	{
		return null;
	}

	private void UnloadAssets()
	{
	}

	public void Play()
	{
	}

	public IEnumerator PlayEnding()
	{
		return null;
	}

	private IEnumerator EndEnding()
	{
		return null;
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private string GetMoviePath()
	{
		return null;
	}

	private void GetLogoPath(out string path, out string name)
	{
	}

	private void GetEndTextPath(out string path, out string name)
	{
	}

	private void PlayBGM()
	{
	}

	private void StopBGM()
	{
	}
}
