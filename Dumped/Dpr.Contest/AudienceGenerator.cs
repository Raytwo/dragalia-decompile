using UnityEngine;

namespace Dpr.Contest;

public sealed class AudienceGenerator : MonoBehaviour
{
	private struct AudienceObj
	{
		private Camera cameraPtr;

		private Transform targetTransform;

		private Mesh targetMesh;

		private Matrix4x4[] meshMatrixArray;

		private Matrix4x4[] calcMeshMatrixArray;

		private Material mat;

		public void Create(MeshRenderer originalMeshRenderer, Vector3[] posArray, Quaternion[] rotArray)
		{
		}

		public void MovePosX(float moveX, Camera camera)
		{
		}

		public void OnUpdate()
		{
		}

		private Matrix4x4 Multiply(ref Matrix4x4 lhs, ref Matrix4x4 rhs)
		{
			return default(Matrix4x4);
		}

		public void OnFinalize()
		{
		}
	}

	private readonly Vector3 COPY_TARGET_POSITION;

	[SerializeField]
	private GameObject[] copyTargetArray;

	[SerializeField]
	private Transform[] generateParentArray;

	private AudienceObj[] audienceArray;

	private GameObject copyParent;

	private bool bPlaying;

	private void Start()
	{
	}

	public void Play()
	{
	}

	public void Stop()
	{
	}

	private void OnDestroy()
	{
	}

	private void GenerateAudience()
	{
	}

	public void MovePositionX(float moveX, Camera camera)
	{
	}

	private void PostLateUpdate(float deltaTime)
	{
	}
}
