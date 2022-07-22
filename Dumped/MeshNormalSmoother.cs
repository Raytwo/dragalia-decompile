using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class MeshNormalSmoother
{
	public class SharedVertex
	{
		public Dictionary<Mesh, List<int>> indexLookup;

		public Vector3 compositeNormal;

		public SharedVertex(Mesh mesh, int index, Vector3 normal)
		{
		}

		public List<int> GetIndicesByMesh(Mesh mesh)
		{
			return null;
		}

		public void Add(Mesh mesh, int index, Vector3 normal)
		{
		}
	}

	public struct VectorKey
	{
		private readonly long x;

		private readonly long y;

		private readonly long z;

		private const int _tolerance = 100000;

		public VectorKey([In] ref Vector3 V)
		{
		}

		public override bool Equals(object rhs)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}

	private static List<Mesh> _meshes;

	private static Dictionary<VectorKey, SharedVertex> _vertexLookup;

	public static void Clear()
	{
	}

	public static void Add(Mesh mesh)
	{
	}

	public static void Bake()
	{
	}
}
