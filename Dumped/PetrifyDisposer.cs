using System.Collections.Generic;
using UnityEngine;

public class PetrifyDisposer : MonoBehaviour
{
	[HideInInspector]
	public List<Renderer> volatileRenderers;

	private void OnDestroy()
	{
	}
}
