using System.Collections;
using SmartPoint.AssetAssistant;
using UnityEngine;

namespace Dpr.Battle.Logic;

public sealed class BattleProc : SingletonMonoBehaviour<BattleProc>
{
	public delegate void EndFuncDelegate();

	private delegate void UpdateCoreFunc(float deltaTime);

	private static BATTLE_SETUP_PARAM setupParam;

	private static bool _isInitialized;

	private static bool _isEnd;

	public static EndFuncDelegate onEndFunc;

	public static EndFuncDelegate onInitializedFunc;

	public static bool isDebugLoopStop;

	private Transform cluster;

	private MainModule mainModule;

	private UpdateCoreFunc updateCore;

	private int subSeq;

	private bool isFinalized;

	public static bool isInitialized => default(bool);

	public Transform Cluster => null;

	public MainModule MainModule => null;

	public static bool isEnd => default(bool);

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Shutdown()
	{
	}

	[SceneBeforeActivateOperationMethod]
	public IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	private void OnInitialized()
	{
	}

	private void OnUpdate(float deltaTime)
	{
	}

	private void SetUpdateCore(UpdateCoreFunc func)
	{
	}

	private void UpdateInitialze(float deltaTime)
	{
	}

	private void UpdateMainRun(float deltaTime)
	{
	}

	private void UpdateMainFinalize(float deltaTime)
	{
	}

	private void UpdateEnd(float dletaTime)
	{
	}

	public static void SetParam(BATTLE_SETUP_PARAM inSetupParam)
	{
	}

	public IEnumerator FinalizeCoroutine()
	{
		return null;
	}

	private void StopBGM()
	{
	}
}
