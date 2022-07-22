using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class ProceduralPlane : MonoBehaviour
{
	protected static readonly int ID_MAIN_TEX;

	protected static readonly int ID_SUBDUCTION;

	protected static readonly int ID_DYNAMIC_NORMALMAP;

	protected static readonly int ID_FIELD_RT;

	protected static readonly int ID_RCP_GRIDSIZE;

	protected static readonly int ID_GRID_X;

	protected static readonly int ID_GRID_Y;

	protected static readonly int ID_FOOT_ANGLE;

	protected static readonly int ID_FOOT_SCALE;

	[SerializeField]
	protected string _proceduralPlaneName;

	[SerializeField]
	protected Color _initialColor;

	[SerializeField]
	protected int _textureWidth;

	[SerializeField]
	protected int _textureHeight;

	[SerializeField]
	protected RenderTextureFormat _textureFormat;

	[SerializeField]
	protected TextureWrapMode _textureWrapMode;

	[SerializeField]
	protected Material _footprintMaterial;

	[SerializeField]
	protected Material _transferMaterial;

	[SerializeField]
	protected RenderTextureFormat _dynamicNormalMapFormat;

	[SerializeField]
	protected Material _dynamicNormalMapMaterial;

	[SerializeField]
	protected float _subduction;

	[SerializeField]
	protected int _gridSize;

	[SerializeField]
	protected float _gridScale;

	[SerializeField]
	protected int _gridDivision;

	[SerializeField]
	protected float _planeElevation;

	[SerializeField]
	protected float _swingWidth;

	[SerializeField]
	protected RawImage _debugDisplay;

	protected RenderTexture _renderTexture;

	protected RenderTexture _dynamicNormalTexture;

	protected CommandBuffer _commandBuffer;

	protected Mesh _quadMesh;

	protected Mesh _fieldMesh;

	protected Vector2Int _previousGrid;

	protected MeshRenderer _meshRenderer;

	protected MeshFilter _meshFilter;

	protected MaterialPropertyBlock _propertyBlock;

	protected Dictionary<Transform, (Vector3, Quaternion)> _hipTrails;

	public float planeElevation
	{
		get
		{
			return default(float);
		}
		set
		{
		}
	}

	protected void CreateAssets()
	{
	}

	protected virtual void OnSetup()
	{
	}

	protected void DestroyAssets()
	{
	}

	protected virtual void OnValidate()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	protected virtual Transform GetTargetTransform(FieldObjectEntity objectEntity)
	{
		return null;
	}

	protected virtual void OnUpdate()
	{
	}

	private Mesh CreatePlaneMesh(string name, int cols, int rows, float width, float height)
	{
		return null;
	}
}
