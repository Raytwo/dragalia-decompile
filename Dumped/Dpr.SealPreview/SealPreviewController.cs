using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.SequenceEditor;
using Dpr.UI;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.SealPreview;

public sealed class SealPreviewController : MonoBehaviour
{
	private enum CameraMode
	{
		Single,
		Double,
		Length
	}

	private enum SealPreviewState
	{
		None,
		Initialized,
		ThrowBall,
		SequenceEnd,
		FadeOut
	}

	private const ArenaID ARENA_ID = ArenaID.G023;

	public static CapsuleInfo PreviewCapsuleInfo;

	public static CapsuleInfo PreviewSubCapsuleInfo;

	private static bool isDispose;

	[SerializeField]
	private SequenceCameraObject sequenceCameraObject;

	[SerializeField]
	private EnvironmentController environmentController;

	[SerializeField]
	private SceneConnector connector;

	private bool isPause;

	private int _subSeq;

	private SealPreviewSetupParam _setupParam;

	private SealPreviewViewSystem _sealPreviewViewSystem;

	private Transform _cluster;

	public static bool IsLoadFailed
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

	private SealPreviewState CurrentPreviewState
	{
		[CompilerGenerated]
		get
		{
			return default(SealPreviewState);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public static void RequestDispose()
	{
	}

	[SceneBeforeActivateOperationMethod]
	private IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	private void Start()
	{
	}

	private void Dispose()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SwitchBattleRule()
	{
	}

	public void SwitchPlayAndPause()
	{
	}

	public SealPreviewSetupParam GetSealPreviewSetupParam()
	{
		return default(SealPreviewSetupParam);
	}

	public SequenceCameraObject GetSequenceCameraObject()
	{
		return null;
	}
}
