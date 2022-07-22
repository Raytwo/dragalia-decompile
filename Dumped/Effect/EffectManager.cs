using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using Dpr;
using Dpr.Battle.View;
using SmartPoint.AssetAssistant;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.Events;
using XLSXContent;

namespace Effect;

public class EffectManager : SingletonMonoBehaviour<EffectManager>
{
	public class LoadParam
	{
		public string AssetBundleName;

		public string AssetName;

		public int PoolCount;

		public bool Resident;

		public string GetAssetName()
		{
			return null;
		}
	}

	public class FieldLoadParam : LoadParam
	{
		public bool InitLoad;
	}

	private class CameraParam
	{
		public Camera camera;

		public MultipleCameraCompositor compositor;

		public BattleMultipleCameraCompositor battleCompositor;

		public bool IsFieldCamera()
		{
			return default(bool);
		}
	}

	private EffectDatabase _dbEffects;

	private Dictionary<string, EffectData> _effectDatas;

	private List<EffectInstance> _effectInstances;

	private ObjectPool<EffectData, EffectInstance> _objectPool;

	private static int _id_BackgroundTexture;

	private DepthOfField _dof;

	private List<ShaderVariantCollection> _shaderVariantCollections;

	private Dictionary<string, AssetBundleUnloader> _assetBundleRefDict;

	private string[] _commonAssetBundleNames;

	private bool _isLoadedDatabase;

	private bool _isLoadedResidents;

	private CameraParam _cameraParam;

	public EffectDatabase dbEffects => null;

	public bool isLoadedDatabase => default(bool);

	public bool isLoadedResidents => default(bool);

	private IEnumerator Start()
	{
		return null;
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void Destroy()
	{
	}

	public void LoadDatabase()
	{
	}

	private IEnumerator OpLoadDatabase()
	{
		return null;
	}

	public void LoadResidents()
	{
	}

	private IEnumerator OpLoadResidentAssetBundles()
	{
		return null;
	}

	public void Load(LoadParam[] loadParams, UnityAction<EffectData, bool> onLoaded)
	{
	}

	public IEnumerator OpLoad(LoadParam[] loadParams, UnityAction<EffectData, bool> onLoaded)
	{
		return null;
	}

	internal void _Unload(EffectData effectData)
	{
	}

	public EffectData FindEffectData(string assetName)
	{
		return null;
	}

	public EffectInstance Play(EffectData effectData, Vector3 position, Quaternion rotation, [Optional] Transform attachedTransform, [Optional] UnityAction<EffectInstance> onFinished)
	{
		return null;
	}

	public EffectInstance Create(EffectData effectData, Vector3 position, Quaternion rotation, [Optional] Transform attachedTransform)
	{
		return null;
	}

	private void OnFinishedInstance(object reference)
	{
	}

	public void RemoveInstances(bool isForce = true)
	{
	}

	public void RemoveInstancesByData(EffectData effectData)
	{
	}

	private void LateUpdate()
	{
	}

	private void UpdateDistortionCamera()
	{
	}

	private void SetDof()
	{
	}

	private void SetupBackgroundTexture()
	{
	}
}
