using UnityEngine;

namespace Dpr.MsgWindow;

[CreateAssetMenu]
public class MsgWindowConfig : ScriptableObject
{
	public float[] msgSpeed;

	public float windowWidthOffset;

	public float speakerFrameWidthOffset;

	public float offsetMessagePosX;

	public float iconMoveDist;

	public float addAngleSec;

	public float fastForwardMagnification;

	public float scrollTextDuration;

	public int waitAfterFinishMsgFrame;

	public float textLinePaddingOffset;

	public WindowAnimator.AnimType wndAnimType;
}
