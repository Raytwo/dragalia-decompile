using UnityEngine;
using UnityEngine.UI;

namespace Effect;

public class ParticleToCanvas : MaskableGraphic
{
	private static readonly Matrix4x4 s_scaleZ;

	[HideInInspector]
	[SerializeField]
	private Material _material;

	[HideInInspector]
	[SerializeField]
	private Material _trailMaterial;

	private ParticleSystem _particleSystem;

	private ParticleSystemRenderer _particleSystemRenderer;

	private ParticleSystem.MainModule _mainModule;

	private ParticleSystem.TrailModule _trailsModule;

	private MeshCombiner _meshCombiner;

	private Material[] _maskMaterials;

	private Canvas _parentCanvas;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	private void OnWillRenderCanvases()
	{
	}

	private Canvas GetParentCanvas()
	{
		return null;
	}

	protected override void UpdateMaterial()
	{
	}

	private Material GetModifiedMaterial(Material baseMaterial, int index)
	{
		return null;
	}
}
