using DG.Tweening;
using Dpr.UI;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIGMSScene : MonoBehaviour
{
	private enum AnimState
	{
		LaunchAnim,
		EndAnim
	}

	private readonly int launchAnimHash;

	private readonly int launchAnimInHash;

	private readonly int idleAnimHash;

	[SerializeField]
	private UIText putPointNumText;

	[SerializeField]
	private UIText animPutPointNumText;

	[SerializeField]
	private GameObject crossCorsor;

	[SerializeField]
	private GameObject putNumContent;

	[SerializeField]
	private RawImage sceneBGRawImage;

	[SerializeField]
	private RawImage rtRawImage;

	[SerializeField]
	private Image titleLogoImage01;

	[SerializeField]
	private Image preTitleLogoImage;

	[SerializeField]
	private Image titleLogoImage02;

	private Canvas launchAnimCanvas;

	private DOTweenAnimation headerFadeTween;

	private CanvasGroup headerCanvasGroup;

	private Animator launchAnimator;

	private AnimState animState;

	private Sprite titleSpr;

	private Sprite preTitleSpr;

	private bool bIsPlayLaunchAnim;

	public bool IsPlayLaunchAnim => default(bool);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	private void ReleaseSprite()
	{
	}

	public void SetSceneBGTexture(Texture2D bgTexture)
	{
	}

	public void SetRenderTexture(RenderTexture rt)
	{
	}

	public void SetTitleLogoSpr(Sprite titleLogoSpr, Sprite preTitleLogoSpr)
	{
	}

	public void ShowHeader()
	{
	}

	public void HideHeader()
	{
	}

	public void ShowCrossCursor()
	{
	}

	public void HideCrossCursor()
	{
	}

	public void ShowPutNumText(int putNum)
	{
	}

	public void HidePutNumText()
	{
	}

	private void SetPutNumActive(bool active)
	{
	}

	public void StartSceneAnim(int putNum)
	{
	}

	public void StartOnBackTopAnim(int putNum)
	{
	}

	public void PlayEndAnim()
	{
	}

	public void OnUpdate()
	{
	}

	private void UpdateLaunchAnim()
	{
	}

	private void UpdateEndAnim()
	{
	}

	private bool CheckTransitionAnim(int animHash)
	{
		return default(bool);
	}

	public void PlayBootSe()
	{
	}
}
