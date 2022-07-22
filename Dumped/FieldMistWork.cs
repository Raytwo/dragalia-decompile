using Dpr;

public class FieldMistWork
{
	private EnvironmentSettings currentSetting;

	private EnvironmentSettings mistSetting;

	private FieldFloatMove mistWeight;

	public bool IsEnable => default(bool);

	public static bool CheckMistWeather()
	{
		return default(bool);
	}

	public static bool AvailableKiribarai()
	{
		return default(bool);
	}

	public EnvironmentSettings GetCurrentSetting()
	{
		return null;
	}

	public void Setup()
	{
	}

	private EnvironmentSettings GetBaseSetting(ZoneID zoneId)
	{
		return null;
	}

	public void Update(float deltaTime)
	{
	}

	public void ChangeMist(float target, float time = 0f)
	{
	}

	private void CalcCurrentSetting()
	{
	}

	private void BlendSetting(EnvironmentSettings.Parameters paramA, EnvironmentSettings.Parameters paramB, float weight, EnvironmentSettings.Parameters refOutParam)
	{
	}

	private void CreateMistEffectSetting()
	{
	}

	private void OverrideParameter(EnvironmentSettings.Parameters param, int paramHeadIndex)
	{
	}
}
