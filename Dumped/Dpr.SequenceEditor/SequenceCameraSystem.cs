using System.Runtime.CompilerServices;
using Dpr.Battle.View.Playables;
using UnityEngine;

namespace Dpr.SequenceEditor;

public class SequenceCameraSystem
{
	public enum CameraStateType
	{
		Main,
		Sub
	}

	public enum WaitCameraStateType
	{
		None,
		Wait,
		Load,
		Update,
		Stop
	}

	protected const float DEFAULT_NEAR = 16f;

	protected const float DEFAULT_FAR = 200000f;

	protected const float DEFAULT_FOV = 30f;

	protected const float DEFAULT_AUDIO_VPF_RANGE_MIN = 20f;

	protected const float DEFAULT_AUDIO_VPF_RANGE_MAX = 48f;

	protected const float DEFAULT_AUDIO_VPF_VALUE_MIN = 10f;

	protected const float DEFAULT_AUDIO_VPF_VALUE_MAX = 1f;

	protected const int WAITCAM_TARGET_FIELD = 0;

	protected const int WAITCAM_TARGET_POKE = 1;

	protected const int WAITCAM_TARGET_TRAINER = 2;

	protected const int WAITCAM_TARGET_ENEMY_POKE = 3;

	protected const int WAITCAM_TARGET_ENEMY_TRAINER = 4;

	protected const int WAITCAM_TARGET_ALLY_POKE = 5;

	protected const int WAITCAM_TARGET_ALLY_TRAINER = 6;

	protected const int WAITCAM_TARGET_NONE = 7;

	protected const int WAITCAM_TARGET_G_POKE = 8;

	protected const int WAITCAM_TARGET_ENEMY_G_POKE = 9;

	protected const int WAITCAM_TARGET_ALLY_G_POKE = 10;

	protected const int WAITCAM_NODE_ORIGIN = 0;

	protected const int WAITCAM_NODE_CENTER = 1;

	protected const int WAITCAM_NODE_FACE = 2;

	protected const int WAITCAM_NODE_CHEST = 3;

	protected const int WAITCAM_RUEL_SINGLE = 0;

	protected const int WAITCAM_RUEL_DOUBLE = 1;

	protected const int WAITCAM_RUEL_RAID = 2;

	protected const int WAITCAM_RUEL_S_WILD = 3;

	protected const int WAITCAM_RUEL_D_WILD = 4;

	protected const int WAITCAM_RUEL_G1_ALLY = 5;

	protected const int WAITCAM_RUEL_G1_ENEMY = 6;

	protected const int WAITCAM_RUEL_G2 = 7;

	protected const int WAITCAM_RUEL_JOKER_1 = 8;

	protected const int WAITCAM_RUEL_JOKER_2 = 9;

	protected const int WAITCAM_RUEL_JOKER_3 = 10;

	protected const int WAITCAM_RENDER_VISIBLE_SHADOW = 0;

	protected const int WAITCAM_RENDER_VISIBLE_YEBIS = 1;

	protected const int WAITCAM_RENDER_VISIBLE_ZPREPATH = 2;

	protected const int WAITCAM_RENDER_VISIBLE_BG = 3;

	protected const int WAITCAM_RENDER_VISIBLE_FIELDEFF = 4;

	protected const int WAITCAM_RENDER_VISIBLE_GROUNDEFF = 5;

	protected const int WAITCAM_TARGET_HIDE_NONE = 0;

	protected const int WAITCAM_TARGET_HIDE_ONLY = 1;

	protected const int WAITCAM_TARGET_HIDE_SET = 2;

	protected const int WAITCAM_TARGET_HIDE_SIDE = 3;

	protected ISequenceViewSystem _viewSystem;

	protected CameraFilePlayable m_pCamearaAnimeComponent;

	protected bool _isCheckGround;

	protected bool _isPosOverCheck;

	protected SequenceCameraObject[] Cameras;

	protected bool IsPlayingCameraAnimation;

	protected CameraStateType CameraState
	{
		[CompilerGenerated]
		get
		{
			return default(CameraStateType);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public SequenceCameraSystem(ISequenceViewSystem viewSystem)
	{
	}

	public virtual void OnUpdate(float deltaTime)
	{
	}

	public virtual void OnLateUpdate(float deltaTime)
	{
	}

	public virtual SequenceCameraObject GetBattleCamera(CameraStateType type)
	{
		return null;
	}

	public void PlayCameraAnimation(CameraFilePlayable pAnimFile)
	{
	}

	public void StopCameraAnimation(CameraStateType state, bool isKeep)
	{
	}

	public void DestroyCameraAnimation()
	{
	}

	public void SetCameraAnimationSpeed(float speed)
	{
	}

	public void SetCameraAnimationScale(Vector3 scale)
	{
	}

	public void SetCameraAnimationRotateY_Deg(float rot)
	{
	}

	public void SetCameraAnimationCheckGround(bool value)
	{
	}

	public bool GetCameraAnimationCheckGround()
	{
		return default(bool);
	}

	public void SetCameraPosOverCheck(bool value)
	{
	}

	public bool GetCameraPosOverCheck()
	{
		return default(bool);
	}
}
