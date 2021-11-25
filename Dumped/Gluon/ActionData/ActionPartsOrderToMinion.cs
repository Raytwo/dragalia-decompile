using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=35731412#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E4%B8%80%E8%88%AC%E7%B7%A8%EF%BC%89-ActionPartsOrderToMinion")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/OrderToMinion: å­\u0090å\u0088\u0086ã\u0081\u00b8ã\u0081®ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³æ\u008c\u0087ç¤º", 0)]
	public class ActionPartsOrderToMinion : ActionParts
	{
		[SerializeField]
		private OrderToMinionData _data;

		public override PartsData data => null;
	}
}
