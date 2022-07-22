using System;

namespace Nintendo.MessageStudio.Lib;

public class BinFlwFile : BinLibmsFileBase
{
	protected override IntPtr InitObject(IntPtr resourcePtr)
	{
		return default(IntPtr);
	}

	protected override void CloseObject(IntPtr objectPtr)
	{
	}

	public int GetNodeNum()
	{
		return default(int);
	}

	public int GetEntryNodeIndex(string label)
	{
		return default(int);
	}

	public LMSFlowNodeData GetNodeData(int index)
	{
		return default(LMSFlowNodeData);
	}

	public ushort[] GetCaseIndexesFromBranchNode(int index)
	{
		return null;
	}

	public string GetFlowParamText(int offset)
	{
		return null;
	}

	public void GetIndexTest(int index)
	{
	}
}
