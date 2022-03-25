using QFramework;
using UnityEngine;
using MatchThree.UI;
using System.Collections;
using System.Collections.Generic;

namespace MatchThree
{
    public class GameController : ViewController, IController
    {
        public IArchitecture GetArchitecture()
        {
            return MatchThree.Interface;
        }

        // Start is called before the first frame update
        void Start()
        {
            ResKit.Init();
            UIKit.OpenPanel<SplashPanel>(); 
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
