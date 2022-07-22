using System;
using System.Collections.Generic;
using AK.Wwise;
using UnityEngine;

[DefaultExecutionOrder(/*Could not decode attribute arguments.*/)]
public class AkBank : AkTriggerHandler
{
	public Bank data;

	public bool decodeBank;

	public bool loadAsynchronous;

	public bool saveDecodedBank;

	public List<int> unloadTriggerList;

	[HideInInspector]
	[SerializeField]
	private string bankNameInternal;

	[HideInInspector]
	[SerializeField]
	private byte[] valueGuidInternal;

	[Obsolete]
	public string bankName => null;

	[Obsolete]
	public byte[] valueGuid => null;

	protected override void Awake()
	{
	}

	protected override void Start()
	{
	}

	public override void HandleEvent(GameObject in_gameObject)
	{
	}

	public void UnloadBank(GameObject in_gameObject)
	{
	}

	protected override void OnDestroy()
	{
	}
}
