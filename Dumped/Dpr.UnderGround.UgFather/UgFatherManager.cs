using System.Collections;
using System.Collections.Generic;
using SmartPoint.AssetAssistant;

namespace Dpr.UnderGround.UgFather;

public class UgFatherManager : SingletonMonoBehaviour<UgFatherManager>
{
	private enum Type
	{
		Treasure,
		Healing,
		Goods_S,
		Goods_L
	}

	private List<string> TypeId;

	private const string UgFatherId = "FATHER";

	private List<UgFatherBase> fathers;

	private UgFatherBase currentFather;

	private IEnumerator Start()
	{
		return null;
	}

	private void OnDestroy()
	{
	}

	private void InputUpdate(float deltaTime)
	{
	}

	private UgFatherBase GetContactFather()
	{
		return null;
	}

	private void Setup()
	{
	}

	private IEnumerator DelaySetup()
	{
		return null;
	}

	private void OnEventEnd()
	{
	}

	public void Clear()
	{
	}
}
