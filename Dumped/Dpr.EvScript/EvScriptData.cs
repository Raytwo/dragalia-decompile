namespace Dpr.EvScript;

public class EvScriptData
{
	public EvData EvData;

	public int LabelIndex;

	public int CommandIndex;

	public int RetIndex;

	public EvData.Script GetScript => null;

	public EvScriptData(EvData ev)
	{
	}

	public int FindLabelIndex(string label)
	{
		return default(int);
	}

	public EvData.Script FindLabelScript(string label)
	{
		return null;
	}

	public void Destroy()
	{
	}
}
