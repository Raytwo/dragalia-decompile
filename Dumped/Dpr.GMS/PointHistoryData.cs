using System.Text;
using UnityEngine;

namespace Dpr.GMS;

public class PointHistoryData
{
	public Sprite sendMonsIconSpr;

	public Sprite receiveMonsIconSpr;

	public Sprite receiveMonsSexIconSpr;

	public Sprite receiveMonsLangIconSpr;

	public Sprite receiveMonsParentLangIconSpr;

	protected StringBuilder receiveMonsNameSb;

	protected StringBuilder receiveMonsNicknameSb;

	protected StringBuilder receiveMonsParentNameSb;

	protected StringBuilder dateTimeSb;

	protected int dataIndex;
}
