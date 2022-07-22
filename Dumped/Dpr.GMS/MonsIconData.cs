using System.Collections.Generic;
using UnityEngine;

namespace Dpr.GMS;

public class MonsIconData
{
	private Dictionary<uint, Sprite> monsIconSprTable;

	public void Initialize()
	{
	}

	public void OnFinalize()
	{
	}

	public bool HasMonsIconSpr(uint formNo)
	{
		return default(bool);
	}

	public void SetMonsIconSpr(uint formNo, Sprite spr)
	{
	}

	public Sprite GetMonsIconSprByFormNo(uint formNo)
	{
		return null;
	}
}
