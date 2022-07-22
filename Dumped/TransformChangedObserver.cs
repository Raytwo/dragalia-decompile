using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TransformChangedObserver : UIBehaviour
{
	[SerializeField]
	public ScrollRect _scrollRect;

	protected override void OnRectTransformDimensionsChange()
	{
	}
}
