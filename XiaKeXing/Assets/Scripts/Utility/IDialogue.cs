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
        // TODO ����: 0.1
        // ����һ���Ի����� ���������ṩ���ַ���
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