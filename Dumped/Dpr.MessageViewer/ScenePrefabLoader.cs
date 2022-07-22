using System.Collections;
using UnityEngine;

namespace Dpr.MessageViewer;

public class ScenePrefabLoader : MonoBehaviour
{
	[SerializeField]
	private string abName;

	private GameObject sceneObj;

	private void Start()
	{
	}

	private IEnumerator IE_SceneStart()
	{
		return null;
	}

	private void OnDestroy()
	{
	}
}
