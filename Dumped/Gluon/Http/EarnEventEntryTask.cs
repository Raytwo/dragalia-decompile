using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class EarnEventEntryTask : IHttpTask
	{
		private byte[] postData;

		private Action<EarnEventEntryResponse> onSuccess;

		private Action<ErrorType, int, EarnEventEntryResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public EarnEventEntryTask(EarnEventEntryRequest request, Action<EarnEventEntryResponse> onSuccess, Action<ErrorType, int, EarnEventEntryResponse> onError)
		{
		}

		public void SetHeader(string key, string value)
		{
		}

		public IWebRequest Send(string url)
		{
			return null;
		}

		public bool Deserialize(byte[] body)
		{
			return default(bool);
		}

		public void OnError(ErrorType errorType, int resultCode)
		{
		}
	}
}
