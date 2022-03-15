
// 1.请在菜单 编辑器扩展/Namespace Settings 里设置命名空间
// 2.命名空间更改后，生成代码之后，需要把逻辑代码文件（非 Designer）的命名空间手动更改
using QFramework;
using MatchThree;
using UnityEngine;

namespace MatchThree
{
	public partial class GameRoot : ViewController, IController
	{
        public IArchitecture GetArchitecture()
        {
            return MatchThree.Interface;
        }

        void Start()
		{
            IDialogue dialogue = this.GetSystem<IDialogue>();
            dialogue.StartDialogue("HI");
            Debug.Log("Successfully create content");
		}
	}
}
