using System;

namespace CSharpGo
{
	/// <summary>
	/// NodeDir 的摘要说明。
	/// </summary>
	public class DirNode:System.Windows.Forms.TreeNode
	{
		public DirNode()
		{
			//
			// TODO: 在此处添加构造函数逻辑
			//
		}
		public bool SubDirectoriesAdded;
		public DirNode(string text):base(text)
		{

		}
	}
}
