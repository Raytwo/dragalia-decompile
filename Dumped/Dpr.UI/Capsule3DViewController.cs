using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dpr.UI;

public class Capsule3DViewController : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	[Serializable]
	private class DefaultPositionAndRotation
	{
		[SerializeField]
		private Vector3 capsuleObjectPosition;

		[SerializeField]
		private Vector3 capsuleObjectRotation;

		[SerializeField]
		private Vector3 modelCameraRootPosition;

		[SerializeField]
		private Vector3 modelCameraRootRotation;

		[SerializeField]
		private Vector3 modelCameraPosition;

		[SerializeField]
		private Vector3 modelCameraRotation;

		public Vector3 CapsuleObjectPosition => default(Vector3);

		public Quaternion CapsuleObjectRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 ModelCameraRootPosition => default(Vector3);

		public Quaternion ModelCameraRootRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public Vector3 ModelCameraPosition => default(Vector3);

		public Quaternion ModelCameraRotation
		{
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public void Initialize()
		{
		}
	}

	private const string CapsuleObjectAssetName = "objects/ob1015_00";

	private const string SealObjectAssetName = "objects/ob1015_01";

	private const float RotateSpeed = 3f;

	[SerializeField]
	private Camera bgCamera;

	[SerializeField]
	private Transform modelCameraRoot;

	[SerializeField]
	private Camera modelCamera;

	[SerializeField]
	private Transform modelRoot;

	[SerializeField]
	private RectTransform bgRoot;

	[SerializeField]
	private EnvironmentController environmentController;

	[SerializeField]
	private EnvironmentSettings environmentSettings;

	[SerializeField]
	private DefaultPositionAndRotation listModeDefault;

	[SerializeField]
	private DefaultPositionAndRotation editModeDefault;

	[SerializeField]
	private Vector3 sealScale;

	[SerializeField]
	private float offsetPositionZ;

	private RenderTexture renderTexture;

	private Transform capsuleTransform;

	private Transform modelCameraTransform;

	private Vector3 hitCapsulePosition;

	private Vector3 hitCapsuleNormal;

	private List<Seal3DObject> sealObjects;

	private GameObject capsuleObject;

	private GameObject seal3DObjectPrefab;

	private RaycastHit[] raycastHits;

	private RaycastHit dummyRaycastHit;

	private DefaultPositionAndRotation currentDefault;

	private bool isLoadedCapsuleObject;

	private bool isLoadedSealObject;

	public float CapsuleRadius
	{
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsIntialized => default(bool);

	public bool IsHitCapsule
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

	public void OnViewportChange(int screenWidth, int screenHeight)
	{
	}

	public void Initialize(RawImage rawImage)
	{
	}

	public void Dispose()
	{
	}

	public void SetEnviromentControllerActive(bool isActive)
	{
	}

	public void SetActive(bool isActive)
	{
	}

	public void SetCapsuleActive(bool isActive)
	{
	}

	public IEnumerator Redraw()
	{
		return null;
	}

	public void Setup(CapsuleInfo capsuleInfo, bool isResetView)
	{
	}

	public void SetBG(RectTransform rectTransform)
	{
	}

	public void ShowListMode()
	{
	}

	public void ShowEditMode()
	{
	}

	public void Rotation(float x, float y)
	{
	}

	public void ResetRotation()
	{
	}

	public Vector3 GetAffixSealPosition()
	{
		return default(Vector3);
	}

	public Vector3 GetAffixSealPosition(Seal3DObject seal3DObject)
	{
		return default(Vector3);
	}

	public Vector3 GetScreenPosition(Seal3DObject seal3DObject)
	{
		return default(Vector3);
	}

	public RaycastHit Raycast(Vector3 screenPosition, out Seal3DObject seal3DObject)
	{
		return default(RaycastHit);
	}

	public void AffixSeal(int affixSealId, int sealId)
	{
	}

	public void AffixSealObject(Seal3DObject seal3DObject)
	{
	}

	private void AffixSeal(int affixSealId, int sealId, Vector3 affixDataPosition)
	{
	}

	private void CreateCapsuleObject()
	{
	}

	private void LoadSealObjectPrefab()
	{
	}

	private Seal3DObject GetSealObject()
	{
		return null;
	}

	private Vector3 ConvertAffixSealPointToWorldPoint(Vector3 affixSealPoint)
	{
		return default(Vector3);
	}

	private Vector3 ConvertWorldPointToAffixSealPoint(Vector3 worldPoint)
	{
		return default(Vector3);
	}
}
