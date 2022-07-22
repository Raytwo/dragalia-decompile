using System.Runtime.InteropServices;

namespace Nintendo.MessageStudio.Lib;

[StructLayout(2, Pack = 1, Size = 16)]
public struct LMSFlowNodeData
{
	public LMSFlowNodeType NodeType;

	public LMSFlowParamType ParamType;

	public ushort Reserved;

	public uint ParamValue;

	public ushort Rawdata0;

	public ushort Rawdata1;

	public ushort Rawdata2;

	public ushort Rawdata3;

	public LMSFlowEntry Entry;

	public LMSFlowMessage Message;

	public LMSFlowBranch Branch;

	public LMSFlowEvent Event;

	public LMSFlowJump Jump;
}
