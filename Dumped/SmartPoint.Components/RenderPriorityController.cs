using System.Collections.Generic;
using UnityEngine;

namespace SmartPoint.Components;

[DisallowMultipleComponent]
public class RenderPriorityController : MonoBehaviour
{
	private Camera _camera;

	private static Dictionary<Transform, List<(Transform, SkinnedMeshRenderer[])>> _clusterAndTransforms;

	private void Awake()
	{
	}

	public static void Register(Transform root, SkinnedMeshRendererCluster[] clusters)
	{
	}

	public static void Register(Transform root, Transform group, SkinnedMeshRenderer[] prioritySortedRenderers)
	{
	}

	public static void Unregister(Transform root)
	{
	}

	private void OnPreCull()
	{
	}
}
