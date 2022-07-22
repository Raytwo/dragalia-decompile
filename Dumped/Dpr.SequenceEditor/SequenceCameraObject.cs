using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Dpr.Battle.View;
using Dpr.Battle.View.Playables;
using Dpr.Rendering;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Rendering;

namespace Dpr.SequenceEditor;

public class SequenceCameraObject : MonoBehaviour
{
	public enum CameraMode
	{
		Default,
		Role
	}

	public enum CameraType : byte
	{
		Main,
		FieldOnlyCamera,
		EffectOnlyCamera
	}

	public sealed class PostEffect<TImageEffectObject> where TImageEffectObject : ImageEffectObject
	{
		private TImageEffectObject _effectObject;

		private bool _isEnable;

		public TImageEffectObject EffectObject => null;

		public bool IsEnable
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public PostEffect(BattlePostProcessFilter filter)
		{
		}

		public PostEffect(TImageEffectObject effectObject)
		{
		}

		private void SetEnable(bool isEnabled)
		{
		}
	}

	public sealed class PostEffects
	{
		private PfxParam _pfxParam;

		private SequenceCameraObject _sequenceCameraObject;

		private CommandBuffer _colorFilterBuffer;

		public BattlePostProcessFilter PostProcessFilter
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

		public PostEffect<Bloom> Bloom
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

		public PostEffect<DepthOfField> DepthOfField
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

		public PostEffect<Fxaa> Fxaa
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

		public PostEffect<RadialBlur> RadialBlur
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

		public PostEffect<ColorFilter> ColorFilter
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

		public PostEffect<ChromaticAberration> ChromaticAberration
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

		public PostEffect<FeedbackBlur> FeedBackBlur
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

		public PostEffect<BtlvPfx> BtlvPfx
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

		public PostEffects(BattlePostProcessFilter filter, [Optional] PfxParam? initialParam)
		{
		}

		public void InitializeExternalEffects(SequenceCameraObject bufferCamera, ColorFilter colorFilter)
		{
		}

		public PfxParam GetPfxParam()
		{
			return default(PfxParam);
		}

		public void SetPfxParam(PfxParam param, bool isUpdatePfx = true)
		{
		}

		public void UpdatePfx()
		{
		}

		public void UpdateDof()
		{
		}

		public void UpdateBtlvPfx()
		{
		}

		public void OnRenderImage(RenderTexture src, RenderTexture dest)
		{
		}

		public void Dispose()
		{
		}
	}

	protected Transform _cachedTransform;

	public const float DEFAULT_FREEZE_CAMERA_HEIGHT = -9999f;

	protected Camera _camera;

	[SerializeField]
	protected Camera _charaEffectCamera;

	[SerializeField]
	protected Camera _depthCamera;

	[SerializeField]
	protected Camera _compositor;

	[SerializeField]
	protected BattlePostProcessFilter _battlePostProcess;

	[SerializeField]
	protected BattleMultipleCameraCompositor _battleMultipleCameraCompositor;

	[SerializeField]
	protected ColorFilter _colorFilter;

	protected PostEffects _postEffects;

	protected Vector3 m_position;

	protected Vector3 m_positionOffset;

	protected Vector3 m_target;

	protected Vector3 m_targetOffset;

	protected Vector3 m_rotation;

	protected float m_near;

	protected float m_far;

	protected float m_fov;

	protected float _twist;

	protected float m_PseudoTargetDistance;

	protected bool m_isCheckGround;

	protected bool m_isCheckFreezeOnGround;

	protected bool m_isFreezeRotation;

	protected bool m_isForceUpdateRotation;

	protected bool m_isTransformFreeze;

	protected float m_freezeHeight;

	protected bool m_isUpdateParam;

	protected bool m_isCalcTarget;

	protected Transform m_targetTransform;

	public new Transform transform => null;

	protected float targetDistance => default(float);

	public Camera Camera => null;

	public Vector3 RawPosition => default(Vector3);

	public Vector3 RawRotation => default(Vector3);

	public float Near
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Far
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Fov
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public float Twist
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	public bool IsEnabled
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public BattlePostProcessFilter PostProcess => null;

	public Camera Compositor => null;

	public SequenceCameraSystem.CameraStateType CameraState
	{
		[CompilerGenerated]
		get
		{
			return default(SequenceCameraSystem.CameraStateType);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public CameraMode CurrentCameraMode
	{
		[CompilerGenerated]
		get
		{
			return default(CameraMode);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsAudioListener
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public void Initialize(SequenceCameraSystem.CameraStateType type)
	{
	}

	public void UnInitialize()
	{
	}

	public void OnLateUpdate(float deltaTime)
	{
	}

	public void SetPosition(Vector3 pos)
	{
	}

	public void SetPosition(Vector3 pos, Vector3 target)
	{
	}

	public void SetPosition(Vector3 pos, Quaternion target)
	{
	}

	public Vector3 GetPosition()
	{
		return default(Vector3);
	}

	public void SetPositionOffset(Vector3 pos)
	{
	}

	public Vector3 GetPositionOffset()
	{
		return default(Vector3);
	}

	public void SetRotation(Vector3 rotation)
	{
	}

	public Vector3 GetRotation()
	{
		return default(Vector3);
	}

	public void SetTarget(Vector3 value)
	{
	}

	public void SetTarget(float dist)
	{
	}

	public Vector3 GetTarget()
	{
		return default(Vector3);
	}

	public Transform GetTargetTransform()
	{
		return null;
	}

	public void SetTargetOffset(Vector3 value)
	{
	}

	public Vector3 GetTargetOffset()
	{
		return default(Vector3);
	}

	protected Vector3 CalcTarget()
	{
		return default(Vector3);
	}

	protected Vector3 CalcTarget(float dist)
	{
		return default(Vector3);
	}

	public void SetRotationFreeze(bool isFreeze, [Optional] Vector3? rot)
	{
	}

	public Vector3 CalcPseudoTarget([In] ref Vector3 pos, [In] ref Vector3 rot)
	{
		return default(Vector3);
	}

	public PostEffects GetPostEffects()
	{
		return null;
	}

	public void SetCameraAnimationCheckGround(bool value)
	{
	}

	public bool GetCameraAnimationCheckGround()
	{
		return default(bool);
	}

	public void SetCameraAnimationmFreezeOnGround(bool value)
	{
	}

	public bool GetCameraAnimationmFreezeOnGround()
	{
		return default(bool);
	}

	public void SetFreezeHeight(float height = -9999f)
	{
	}

	public float GetFreezeHeight()
	{
		return default(float);
	}

	public void SyncOtherCamera(CameraCommander commander, bool isForceUpdate = false)
	{
	}

	public void GetFollowCameraPos(float camLen, ref Vector3 ret)
	{
	}

	public void GetFollowCameraRot(ref Vector3 ret)
	{
	}

	protected void GetCheckGroundCameraPosTrg([In] ref float height, ref Vector3 retPos, ref Vector3 retTrg)
	{
	}
}
