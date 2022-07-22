using System.Collections;
using System.Runtime.CompilerServices;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneConnector : MonoBehaviour
{
	[SerializeField]
	public SceneID sceneID;

	[SerializeField]
	public string scenePath;

	[SerializeField]
	public Camera mainCamera;

	[SerializeField]
	public Camera reflectionCamera;

	[SerializeField]
	protected Transform _bgCacheObjects;

	[SerializeField]
	protected Transform _characterCacheObjects;

	private PeriodOfDay _fixedPeriodOfDay;

	public bool IsEnableUpdate;

	private bool IsRenderSettingsDirty;

	public EnvironmentSettings renderSettings;

	public EnvironmentController environmentController;

	public Scene scene
	{
		[CompilerGenerated]
		get
		{
			return default(Scene);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public Transform bgCacheObjects => null;

	public Transform characterCacheObjects => null;

	public virtual IEnumerator PrepareOperation()
	{
		return null;
	}

	public virtual IEnumerator SetupOperation()
	{
		return null;
	}

	public virtual bool SwitchingOperation(SceneID target)
	{
		return default(bool);
	}

	[SceneBeforeActivateOperationMethod]
	private IEnumerator ActivateOperation(Transform cluster)
	{
		return null;
	}

	public virtual void OnEnable()
	{
	}

	public void ResetLight(bool isForceCurrentPeriodOfDay = true)
	{
	}

	public virtual void OnDisable()
	{
	}

	public virtual void OnUpdate(float deltaTime)
	{
	}

	public void ClearBGCache()
	{
	}

	public void ClearCharacterCache()
	{
	}
}
