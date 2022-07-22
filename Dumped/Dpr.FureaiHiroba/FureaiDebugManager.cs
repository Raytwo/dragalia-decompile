using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Dpr.FureaiHiroba;

public class FureaiDebugManager : MonoBehaviour
{
	private const string TEXT_PARENT_NAME = "DebugTexts";

	private static Dictionary<string, Text> Texts;

	public int Button01;

	private static Transform TextsParent => null;

	private void CreateDebugDraw()
	{
	}

	private void ClearDebugView()
	{
	}

	public static Text CreateText(string TextName, float lineSpace = 0f)
	{
		return null;
	}

	public static Text GetText(string TextName)
	{
		return null;
	}

	private RectTransform CreateTextParent(Transform parent, Vector2 Pos)
	{
		return null;
	}

	private static void SetParentAndAlign(GameObject child, GameObject parent)
	{
	}

	public static Canvas CreateCanvas([Optional] GameObject parent, string name = "Canvas")
	{
		return null;
	}

	public static EventSystem CreateEventSystem([Optional] GameObject parent, string name = "EventSystem")
	{
		return null;
	}
}
