using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;

public class SceneCloser : MonoBehaviour
{
	[SerializeField]
	private RectTransform _rectTransform;

	private void Start()
	{
	}

	public void OnPointerClickDelegate([Optional] PointerEventData data)
	{
	}
}
