using System;
using Cute.Master;
using UnityEngine;

namespace Gluon.Master
{
	[Serializable]
	public class GuildSystemMessageElement : IMasterElement
	{
		[SerializeField]
		private int _Id;

		[SerializeField]
		private int _GuildTextType;

		[SerializeField]
		private string _Message;

		[SerializeField]
		private MessageReplaceTextType _Type1;

		[SerializeField]
		private MessageReplaceTextType _Type2;

		[SerializeField]
		private MessageReplaceTextType _Type3;

		[SerializeField]
		private MessageReplaceTextType _Type4;

		public int Id => default(int);

		public int GuildTextType => default(int);

		public string Message => null;

		public MessageReplaceTextType Type1 => default(MessageReplaceTextType);

		public MessageReplaceTextType Type2 => default(MessageReplaceTextType);

		public MessageReplaceTextType Type3 => default(MessageReplaceTextType);

		public MessageReplaceTextType Type4 => default(MessageReplaceTextType);
	}
}
