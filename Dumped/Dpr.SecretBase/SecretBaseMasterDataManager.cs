using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using XLSXContent;

namespace Dpr.SecretBase;

public class SecretBaseMasterDataManager : MonoBehaviour
{
	[SerializeField]
	private SecretbaseUpgrade secretbase;

	private StatueEffectRawData statueEffectRawData;

	[SerializeField]
	private Pedestal pedestal;

	public SecretbaseUpgrade Secretbase => null;

	public List<StatueEffectData> StatueEffectData
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public Pedestal PedestalData => null;

	public IEnumerator Load()
	{
		return null;
	}

	public StatueEffectData GetStatueEffectData(int id)
	{
		return null;
	}

	public RectInt GetStatueRect(StatueItemData data)
	{
		return default(RectInt);
	}

	public Vector2Int GetRoomSize()
	{
		return default(Vector2Int);
	}
}
