using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DG.Tweening;
using Dpr.UnderGround;
using Dpr.UnderGround.LightStone;
using UnityEngine;
using UnityEngine.UI;

public class UgMiniMapComponent : MonoBehaviour
{
	private class OtherPlayers
	{
		public Image image;

		public RectTransform nowLandMarkIcon;
	}

	private static UgMiniMapComponent _instance;

	private Transform player;

	private RectTransform otherPlayersParent;

	private Image BackGround;

	private RectTransform Mask;

	private RectTransform Waku;

	private RectTransform ButtonGuide;

	[SerializeField]
	private RectTransform MapParent;

	[SerializeField]
	private RectTransform Target;

	[SerializeField]
	private Image TargetFriend;

	[SerializeField]
	private Vector2 _targetSizeOffset;

	[SerializeField]
	private Image MyKasekiIcon;

	[SerializeField]
	private Image OtherKasekiIcon;

	[SerializeField]
	private Image MySecretBaseIcon;

	[SerializeField]
	private Image OtherSecretBaseIcon;

	[SerializeField]
	private Vector2 Offset;

	private ZoneID _nowZone;

	[SerializeField]
	private bool _isPlayerPos;

	private static readonly Vector2 MapMiniSize;

	private bool prevMode;

	private Image[] _randMarkIcon;

	private Image _nowRandMarkIcon;

	[SerializeField]
	private Image[] _mapIamges;

	private Material[] _mapMaterial;

	private OtherPlayers[] _otherPlayers;

	private static readonly Vector2 OverAllOffset;

	private Image PanelEffect;

	private uint OpenLandMarkNum;

	private uint CloseLandMarkNum;

	[SerializeField]
	private UgLightStoneGauge ugLightStoneGauge;

	private RectTransform rectTra_ugLightStoneGauge;

	private CanvasGroup canvasGroup;

	private Tweener tw;

	public Vector2 hosei;

	public bool isOverAllMode
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

	public bool isLargeMode
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

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static void Init()
	{
	}

	private void Initialize()
	{
	}

	public void SetVisible(bool isVisible)
	{
	}

	private void UpdateGoneInfo()
	{
	}

	private void _update(float time)
	{
	}

	public void OnChengeOtherPlayerZone(int index, ZoneID zoneID)
	{
	}

	public void UpdateOtherPlayersPosition(bool isForceUpdate = false)
	{
	}

	public void ToOverAllMap(UgFieldManager.DigData data)
	{
	}

	public void ToAroundMap(UgFieldManager.DigData data)
	{
	}

	private void ToGrayMapGroup(int mapGroupID)
	{
	}

	private void ToWhiteMapGroup(int mapGroupID)
	{
	}

	private bool GetMapGroupGoneFlag(int mapGroupID)
	{
		return default(bool);
	}

	public void ToLarger(UgFieldManager.DigData data)
	{
	}

	public void ToSmaller(UgFieldManager.DigData data)
	{
	}

	public void UpdateDigPoint(UgFieldManager.DigData data)
	{
	}

	public void ChangeVisibleDigPoint(UgFieldManager.DigData data, bool isVisible)
	{
	}

	public void UpdateSecretBase(List<UgFieldManager.SecretBaseModel> SecretBases)
	{
	}

	public void UpdateLandMarkIcons()
	{
	}

	private void SavePlayReport(uint landMarkID)
	{
	}

	public void UpdatePlayerPositionSettings()
	{
	}

	public void OpenLandMark(Image image)
	{
	}

	private IEnumerator WaitFade(Action OnComplete)
	{
		return null;
	}

	public void UpdateZoneID_Offset()
	{
	}

	private Vector2 GetMapOffset(ZoneID zoneID)
	{
		return default(Vector2);
	}

	public void InitAreaGrayScale()
	{
	}

	private bool CheckLandMarkFlag(string MapName)
	{
		return default(bool);
	}

	public void UpdateLightStoneCount()
	{
	}

	public void UpdateBonusState()
	{
	}
}
