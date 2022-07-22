using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Dpr.UI;

public class CardAnimationController : MonoBehaviour
{
	private readonly int AnimParamFromCardId;

	private readonly int AnimParamToCardId;

	private readonly int AnimParamFromCaseId;

	private readonly int AnimParamToCaseId;

	private List<Animator> animators;

	private Animator mainAnimator;

	private CardModelViewController cardModelViewController;

	private bool isOpened;

	public bool IsShowBadgeCase
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

	public bool IsCardFront
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

	public bool IsOpen
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

	public bool IsAnimation => default(bool);

	public bool IsAnimationAll => default(bool);

	public void Initialize()
	{
	}

	public void RegisterAnimator(Animator animator, bool isMain)
	{
	}

	public void RegisterCardModelViewController(CardModelViewController cardModelViewController)
	{
	}

	public void ShowCard()
	{
	}

	public void SwitchCardFrontBack()
	{
	}

	public void ShowBadgeCase()
	{
	}

	public void OpenCover()
	{
	}

	public void CloseCover()
	{
	}

	public void SetEnviromentLight(int isEnable)
	{
	}

	public void RebindMain()
	{
	}

	private void SetAnimatorParams(int fromCard, int toCard, int fromCase, int toCase)
	{
	}
}
