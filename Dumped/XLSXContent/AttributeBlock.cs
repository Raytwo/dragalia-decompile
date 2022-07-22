using System;
using UnityEngine;

namespace XLSXContent;

[Serializable]
public class AttributeBlock : ScriptableObject
{
	public int[] Attributes;

	public int Width;

	public int this[int index] => default(int);

	public int this[int gridX, int gridY] => default(int);

	public int Length => default(int);
}
