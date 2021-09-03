using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QFramework;
using UnityEngine.SceneManagement;
/********************************************************************************

** Class name: GameRoot

** Description: GameRoot

** Author: Ting Zhang

** Created: 2021-8-15

*********************************************************************************/
public class GameRoot : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ResKit.Init();
        UIKit.Root.SetResolution(1080,1920,0.5f);
        SceneManager.LoadScene("Main");
    }
}
