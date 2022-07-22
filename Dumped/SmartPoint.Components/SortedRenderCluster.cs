using UnityEngine;

namespace SmartPoint.Components;

public class SortedRenderCluster : MonoBehaviour
{
	[SerializeField]
	public SkinnedMeshRendererCluster[] rendererClusters;

	protected void OnEnable()
	{
	}

	protected void OnDisable()
	{
	}
}
