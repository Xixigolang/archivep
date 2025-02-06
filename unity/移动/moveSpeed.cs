using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // 移动速度
    
    // Start is called before the first frame update
    void Start()
    {
        // none
    }

    // Update is called once per frame
    void Update()
    {
        // 获取水平和垂直输入
        float moveX = Input.GetAxis("Horizontal"); // 获取水平输入（A/D 或 左/右箭头
        float moveY = Input.GetAxis("Vertical");  // 获取垂直输入（W/S 或 上/下箭头）


        // 更新位置
        // 1️⃣ Vector3 是什么？
        // 在 Unity 里，Vector3 代表一个 三维向量，通常用于表示 位置（Position）、方向（Direction）、速度（Velocity） 等。
        // 它由 三个浮点数 (float) 组成：
        // csharp // log//
        //Vector3 myVector = new Vector3(1.0f, 2.0f, 3.0f);
        ///////////////////////////////////////////////////////
        // 这代表 (x = 1.0, y = 2.0, z = 3.0)，可以想象成一个 三维坐标点 或 一个向量。
        Vector3 movement = new Vector3(moveX, moveY, 0) * moveSpeed * Time.deltaTime;
        transform.position += movement;
    }
}


// 2️⃣ new Vector3(moveX, moveY, 0) 代表什么？
// csharp // log//
//Vector3 movement = new Vector3(moveX, moveY, 0);
///////////////////////////////////////////////////////
// 解释：
// * moveX → 代表 水平方向的移动（左右）。
// * moveY → 代表 垂直方向的移动（上下）。
// * 0 → 代表 Z 轴方向（因为是 2D 游戏，Z 轴保持 0）。



// 3️⃣ Time.deltaTime 代表什么？
// <a/ Time.deltaTime /a> 代表 上一帧与当前帧之间的时间间隔（以秒为单位）。
// 💡 为什么要用它？ 因为不同的电脑性能不同，帧率（FPS）可能不稳定。如果你直接用：
// csharp // log//
//transform.position += new Vector3(1, 0, 0);
/////////////////////////////////////////////////////////////////
//那么：
// * 在 60 FPS 的电脑上，每秒移动 60 次，速度会很快。
// * 在 30 FPS 的电脑上，每秒移动 30 次，速度就会变慢。
// 使用 <a/ Time.deltaTime /a> 让移动基于 时间，而不是 帧数：
// csharp // log//
//transform.position += new Vector3(1, 0, 0) * Time.deltaTime;
//////////////////////////////////////////////////////////////////
// 无论 FPS 高低，每秒的移动速度都一致！✅



// 4️⃣ transform.position += movement; 代表什么？
// <a/ transform.position /a> 是 游戏物体的位置。
// csharp // log//
// transform.position += movement;
//////////////////////////////////////////////////////////////////////
// 等同于：
// csharp // log//
//transform.position = transform.position + movement;
///////////////////////////////////////////////////////////////////////
//意思是： 👉 把当前的位置 + 移动的向量，得到新位置。
