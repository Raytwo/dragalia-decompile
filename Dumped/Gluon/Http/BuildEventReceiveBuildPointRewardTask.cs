using System;
using System.Collections.Generic;
using Cute.Http;

namespace Gluon.Http
{
	public class BuildEventReceiveBuildPointRewardTask : IHttpTask
	{
		private byte[] postData;

		private Action<BuildEventReceiveBuildPointRewardResponse> onSuccess;

		private Action<ErrorType, int, BuildEventReceiveBuildPointRewardResponse> onError;

		private Dictionary<string, string> headers;

		private IWebRequest request;

		public int CacheTime => default(int);

		public bool IsEncrypt => default(bool);

		public BuildEventReceiveBuildPointRewardTask(BuildEventReceiveBuildPointRewardRequest request, Action<BuildEventReceiveBuildPointRewardResponse> onSuccess, Action<ErrorType, int, BuildEventReceiveBuildPointRewardResponse> onError)
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
