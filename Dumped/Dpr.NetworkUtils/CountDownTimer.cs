using System.Text;

namespace Dpr.NetworkUtils;

public class CountDownTimer
{
	private const string ZERO_MINUT = "00";

	private const int SECOND = 60;

	private StringBuilder timeSb;

	private float remaingTime;

	private int remainingCount;

	private bool isCountDown;

	public bool IsCountDown => default(bool);

	public int RemainingCount => default(int);

	public void StartCountDown(float startTime)
	{
	}

	public bool IsChangeCountDown()
	{
		return default(bool);
	}

	public void SetTimeCount(int timeCount)
	{
	}

	public string GetMinuteStr()
	{
		return null;
	}

	public string GetSecondStr()
	{
		return null;
	}

	public void OnUpdate(float deltaTime)
	{
	}
}
