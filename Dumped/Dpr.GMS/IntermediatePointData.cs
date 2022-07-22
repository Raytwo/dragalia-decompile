using Dpr.Message;
using Pml;

namespace Dpr.GMS;

public class IntermediatePointData
{
	public int year;

	public int month;

	public int day;

	public MonsNo sendMonsNo;

	public uint sendMonsFormNo;

	public Sex sendMonsSex;

	public MonsNo receiveMonsNo;

	public ushort receiveMonsFormNo;

	public Sex receiveMonsSex;

	public MessageEnumData.MsgLangId receiveMonsLanguage;

	public MessageEnumData.MsgLangId receiveMonsParentLanguage;

	public string receiveMonsNickname;

	public string receiveMonsParentName;
}
