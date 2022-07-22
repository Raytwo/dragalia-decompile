using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dpr.SecretBase;

public class UICursor : UIBehaviour
{
	[SerializeField]
	private RectTransform rect;

	[SerializeField]
	private Image image;

	[SerializeField]
	protected float forcusMin;

	[SerializeField]
	protected float forcusMax;

	[SerializeField]
	private bool isAttach;

	[SerializeField]
	private Vector3 offset;

	protected override void Start()
	{
	}

	private void Update()
	{
	}

	public void Attach()
	{
	}
}
