using UnityEngine;

namespace Dpr.Contest;

public class VisualSection : MonoBehaviour
{
	private ContestViewSystem contestViewSystem;

	private uint mainBgmID;

	private bool bPlayeSeq;

	private bool bStop;

	private bool bRunning;

	public void RestParam()
	{
	}

	public void Setup(uint mainBgmID, ContestViewSystem viewSystem)
	{
	}

	public void Stop()
	{
	}

	public void StartSection()
	{
	}

	public bool UpdateSection()
	{
		return default(bool);
	}
}
