using System;
using System.Collections;
using Dpr.Message;
using UnityEngine;
using UnityEngine.UI;
using XLSXContent;

namespace Dpr.Movie;

public class TitlePlayer : MonoBehaviour
{
	private enum TitleState
	{
		None,
		PlayingMovie,
		WaitEndMovie,
		WaitDisplayTitle,
		DisplayTitle,
		WaitEndTitle,
		End
	}

	private enum MovieType
	{
		Opening,
		Title,
		Max
	}

	[SerializeField]
	public GameObject _titleUiCanvas;

	[SerializeField]
	public Image _logoImage;

	[SerializeField]
	public Image _pushImage;

	[SerializeField]
	public TitleSettings _settings;

	private int _settingIndex;

	private RawImage _fadeImage;

	private Action<int> _endCallback;

	private TitleState _state;

	private bool _repeat;

	private bool _isPressedBackupCommand;

	private float _timeCounter;

	private const float _waitInputTime = 25f;

	private bool _isDisplayTitleUI;

	private float _pushMessageTimeCounter;

	private const float _pushMessageBlinkTime = 2f;

	private bool _diaVersion;

	private MessageEnumData.MsgLangId _lang;

	private bool _isLoadedAssets;

	private MoviePlayer _moviePlayer;

	private string[] _moviePath;

	private string[] _logoPath;

	private string[] _pushTextPath;

	private WaitForSeconds _wait02sec;

	private WaitForSeconds _wait1sec;

	private WaitForSeconds _wait2sec;

	public void Initialize(MoviePlayer moviePlayer, bool diaVersion, MessageEnumData.MsgLangId lang, RawImage fadeImage, Action<int> endCallback)
	{
	}

	public IEnumerator LoadAsset()
	{
		return null;
	}

	private void UnloadAsset()
	{
	}

	public void Play()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private IEnumerator PlayOpening()
	{
		return null;
	}

	private IEnumerator EndOpening()
	{
		return null;
	}

	private IEnumerator PlayTitle(bool fadeIn)
	{
		return null;
	}

	private IEnumerator EndTitle()
	{
		return null;
	}

	private void PlayMovie(MovieType type, bool loop)
	{
	}

	private void EndMovie()
	{
	}

	private bool IsPlayingMovie()
	{
		return default(bool);
	}

	private void PlayOpeningBGM()
	{
	}

	private void PlayTitleBGM()
	{
	}

	private void StopBGM()
	{
	}

	private void PlaySE()
	{
	}

	private string GetOpeningMoviePath()
	{
		return null;
	}

	private string GetTitleMoviePath()
	{
		return null;
	}

	private void GetLogoPath(out string path, out string name)
	{
	}

	private void GetPushTextImagePath(out string path, out string name)
	{
	}
}
