namespace Gluon.Http
{
	public class CharaBuildupManaResponse : ResponseCommon
	{
		public class CommonResponse
		{
			public UpdateDataList update_data_list;

			public EntityResult entity_result;
		}

		public CommonResponse data;
	}
}
