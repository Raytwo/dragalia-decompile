using System.Collections;
using System.Runtime.CompilerServices;
using Dpr.SecretBase;
using SmartPoint.AssetAssistant;
using UnityEngine;

public class FieldConnector : SceneConnector
{
	private AssetRequestOperation playerRequestOperation;

	private AssetRequestOperation bgRequestOperatioin;

	private StaticQueue<string> bgQueue;

	private bool isFieldUnload;

	private Coroutine fieldUnloadCoroutine;

	private SecretBaseController secretBaseController;

	public static bool drawCollisions;

	private static Mesh _boxMesh;

	private static Material _boxMat;

	public static bool IsSetupOperationRunning;

	private int _unload_limit_count;

	private const int _UNLOAD_LIMIT = 20;

	public AreaID loadedAreaID
	{
		[CompilerGenerated]
		get
		{
			return default(AreaID);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public override void OnUpdate(float deltaTime)
	{
	}

	public override IEnumerator PrepareOperation()
	{
		return null;
	}

	public override bool SwitchingOperation(SceneID target)
	{
		return default(bool);
	}

	public override IEnumerator SetupOperation()
	{
		return null;
	}

	private void PlayerGroundPlacement()
	{
	}

	private IEnumerator UnloadField()
	{
		return null;
	}

	private void ReleaseSecretBase()
	{
	}

	private void ZenmetuProc()
	{
	}
}
