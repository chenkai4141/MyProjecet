using System.Collections;
using System.Collections.Generic;
using FairyGUI;
using UnityEngine;

public class UIPanel : MonoBehaviour
{
    
    
    // Start is called before the first frame update
    void Start()
    {
        GRoot.inst.SetContentScaleFactor(800,600);
        UIPackage.AddPackage("FGUI/MyTest");
        Debug.Log("加载成功");
        GComponent component = UIPackage.CreateObject("MyTest", "Demo_Main").asCom;
        GRoot.inst.AddChild(component);
    }
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
