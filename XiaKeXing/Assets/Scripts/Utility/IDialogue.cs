using QFramework;
using MatchThree;
using UnityEngine;
using System.Collections;
using QFramework.Example;
using System.Collections.Generic;

namespace MatchThree
{
    public interface IDialogue : ISystem
    {
        // TODO 需求: 0.1
        // 产生一个对话界面 界面上有提供的字符串
        public abstract void StartDialogue();
        public abstract void StartDialogue(string s);
    }

    public class DialogueSystem : AbstractSystem, IDialogue
    {
        public void StartDialogue()
        {
            // Create an UI Panel
            //UIKit.OpenPanel<UIDialoguePanel>();
        }


        public void StartDialogue(string s)
        {
            // Create an UI Panel
            //UIKit.OpenPanel<UIDialoguePanel>(new UIDialoguePanelData() { msg = s }); ;

        }

        protected override void OnInit()
        {
            
        }
    }

    public class Conversation
    {
        private string Conversations;
        public Conversation(string[] s)
        {
            
        }
    }
}