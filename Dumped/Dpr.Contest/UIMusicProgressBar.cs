using UnityEngine;
using UnityEngine.UI;

namespace Dpr.Contest;

public class UIMusicProgressBar : MonoBehaviour
{
	private enum IconAnimState
	{
		None,
		Move,
		Jump,
		End
	}

	private const float anglePerBeat = 180f;

	private Image gaugeImage;

	private RectTransform iconContentRect;

	private RectTransform iconRect;

	private IconAnimState animState;

	private Quaternion quat;

	private Sprite barIconSpr;

	private float limitRotZ;

	private float gaugeWidth;

	private float startPosX;

	private float jumpPower;

	private float jumpDuration;

	private float prevElapsedTime;

	private float angle;

	private float addAngle;

	private float beatSec;

	private int jumpCount;

	private bool moveLock;

	private bool bIsActive;

	public bool IsMoveEnd => default(bool);

	public bool IsActive => default(bool);

	public void Initialize(DanceSettings danceSettingData)
	{
	}

	public void SetIconSpr(Sprite iconSpr)
	{
	}

	public void Setup(float beatSec)
	{
	}

	public void FinishIconMove()
	{
	}

	public void ResetParam(float beatSec)
	{
	}

	public void OnFinalize()
	{
	}

	private void Show()
	{
	}

	public void Hide()
	{
	}

	public void OnUpdate(float elapsedTime, float progressRatio)
	{
	}

	private void SetProgressRatio(float ratio)
	{
	}

	public void DoIconJump()
	{
	}

	public void StartMoveAnim(float elapsedTime)
	{
	}

	private void IconAnimation(float elapsedTime)
	{
	}

	private void SetRotZ(float z)
	{
	}
}
