using System.Runtime.InteropServices;
using DPData;

namespace Pml.PokePara;

public class OwnerInfo
{
	public uint trainerId;

	public byte sex;

	public byte langID;

	public string name;

	public OwnerInfo()
	{
	}

	public OwnerInfo([In] ref MYSTATUS ownerStatus)
	{
	}

	public void CopyFrom(OwnerInfo src)
	{
	}
}
