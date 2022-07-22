using UnityEngine;

namespace Dpr.Message;

public class LoadMsbtOperation : CustomYieldInstruction
{
	private bool bIsReady;

	private MsbtDataModel[] dataModelArray;

	private int arrayNum;

	private int currentIndex;

	private int processingFileNum;

	public bool IsReady => default(bool);

	public override bool keepWaiting => default(bool);

	public void SetData(MsbtDataModel[] dataModelArray, int processingFileNum)
	{
	}
}
