using System.Collections.Generic;
using UnityEngine;

namespace Effect;

internal class MeshCombiner
{
	private Mesh _mainMesh;

	private List<Mesh> _workMeshes;

	private int _workMeshIndex;

	private CombineInstance[] _combineInstances;

	public Mesh mainMesh => null;

	public static MeshCombiner Create()
	{
		return null;
	}

	public void Destroy()
	{
	}

	public void Clear()
	{
	}

	public Mesh FetchMesh()
	{
		return null;
	}

	public void CombineMeshes(Matrix4x4 m)
	{
	}

	private static Mesh CreateMesh()
	{
		return null;
	}

	private static void DestroyMesh(Mesh mesh)
	{
	}
}
