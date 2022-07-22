using System;
using AK.Wwise;
using UnityEngine;

public class AkSurfaceReflector : MonoBehaviour
{
	public Mesh Mesh;

	public AcousticTexture[] AcousticTextures;

	public float[] OcclusionValues;

	public bool EnableDiffraction;

	public bool EnableDiffractionOnBoundaryEdges;

	public AkRoom AssociatedRoom;

	[HideInInspector]
	[SerializeField]
	private AcousticTexture AcousticTextureInternal;

	[Obsolete]
	public AcousticTexture AcousticTexture
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private ulong GetID()
	{
		return default(ulong);
	}

	private static void SetGeometryFromMesh(Mesh mesh, AcousticTexture[] acousticTextures, float[] occlusionValues, Transform transform, ulong geometryID, ulong associatedRoomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges, string name = "")
	{
	}

	public void SetAssociatedRoom(AkRoom room)
	{
	}

	public void SetGeometry()
	{
	}

	public void UpdateGeometry()
	{
	}

	public void RemoveGeometry()
	{
	}

	[Obsolete]
	public static void RemoveGeometrySet(MeshFilter meshFilter)
	{
	}

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[Obsolete]
	public static ulong GetAkGeometrySetID(MeshFilter meshFilter)
	{
		return default(ulong);
	}

	[Obsolete]
	public static void AddGeometrySet(AcousticTexture acousticTexture, MeshFilter meshFilter, ulong roomID, bool enableDiffraction, bool enableDiffractionOnBoundaryEdges)
	{
	}
}
