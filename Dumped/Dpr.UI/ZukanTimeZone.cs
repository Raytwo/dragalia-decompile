using UnityEngine;
using XLSXContent;

namespace Dpr.UI;

public class ZukanTimeZone : MonoBehaviour
{
	private readonly int _animParamStateId;

	private readonly int _animParamConnectIdSrc;

	private readonly int _animParamConnectIdDest;

	private Animator _animator;

	private int _connectId;

	public SheetDistributionTable.TimeZoneType timeZone => default(SheetDistributionTable.TimeZoneType);

	private void Awake()
	{
	}

	public void Set(int connectId)
	{
	}

	public void Move(int move)
	{
	}

	private void Change(int connectId, int stateId = 1)
	{
	}

	public static int ToConnectId(PeriodOfDay periodOfDay)
	{
		return default(int);
	}
}
