using System;
using System.Runtime.InteropServices;
using SmartPoint.AssetAssistant;
using SmartPoint.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Rendering;

namespace Dpr.Battle.View;

[ExecuteAlways]
public sealed class BattlePostProcessFilter : MonoBehaviour, IViewportChangeHandler, IEventSystemHandler
{
	[Serializable]
	public class EffectObjectData
	{
		public ImageEffectObject effectObject;

		public CommandBuffer commandBuffer;

		public bool isFeedback;
	}

	[SerializeField]
	private EffectObjectData[] _effectObjectDatas;

	[SerializeField]
	private bool _useOnPostRender;

	private PfxParam _pfxParam;

	private Camera _camera;

	private RenderTexture _renderTexture;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void Reset()
	{
	}

	private void Update()
	{
	}

	private void OnPostRender()
	{
	}

	public T GetEffect<T>() where T : ImageEffectObject
	{
		return null;
	}

	public void UpdatePfxParam([In] ref PfxParam param)
	{
	}

	public void OnViewportChange(int screenWidth, int screenHeight)
	{
	}
}
