using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Audio;
using Dpr.Message;
using Pml.PokePara;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class ZukanDescriptionPanel : MonoBehaviour
{
	private const float MoveDuration = 0.3f;

	private const float FadeDuration = 0.2f;

	[SerializeField]
	private UIButtonSelector languageButtonSelector;

	[SerializeField]
	private ZukanPokemonInfoButton pokemonInfoButton;

	[SerializeField]
	private Image pokemonMaleIconImage;

	[SerializeField]
	private Image pokemonFemaleIconImage;

	[SerializeField]
	private Image pokemonRareIconImage;

	[SerializeField]
	private GameObject arrowUpDownObject;

	[SerializeField]
	private GameObject arrowLeftRightObject;

	[SerializeField]
	private RectTransform arrowUpRectTransform;

	[SerializeField]
	private RectTransform arrowDownRectTransform;

	[SerializeField]
	private RectTransform arrowLeftRectTransform;

	[SerializeField]
	private RectTransform arrowRightRectTransform;

	[SerializeField]
	private UIText classText;

	[SerializeField]
	private TypePanel typePanel1;

	[SerializeField]
	private TypePanel typePanel2;

	[SerializeField]
	private UIText heightValueText;

	[SerializeField]
	private UIText weightValueText;

	[SerializeField]
	private UIText descriptionText;

	[SerializeField]
	private Image footprintImage;

	[SerializeField]
	private GameObject footprintObject;

	[SerializeField]
	private Image fadeImage;

	[SerializeField]
	private PokemonModelView modelView;

	[SerializeField]
	private Image unknownModelImage;

	[SerializeField]
	private RawImage modelViewRawImage;

	[SerializeField]
	private RectTransform modelViewRectTransform;

	[SerializeField]
	private RectTransform modelViewOnlyPositionRectTransform;

	[SerializeField]
	private GameObject pokemonInfoButtonObject;

	[SerializeField]
	private CanvasGroup pokemonInfoButtonCanvasGroup;

	[SerializeField]
	private CanvasGroup pokemonInfoButtonGenderIconCanvasGroup;

	[SerializeField]
	private GameObject hideObject;

	[SerializeField]
	private Image bgImage;

	[SerializeField]
	private Image bgHeadImage;

	[SerializeField]
	private Sprite[] bgHeadSprites;

	[SerializeField]
	private GameObject formObject;

	[SerializeField]
	private UIText formText;

	[SerializeField]
	private GameObject modelViewFrameObject;

	[SerializeField]
	private Image modelViewBgImage;

	[SerializeField]
	private UIText[] changeLanguageTexts;

	private Vector2 hideModelViewPosition;

	private Vector2 hideInfoButtonPosition;

	private ZukanInfo[] zukanInfos;

	private IndexSelector zukanInfoIndexSelector;

	private AudioInstance currentVoiceInstance;

	public ZukanInfo CurrentZukanInfo
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsTweening
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

	public bool IsShow
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

	public bool IsModelViewOnly
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

	public bool CanSwitchLanguage
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

	public bool CanShowMoving => default(bool);

	public bool CanShowCompare => default(bool);

	public void Initialize()
	{
	}

	public void Dispose()
	{
	}

	public void SetZukanInfos(ZukanInfo[] infos)
	{
	}

	public Vector3 GetModelViewPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetInfoButtonPosition()
	{
		return default(Vector3);
	}

	public void SetArrowsActive(bool isUpDownActive, bool isLeftRightActive)
	{
	}

	public void SetBgHead(bool isZenkoku)
	{
	}

	public void OnUpdateModelView(float deltaTime, UIInputController input)
	{
	}

	public void SetHidePositions(Vector2 modelViewPos, Vector2 infoButtonPos)
	{
	}

	public void Set(ZukanPokemonInfoButton button)
	{
	}

	public void Set(ZukanInfo zukanInfo, bool isAllowSwitchLanguage = true)
	{
	}

	public void SetUnknownModelView()
	{
	}

	public void SetModelView(PokemonParam pokemonParam, bool isPlayVoice = false)
	{
	}

	public void ShowDescription(bool isImmidiate = false, bool isMoveInfoButton = true, [Optional] Action onCompleteAction)
	{
	}

	public void HideDescription(bool isImmidiate = false, bool isHideBg = true, bool isMoveInfoButton = true, [Optional] Action onCompleteAction)
	{
	}

	public void ShowModelViewOnly([Optional] Action onCompleteAction)
	{
	}

	public void HideModelViewOnly([Optional] Action onCompleteAction)
	{
	}

	public void UpdateAshiatoIcon()
	{
	}

	public bool MoveLanguageButtonSelect(int value)
	{
		return default(bool);
	}

	public void ResumeLanguageButtonSelect()
	{
	}

	public bool MoveZukanInfoSelect(int addValue)
	{
		return default(bool);
	}

	public void ResumeZukanInfoSelect()
	{
	}

	public bool MoveCatalogSelect(int addValue)
	{
		return default(bool);
	}

	private void SetupLanguageButtons()
	{
	}

	private void UpdateLanguageButtons()
	{
	}

	private void OnSelectLanguageButton(IUIButton button)
	{
	}

	private void OnUnSelectLanguageButton(IUIButton button)
	{
	}

	private void UpdateSexType()
	{
	}

	private void UpdateRareIcon()
	{
	}

	private void UpdateFormTextActive()
	{
	}

	private void UpdateTypes(MessageEnumData.MsgLangId langId = MessageEnumData.MsgLangId.Num)
	{
	}

	private void PlayVoice(PokemonParam pokemonParam)
	{
	}
}
