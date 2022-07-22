using UnityEngine;
using UnityEngine.UI;

namespace Dpr.GMS;

public class UIAchievementAnim : MonoBehaviour
{
	private enum AnimState
	{
		WaitStartPlayAnim,
		PlayingAnim,
		End
	}

	[SerializeField]
	private Image achieveMessageImage;

	private readonly int startAnimHash;

	private readonly int endAnimHash;

	private RectTransform content;

	private Animator animator;

	private AnimState currentAnimState;

	private Sprite achieveTitleSpr;

	private bool bIsActive;

	public bool IsActive => default(bool);

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	private void ReleaseSprite()
	{
	}

	public void ShowMessage(Sprite titleSpr)
	{
	}

	public void OnUpdate()
	{
	}

	private void UpdateWaitStartPlayAnim()
	{
	}

	private void UpdatePlayingAnim()
	{
	}
}
