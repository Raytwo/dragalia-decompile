using System.Collections;
using Dpr.Message;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.U2D;
using UnityEngine.UI;

namespace Dpr.UI;

public class UICard : UIWindow
{
	public class Param
	{
		public bool IsShowBadgeCase;

		public int CardRank;

		public byte PlayerFashion;

		public byte PlayerBodyType;

		public bool PlayerSex;

		public uint PlayerId;

		public PlayerNameData PlayerNameData;

		public int Money;

		public bool IsGetZukan;

		public int ZukanSeeCount;

		public ushort PlayTimeHour;

		public ushort PlayTimeMinute;

		public long StartTime;

		public uint ClearTime;

		public uint ContestStyleRank;

		public uint ContestBeatifulRank;

		public uint ContestCuteRank;

		public uint ContestCleverRank;

		public uint ContestStrongRank;

		public uint TowerRenshouSingle;

		public uint TowerRenshouDouble;

		public uint TowerRenshouMasterSingle;

		public uint TowerRenshouMasterDouble;

		public int PoffinCookingCount;

		public short DigFossilPlayCount;

		public int HaveStatueKindNum;
	}

	private const string CardImageSpriteNameFormat = "prf_pl_card_01_{0:00}_{1:00}";

	private const string TitleImageSpriteNameFormat = "prf_txt_title_01_{0:00}";

	private const string FrontCover1ImageSpriteNameFormat = "prf_pl_card_01_{0:00}_01_parts_01";

	private const string FrontCover2ImageSpriteNameFormat = "prf_pl_card_01_{0:00}_01_parts_02";

	[SerializeField]
	private SpriteAtlas cardSpriteAtlas;

	[SerializeField]
	private RectTransform bgImageRectTransform;

	[SerializeField]
	private GameObject cardWindowObject;

	[SerializeField]
	private GameObject badgeCaseIconObject;

	[SerializeField]
	private GameObject modelViewPrefab;

	[SerializeField]
	private CardFrontView cardFrontView;

	[SerializeField]
	private CardBackView cardBackView;

	[SerializeField]
	private RawImage modelViewRawImage;

	[SerializeField]
	private CardAnimationController animationController;

	[SerializeField]
	private Image badgeCaseIconImage;

	[SerializeField]
	private Sprite diamondBadeCaseIconSprite;

	[SerializeField]
	private Sprite pearlBadeCaseIconSprite;

	[SerializeField]
	private float PlayerModelRotateValue;

	private readonly int _animStateIn;

	private readonly int _animStateOut;

	private GameObject modelViewObject;

	private CardModelViewController modelViewController;

	private bool isWaitUpdate;

	private Param param;

	public override void OnCreate()
	{
	}

	public void Open(UIWindowID prevWindowId)
	{
	}

	public void Open(Param param, UIWindowID prevWindowId = (UIWindowID)(-2))
	{
	}

	public IEnumerator OpOpen(UIWindowID prevWindowId)
	{
		return null;
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

	private void OnUpdateTrainerCard(float deltaTime)
	{
	}

	private void OnUpdateBadgeCase(float deltaTime)
	{
	}

	private void UpdateKeyGuide()
	{
	}

	private void SetupCardImage(int rank)
	{
	}

	private void SetupBadgeCaseIcon()
	{
	}

	private void ShowPlayerModel()
	{
	}

	private void ShowBadgeCase()
	{
	}

	public void SetTextFront(uint id, PlayerNameData nameData, int money, int zukanCount, ushort playTimeHour, ushort playTimeMinute, long startTime, uint clearTime)
	{
	}

	public void SetTextBackContest(uint styleRank, uint beatifulRank, uint cuteRank, uint cleverRank, uint strongRank)
	{
	}

	public void SetTextBackTower(uint singleRenshouCount, uint doubleRenshouCount, uint masterSingleRenshouCount, uint masterDoubleRenshouCount)
	{
	}

	public void SetTextBackOther(int cookingCount, int fossilCount, int statueCount)
	{
	}
}
