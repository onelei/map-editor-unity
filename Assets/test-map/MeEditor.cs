﻿using UnityEditor;
using UnityEngine;

//自定义Test脚本
[CustomEditor(typeof(Test))]
//请继承Editor
public class MeEditor : Editor
{
    public int TotalX = 28;
    public int TotalY = 28;
    public float mBiLi = 100;

    public MeEditor()
    {

    }

    void OnSceneGUI()
    {
        //得到test脚本的对象;
        Test test = (Test)target;
        //test.vectorPoint = Handles.FreeMoveHandle(test.vectorPoint,
        //                         Quaternion.identity,
        //                         2.0f,
        //                         Vector3.zero,
        //                         Handles.ArrowCap);
        //  test.vectorPoint = Handles.PositionHandle(test.vectorPoint,Quaternion.identity);
   
        Handles.color = Color.green;
        TotalX = test.getTotalX();
        TotalY = test.getTotalY();
        mBiLi = test.getDistance();
        // 画每一行;
        for (int i = 0; i != TotalX; ++i)
        {
            // 直立的;
           // Vector3 pos1 = new Vector3(0, i * mBiLi, 0);
           // Vector3 pos2 = new Vector3(TotalX * mBiLi, i * mBiLi, 0);
            Vector3 pos1 = new Vector3(0,0 , i * mBiLi);
            Vector3 pos2 = new Vector3(TotalX * mBiLi, 0, i * mBiLi);
            Handles.Label(pos1, "" + i);
            Handles.DrawLine(pos1, pos2);
        }
        // 画每一列;
        for (int i = 0; i != TotalY; ++i)
        {
            //Vector3 pos1 = new Vector3(i * mBiLi, 0, 0);
            //Vector3 pos2 = new Vector3(i * mBiLi, TotalX * mBiLi, 0);
            Vector3 pos1 = new Vector3(i * mBiLi, 0, 0);
            Vector3 pos2 = new Vector3(i * mBiLi, 0, TotalX * mBiLi);
            Handles.Label(pos1, "" + i);
            Handles.DrawLine(pos1, pos2);
        }

        
    }

}