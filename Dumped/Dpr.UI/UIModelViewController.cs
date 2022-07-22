using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr.Trainer;
using Pml.PokePara;
using SmartPoint.AssetAssistant;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;

namespace Dpr.UI;

public class UIModelViewController : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	public class ModelParam
	{
		public ModelViewType modelViewType;

		public int uniqueId;

		public bool loaded;

		public AssetBundleUnloader assetBundleUnloader;

		public GameObject gameObject;

		public BaseEntity baseEntity;

		public bool isDontClear;

		public Transform root;

		public Transform attachTo;

		public Transform attachFrom;

		public float attachPosY;

		public void Active(bool enabled)
		{
		}

		public void Destroy()
		{
		}

		public bool IsEnableCache(ModelViewType modelViewType_, int uniqueId_)
		{
			return default(bool);
		}
	}

	private class SaveCameraParam
	{
		public Camera camera;

		public bool actived;

		public int cullMask;

		public List<SaveCameraParam> subCameraParams;
	}

	[Flags]
	public enum ModelViewType
	{
		None = 0,
		Pokemon = 1,
		Character = 2,
		Party = 5,
		Zukan = 9,
		Box = 0x11,
		Boutique = 0x22,
		Habitat = 0x41,
		Moving = 0x81,
		Compare = 0x101
	}

	[SerializeField]
	private RectTransform _modelBgRoot;

	[SerializeField]
	private Transform _modelRoot;

	[SerializeField]
	private ModelViewBgCamera _modelBgCamera;

	[SerializeField]
	private Camera _modelCamera;

	[SerializeField]
	private ModelViewReflectionCamera _reflectionCamera;

	[SerializeField]
	private EnvironmentController _modelEnvironmentController;

	[SerializeField]
	private EnvironmentSettings _environmentCharacter;

	[SerializeField]
	private EnvironmentSettings _environmentPokemon;

	private UIManager.EnvironmentControllerSaver _environmentControllerSaver;

	private bool _isActived;

	private Vector2 _modelViewSize;

	private float _modelCameraFov;

	private float _modelReflectionAlpha;

	private Vector2 _modelCameraCenterOffset;

	private Vector3 _modelOffset;

	private Vector3 _modelRotation;

	private Vector3 _modelAttachOffset;

	private float _modelScale;

	private float _cameraRotationX;

	private int _loadRequestModelId;

	private ModelParam _modelParam;

	private SaveCameraParam _saveCameraParam;

	public const int defaultCacheModelNum = 6;

	private CacheList<ModelParam> _cacheParams;

	private ModelViewType _modelViewType;

	public ModelParam modelParam => null;

	public RectTransform modelBgRoot => null;

	public void SetModelViewType(ModelViewType type)
	{
	}

	public (Vector3, Vector3, float, Vector3, Vector2) GetModelViewParameters(ModelViewType type, PokemonParam pokemonParam)
	{
		return default((Vector3, Vector3, float, Vector3, Vector2));
	}

	public int GetModelViewParameterIdleAnimation(ModelViewType type, PokemonParam pokemonParam)
	{
		return default(int);
	}

	public void SaveEnvironmentController()
	{
	}

	public void EnableModelLight(bool enabled, ModelViewType type)
	{
	}

	private EnvironmentSettings GetEnvironmentSettings(ModelViewType type)
	{
		return null;
	}

	private bool IsEnableGlobalEnvironmentController()
	{
		return default(bool);
	}

	private void EnableGlobalEnvironmentController(bool enabled)
	{
	}

	public void ModelViewSize(float width, float height)
	{
	}

	public void ModelCameraFov(float fov)
	{
	}

	public void ModelReflection(float alpha)
	{
	}

	public void ModelCameraCenterOffsetX(float offsetX)
	{
	}

	public void ModelCameraCenterOffset(Vector2 offset)
	{
	}

	public void SetModelOffset(Vector3 offset)
	{
	}

	public void SetModelRotation(Vector3 rotation)
	{
	}

	public Vector3 GetModelRotation()
	{
		return default(Vector3);
	}

	public void SetModelScale(float scale)
	{
	}

	public void SetModelAttachOffset(Vector3 offset)
	{
	}

	public float GetCameraRotationX()
	{
		return default(float);
	}

	public void SetCameraRotationX(float x)
	{
	}

	public Vector3 GetModelCameraPosition()
	{
		return default(Vector3);
	}

	public int ResetCaches(int num, bool isUnload = true)
	{
		return default(int);
	}

	public IEnumerator OpLoadModel(ModelViewType modelViewType, int uniqueId, string assetBundleName, bool isDontClear, UnityAction<ModelParam> onSetupParam, UnityAction onSetup)
	{
		return null;
	}

	private void CacheParamMoveLast(ModelParam modelParam)
	{
	}

	public IEnumerator OpLoadCharacterModel(int uniqueId, string assetBundleName, bool isDontClear = false, [Optional] UnityAction<int> onSetup, TrainerType trainerType = TrainerType.INVALID)
	{
		return null;
	}

	public void EnableMainCameraByUiMode(bool enabled)
	{
	}

	private void SetupCharacterModel(TrainerType trainerType)
	{
	}

	public IEnumerator OpLoadPokemonModel(PokemonParam pokemonParam, bool isApplyOffset = true, bool isDontClear = false, [Optional] UnityAction<PokemonParam> onSetup)
	{
		return null;
	}

	private void ModelAttachTransforms(ModelParam modelParam)
	{
	}

	private void SetupPokemonModel(PokemonParam pokemonParam, bool isApplyOffset)
	{
	}

	internal void _SetupPokemonModel(PokemonParam pokemonParam, bool isApplyOffset, Vector3 modelOffset, Vector3 modelRotation, float modelScale, Vector3 modelAttachOffset)
	{
	}

	public BoundingSphere ComputeBoundingSphereByPokemon(GameObject pokemonObj)
	{
		return default(BoundingSphere);
	}

	public void PlayAnimation(int anim, bool forceLoop = false)
	{
	}

	public void StopAnimation()
	{
	}

	public float GetCurrentRemaingTime()
	{
		return default(float);
	}

	public int GetAnimationIndexByClipName(string clipName)
	{
		return default(int);
	}

	public bool IsPlayAnimation()
	{
		return default(bool);
	}

	public void PauseAnimation(bool paused)
	{
	}

	public void LoopAnimation(bool looped)
	{
	}

	internal void _UpdateModelView()
	{
	}

	public void SetupModelViewCameras(bool enableModelCamera)
	{
	}

	private void SetupModelViewCamera(bool enableModelCamera, Camera camera)
	{
	}

	private void UpdateModelViewCameras()
	{
	}

	private Matrix4x4 ComputeReflectionMatrix(Vector4 n)
	{
		return default(Matrix4x4);
	}

	void IViewportChangeHandler.OnViewportChange(int screenWidth, int screenHeight)
	{
	}

	public RenderTexture GetModelViewRenderTexture()
	{
		return null;
	}

	public void ClearModelView(bool isFinish)
	{
	}

	private void SetActive(bool enabled)
	{
	}

	private void UnloadUnused()
	{
	}
}
