using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour 
{
    void Start()
    {
        Debug.Log("Hello World!"); // 在控制台输出
    }

    void Update()
    {
        //vacio
    }
}


// 🎨 方法 1：在 UI 里显示 "Hello World" //
// 步骤：
// 1.在 Hierarchy（层级窗口）中，右键 Create > UI > Text - TextMeshPro（如果没有 TextMeshPro，可以用 UI > Text (Legacy)）。
// 2.在 Inspector 面板里，把 Text 属性改成 "Hello World"。
// 3.调整 Font Size 和 Alignment，让它居中显示。
// 这样，你运行游戏时，就会看到屏幕上显示 "Hello World" 了！🎉


// 🖥 方法 2：在控制台输出 "Hello World"
//你可以写一个 C# 脚本，让 Unity 在控制台（Console）打印 "Hello World"。
//步骤：
// 1.创建脚本：
// * 右键 Assets 文件夹，选择 Create > C# Script，命名为 HelloWorld。
// * 双击打开 HelloWorld.cs，输入以下代码：
//
///  csharp // log //
//using UnityEngine;
//
//public class HelloWorld : MonoBehaviour
//{
//  void Start()
//  {
//      Debug.Log("Hello World!"); // 在控制台输出
//  }
//}
///////////////////////////////////////////////////end//
// 2.挂载到对象：
// * 在 Hierarchy 窗口中，创建一个空对象：右键 Create Empty，重命名为 HelloWorldObject。
// 
// * 把 HelloWorld.cs 脚本拖到这个对象上。
//
// 3.运行游戏：
// * 点击 Play 按钮，在 Console 窗口会看到 "Hello World!"。