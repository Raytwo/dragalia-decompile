using UnityEngine;

namespace Gluon.ActionData
{
	[HelpURL("https://wisdom.cygames.jp/pages/viewpage.action?pageId=35731412#id-%E3%82%B3%E3%83%B3%E3%83%9D%E3%83%BC%E3%83%8D%E3%83%B3%E3%83%88%E3%81%AE%E8%AA%AC%E6%98%8E%EF%BC%88%E4%B8%80%E8%88%AC%E7%B7%A8%EF%BC%89-ActionPartsRotateNode")]
	[AddComponentMenu("ã\u0082¢ã\u0082\u00afã\u0082·ã\u0083§ã\u0083³ï¼\u009aã\u0083\u0091ã\u0083¼ã\u0083\u0084/RotateNode : æ\u008c\u0087å®\u009aã\u0083\u008eã\u0083¼ã\u0083\u0089ã\u0082\u0092å\u009b\u009eè»¢", 0)]
	public class ActionPartsRotateNode : ActionParts
	{
		[SerializeField]
		private RotateNodeData _data;

		public override PartsData data => null;
	}
}
