using UnityEngine;

namespace NexAssets;

public class NexInitializer : MonoBehaviour
{
	[SerializeField]
	private NexInitParam nexInitParam;

	public Common.NEX_INIT_PARAM GetNexInitParam()
	{
		return default(Common.NEX_INIT_PARAM);
	}
}
