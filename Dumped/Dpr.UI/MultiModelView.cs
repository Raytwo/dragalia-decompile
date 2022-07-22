using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class MultiModelView : MonoBehaviour
{
	public class ViewModelData
	{
		public GameObject modelObj;

		public BattleCharacterEntity entity;
	}

	private const int RT_DEPTH = 16;

	[SerializeField]
	private RawImage[] targetRawImages;

	[SerializeField]
	private Camera rtCamera;

	[SerializeField]
	private Vector2Int rtSize;

	[SerializeField]
	private float modelPosY;

	[SerializeField]
	private int objectLayer;

	private Dictionary<int, AssetBundleUnloader> unloaders;

	private ViewModelData[] viewModelDataArray;

	private RenderTexture renderTexture;

	private Transform modelRoot;

	private float modelViewPortSpace;

	private int modelViewCount;

	public bool bIsInitialize
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

	public int ModelViewCount => default(int);

	public int TotalModelViewCount => default(int);

	private void Start()
	{
	}

	private void Initialize()
	{
	}

	private void CreateRenderTexture()
	{
	}

	public void SetRawImage(RawImage[] rawImages)
	{
	}

	private void SettingRawImages()
	{
	}

	public Rect CalcRawImageRect(int index, float width, float height, ref Rect rect)
	{
		return default(Rect);
	}

	private void OnDestroy()
	{
	}

	public bool HasViewModelByIndex(int index)
	{
		return default(bool);
	}

	public void LoadCharacterModel(int index, string modelPath, Action<ViewModelData> onCompleteLoad)
	{
	}

	private void SettingModelData(int createIndex, string modelPath, GameObject modelObj)
	{
	}

	public void DestroyModel(int index)
	{
	}

	public void ChangeModelMotion(int index, int motionIndex)
	{
	}
}
