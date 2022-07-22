using UnityEngine;
using UnityEngine.UI;

namespace Dpr.UI;

public class RaderChart : MaskableGraphic
{
	public class Param
	{
		public float[] values;

		public bool isSetColor;

		public Color color;

		public float minLength;
	}

	[SerializeField]
	private float _length;

	private Material[] _maskMaterials;

	private Canvas _parentCanvas;

	private Mesh _mesh;

	private Param _param;

	protected override void Awake()
	{
	}

	protected override void OnEnable()
	{
	}

	protected override void OnDisable()
	{
	}

	protected override void OnDestroy()
	{
	}

	public void Setup(Param param)
	{
	}

	private void CreateMesh()
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
