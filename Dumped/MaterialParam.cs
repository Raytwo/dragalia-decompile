using System;
using UnityEngine;

[Serializable]
public class MaterialParam
{
	public Material mat;

	public MaterialUsing[] usings;

	public void SetUpUsing(Renderer[] renderers)
	{
	}
}
