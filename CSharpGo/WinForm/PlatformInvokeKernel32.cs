using System;
using System.Runtime.InteropServices;
namespace CSharpGo
{
	/// <summary>
	/// PlatformInvokeKernel32 的摘要说明。
	/// </summary>
	public class PlatformInvokeKernel32
	{
		public PlatformInvokeKernel32()
		{

		}
		[DllImport("KERNEL32",CharSet=System.Runtime.InteropServices.CharSet.Auto)]
		public static extern int GetDriveType(string lpRootPathName);
		public const int DRIVE_FIXED=3;
	}
}
