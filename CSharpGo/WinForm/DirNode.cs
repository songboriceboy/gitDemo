using System;

namespace CSharpGo
{
	/// <summary>
	/// NodeDir ��ժҪ˵����
	/// </summary>
	public class DirNode:System.Windows.Forms.TreeNode
	{
		public DirNode()
		{
			//
			// TODO: �ڴ˴���ӹ��캯���߼�
			//
		}
		public bool SubDirectoriesAdded;
		public DirNode(string text):base(text)
		{

		}
	}
}
