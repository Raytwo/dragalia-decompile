using System.Runtime.InteropServices;

namespace FLATOUT.Main
{
	[StructLayout(3, Size = 4)]
	public enum FlPlaneTypes
	{
		Normal,
		NineSlice,
		FullNineSlice
	}
}
