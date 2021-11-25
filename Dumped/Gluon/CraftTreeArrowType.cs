using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum CraftTreeArrowType
	{
		None,
		NormalArrow,
		T_Arrow,
		I_Arrow,
		L_Arrow,
		VirticalLine,
		NormalRedArrow,
		T_ArrowAllRed,
		T_ArrowOnlyRed,
		T_ArrowUnderRed,
		I_ArrowAllRed,
		I_ArrowCenterRed,
		I_ArrowUnderRed,
		L_ArrowRed,
		VirticalRedLine
	}
}
