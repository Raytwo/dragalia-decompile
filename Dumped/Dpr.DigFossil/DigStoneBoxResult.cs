using System;
using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.SecretBase;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using XLSXContent;

namespace Dpr.DigFossil;

public class DigStoneBoxResult : IDigStoneBoxResult
{
	public class Context
	{
		public DigMasterDataManager.StoneBoxData boxData;

		public Transform boxPos;

		public DigMasterDataManager masterDataManager;

		public IDigMessage message;

		public IDigFade fade;

		public IDigAudioManager audioManager;

		public IDigStatueCameraSelector cameraSelector;

		public IDigBoard digBoard;

		public DigFossilController.DigParam digParam;

		public StatueModelLoader statueModelLoader;

		public DigEffectManager effectManager;

		public DirectionParam directionParam;

		public DebugParam debugParam;

		public Context(DigMasterDataManager.StoneBoxData boxData, Transform boxPos, DigMasterDataManager masterDataManager, IDigMessage message, IDigFade fade, IDigAudioManager audioManager, IDigStatueCameraSelector cameraSelector, IDigBoard digBoard, DigFossilController.DigParam digParam, StatueModelLoader statueModelLoader, DigEffectManager effectManager)
		{
		}
	}

	public class DirectionParam
	{
		public float boxOpenAnimationSpeed;

		public float effectFireDelay;

		public Vector2 blackIn;

		public Vector2 whiteOut;

		public Vector2 whiteIn;

		public DirectionParam(float boxOpenAnimationSpeed, float effectFireDelay, Vector2 blackIn, Vector2 whiteOut, Vector2 whiteIn)
		{
		}
	}

	public class DebugParam
	{
		public int statueId;

		public DebugParam(int statueId)
		{
		}
	}

	public class LotteryInfo
	{
		public StatueEffectRawData.Sheettable Info
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

		public float Ratio
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LotteryInfo(StatueEffectRawData.Sheettable info, DigMasterDataManager.RatioId ratioId)
		{
		}
	}

	private enum Step
	{
		Init,
		IdleStatueLoding,
		FadeIn,
		ShowBoxGetMessage,
		IdleBoxGetMessage,
		ShowBoxOpenMessage,
		IdleBoxOpenMessage,
		BoxOpenDirection,
		ShowStatueWhbiteIn,
		ShowStatueGetMessage,
		IdleStatueGetMessage,
		ShowStatueMaxMessage,
		IdleStatueMaxMessage,
		End
	}

	public class StoneBoxDirection : MonoBehaviour
	{
		private PlayableGraph graph;

		private AnimationClipPlayable clipPlayable;

		private Context context;

		public void Init(AnimationClip clip, Context context)
		{
		}

		public void BoxOpen(Vector3 effectPos, Action onCompletedCallback)
		{
		}

		private void PlayBoxOpenAnimation()
		{
		}

		private IEnumerator BoxOpenDirection(Vector3 effectPos, Action onCompletedCallback)
		{
			return null;
		}
	}

	private Context context;

	private Action onFinishDirection;

	private Step step;

	private StoneBoxDirection stoneBoxDirection;

	private GameObject statueModel;

	private StatueEffectData statueData;

	private GameObject bgModel;

	private int statueLoadWaitCount;

	private bool isMaxStatue;

	private StatueEffectRawData.Sheettable statue;

	private const string animatonClipAssetName = "objects/ob2000_00";

	private const string bgModelAssetName = "bg/arenas/ground/eventarea012";

	private const string bgModelPrefabName = "EVENTAREA012";

	public IEnumerator Initialize(Context context)
	{
		return null;
	}

	public void Start(Action onFinishDirection)
	{
	}

	private void LotteryAndLoadStatue()
	{
	}

	private StatueEffectRawData.Sheettable LotteryStatue()
	{
		return null;
	}

	private void LoadStatue(StatueEffectRawData.Sheettable statue)
	{
	}

	public void OnUpdate()
	{
	}

	private void ChangeStep(Step step)
	{
	}
}
