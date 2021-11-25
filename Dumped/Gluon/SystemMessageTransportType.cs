using System.Runtime.InteropServices;

namespace Gluon
{
	[StructLayout(3, Size = 4)]
	public enum SystemMessageTransportType
	{
		NONE,
		MODE_CLOSE,
		MODE_MYPAGE,
		MODE_TOP,
		MODE_JUMP_MARKET,
		MODE_RESOURCE,
		MODE_INQUIRY,
		MODE_RELOAD_CHARA_AND_CLOSE,
		MODE_RELOAD_CHARA_AND_PARTY_EDIT,
		MODE_QUIT,
		MODE_RELOAD_GUILD_AND_CLOSE,
		MODE_RELOAD_GUILD_AND_MYPAGE,
		MODE_GUILD_TOP
	}
}
