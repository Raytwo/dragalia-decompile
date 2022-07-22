using System.ComponentModel;

namespace INL1;

public class IlcaNetStation : IlcaNetTransport
{
	~IlcaNetStation()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Init()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Boot()
	{
	}

	private void CleanUp()
	{
	}

	[Browsable(false)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	public void Final()
	{
	}
}
