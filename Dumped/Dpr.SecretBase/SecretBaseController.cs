using System.Collections;
using Dpr.UI;
using UnityEngine;

namespace Dpr.SecretBase;

public class SecretBaseController : MonoBehaviour
{
	private enum State
	{
		SecretBase,
		PcMenu,
		Zoom,
		IdleMessage,
		StatueEffectWindow,
		StatuePlacementEdit
	}

	private enum CameraMode
	{
		Field,
		Zoom,
		StatueEdit
	}

	[SerializeField]
	private StatuePlacementEditController statuePlacement;

	[SerializeField]
	private SecretBaseCamera secretBaseCamera;

	[SerializeField]
	private SecretBaseZoomCamera zoomCamera;

	[SerializeField]
	private SecretBaseMasterDataManager masterData;

	[SerializeField]
	private StatueEffectWindow statueEffectWindow;

	[SerializeField]
	private SecretBaseCrystalEffectManager crystalEffectManager;

	[SerializeField]
	private BoxCollider exitArea;

	[SerializeField]
	private SecretBaseAudioManager audioManager;

	[SerializeField]
	private SecretBaseNamePlate namePlate;

	[SerializeField]
	private FieldCrystalEntity crystalEntity;

	private int initFacial;

	private FieldConnector fieldConnector;

	private bool isHaveState;

	private bool isExited;

	private bool isMineSecretBase;

	private State state;

	private ContextMenuItem selectedItem;

	public IEnumerator ActivateOperation(FieldConnector fieldConnector)
	{
		return null;
	}

	public void OnUpdate(float deltaTime)
	{
	}

	private bool IsEnableInput()
	{
		return default(bool);
	}

	private void SystemInitialize()
	{
	}

	private IEnumerator Load()
	{
		return null;
	}

	private void Initialize()
	{
	}

	private void SetState(State state)
	{
	}

	private void SetStatueViewMode(bool isView)
	{
	}

	private void SelectCamera(CameraMode mode)
	{
	}

	private void ShowPcContextMenu()
	{
	}

	private bool CheckExit()
	{
		return default(bool);
	}

	private void ExitSecretBase()
	{
	}

	private void SaveReport()
	{
	}

	private void ResetPostProcessFilter()
	{
	}
}
