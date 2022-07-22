using System.Collections;
using UnityEngine;

[ExecuteInEditMode]
public class MirrorPlane : MonoBehaviour
{
	[SerializeField]
	private string _texturePropertyName;

	[SerializeField]
	private int _textureSize;

	[SerializeField]
	private float _clipPlaneDistance;

	[SerializeField]
	private float _planeHeightOffset;

	[SerializeField]
	private LayerMask _targetLayers;

	private Hashtable _cameraTable;

	private RenderTexture _renderTexture;

	private static bool _renderingLock;

	private MaterialPropertyBlock _propertyBlock;

	private int _texturePropertyID;

	private Renderer _renderer;

	private Transform _transform;

	public LayerMask targetLayers
	{
		get
		{
			return default(LayerMask);
		}
		set
		{
		}
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	public void OnWillRenderObject()
	{
	}

	private void UpdateCameraModes(Camera src, Camera dest)
	{
	}

	private void CreateMirrorObjects(Camera currentCamera, out Camera reflectionCamera)
	{
	}

	private Vector4 CalculateClipPlane(Camera reflectionCamera, Vector3 planePoint, Vector3 planeNormal)
	{
		return default(Vector4);
	}
}
