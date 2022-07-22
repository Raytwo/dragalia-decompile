namespace Dpr.Security;

public class LicenseFile
{
	private static readonly byte[] INIT_VECTOR;

	private const string MOUNT_NAME = "sd";

	private const string LICENSE_FILE_NAME = "Dpr.lic";

	public bool IsValid;

	public string OfficeName;

	public string UserName;

	public bool WaterMarkEnable;

	public bool Check()
	{
		return default(bool);
	}

	private bool Decode(ref byte[] buffer, string user)
	{
		return default(bool);
	}

	private string GetUserName()
	{
		return null;
	}

	private string GetKeyFromUser(string user)
	{
		return null;
	}
}
