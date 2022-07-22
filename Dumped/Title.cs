using System.Collections;
using Dpr.Message;
using Dpr.Movie;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class Title : MonoBehaviour
{
	[SerializeField]
	public bool forceEndingPlay;

	[SerializeField]
	public bool forceMovieLangSetting;

	[SerializeField]
	public MessageEnumData.MsgLangId forceMovieLang;

	[SerializeField]
	public bool forceVersionSetting;

	[SerializeField]
	public bool forceDiamondVersion;

	[SerializeField]
	public bool forceMaleSetting;

	[SerializeField]
	public bool forceMale;

	[SerializeField]
	public bool forceSkinTypeSetting;

	[SerializeField]
	public int forceSkinType;

	public GameObject movieRendereObject;

	public RawImage fadeImage;

	public StaffrollPlayer staffrollPlayer;

	private bool _diaVersion;

	private MessageEnumData.MsgLangId _lang;

	private bool _male;

	private int _skinType;

	private MoviePlayer _moviePlayer;

	private TitlePlayer titlePlayer;

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	private void Uninitialize()
	{
	}

	private void PlayOpeningSequence()
	{
	}

	private void PlayEndingSequence()
	{
	}

	private void OnFinishedOpening(int type)
	{
	}

	private void EndTitle()
	{
	}

	private void PlayBackUpSequence()
	{
	}

	private void OpenDialog(string file, string label, UnityAction closeCallback)
	{
	}

	private void SaveDataErrorDialog()
	{
	}

	private IEnumerator PlayNowLoading(bool useBackupData, bool isErrorSaveData = false, MessageEnumData.MsgLangId unloadLangId = (MessageEnumData.MsgLangId)0)
	{
		return null;
	}
}
