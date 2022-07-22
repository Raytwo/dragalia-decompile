using System;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.Rendering;

[ExecuteInEditMode]
public class MeshRendererDirect : MonoBehaviour
{
	[Serializable]
	public class RenderPacket
	{
		[SerializeField]
		public int meshIndex;

		[SerializeField]
		public int submeshIndex;

		[SerializeField]
		public Matrix4x4[] matrices;

		[SerializeField]
		public int materialIndex;

		[SerializeField]
		public ShadowCastingMode castShadows;

		[SerializeField]
		public bool recieveShadows;

		[SerializeField]
		public int layer;

		[SerializeField]
		public Bounds bounds;
	}

	[SerializeField]
	public Mesh[] meshes;

	[SerializeField]
	public Material[] materials;

	[SerializeField]
	public RenderPacket[] renderPackets;

	private static Matrix4x4[] copyBuffer;

	private static BatchRendererGroup batchGroup;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private JobHandle CullingCallback(BatchRendererGroup rendererGroup, BatchCullingContext cullingContext)
	{
		return default(JobHandle);
	}

	private void AddBatchAll(BatchRendererGroup batchGroup)
	{
	}
}
