using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIBrowsingPointHistoryDataItem : AUIGMSScrollItem
{
	[SerializeField]
	private Image selectBGImage;

	[SerializeField]
	private Image sendMonsIconImage;

	[SerializeField]
	private Image receiveMonsIconImage;

	[SerializeField]
	private Image receiveSexIconImage;

	[SerializeField]
	private Image receiveMonsLanguageImage;

	[SerializeField]
	private Image receiveMonsParentLanguageImage;

	[SerializeField]
	private Image newIconImage;

	[SerializeField]
	private UIText historyTitleText;

	[SerializeField]
	private UIText receiveMonsNicknameText;

	[SerializeField]
	private UIText receiveMonsParentNameText;

	public void ShowHistoryDataItem(string title, string monsNickname, string parentName, Sprite sendMonsIconSpr, Sprite receiveMonsIconSpr, Sprite receiveSexIconSpr, Sprite receiveMonsLanguageSpr, Sprite receiveParentLanguageSpr, bool isNew)
	{
	}

	public void ShowEmptyDataItem(string emptyStr)
	{
	}

	private void SetNewImageEnabled(bool enabled)
	{
	}

	private void SetSprite(Image target, Sprite spr)
	{
	}

	protected override void OnSelect()
	{
	}

	protected override void OnUnSelect()
	{
	}
}
