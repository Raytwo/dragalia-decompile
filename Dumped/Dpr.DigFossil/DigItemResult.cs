using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

namespace Dpr.DigFossil;

public class DigItemResult : MonoBehaviour
{
	[SerializeField]
	private GameObject resultItemPrefab;

	[SerializeField]
	private Transform itemsRoot;

	[SerializeField]
	private SpriteAtlas atlas;

	[SerializeField]
	private IDigMessage message;

	[SerializeField]
	private DigBoard board;

	[SerializeField]
	private DigAudioManager audioManager;

	[SerializeField]
	private DigFade fade;

	private readonly List<IDigResultItem> resultItems;

	public void Initialize(IDigMessage message)
	{
	}

	public IEnumerator ResultCommonItems(Vector2 fadeTime, Action onFinishedCallback)
	{
		return null;
	}

	private void DestroyResultItems()
	{
	}
}
