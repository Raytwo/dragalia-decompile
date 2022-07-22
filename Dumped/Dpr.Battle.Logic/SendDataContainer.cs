using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Dpr.Battle.Logic;

public sealed class SendDataContainer
{
	private List<SendData> m_buffer;

	private uint m_bufferNum;

	private uint m_addIndex;

	public SendDataContainer(uint bufferNum)
	{
	}

	private void ClearBuffer()
	{
	}

	public void Dispose()
	{
	}

	public void CopyFrom([In] ref SendDataContainer srcContainer)
	{
	}

	public void AddData([In] ref SendData dataBuffer)
	{
	}

	private void IncAddIndex()
	{
	}

	public bool IsDataExist(uint dataSerialNumber)
	{
		return default(bool);
	}

	public SendData GetData(uint dataSerialNumber)
	{
		return null;
	}

	public SendData GetLatestData()
	{
		return null;
	}
}
