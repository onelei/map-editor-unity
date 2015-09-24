//using UnityEngine;  
//using UnityEditor;
//using System.Collections;
//using System;
//using System.Text;

//[CustomEditor(typeof(SceneTag))]
//public class SceneEditor : Editor
//{


//    void OnEnable()
//    {
//    }

//    void OnDisable()
//    {

//    }

//    void OnDestroy()
//    {

//    }

//    void OnInspectorGUI()
//    {
//    }

//    void OnSceneGUI()
//    {
//        Test_Handles();
//        Test_Event();
//    }

//    private static void Test_Event()
//    {
//        Vector2 mousePosition = Event.current.mousePosition;
//        StringBuilder sb = new StringBuilder();
//        sb.AppendFormat("({0},{1})"
//            , mousePosition.x
//            , mousePosition.y);
//        //Debug.Log(sb.ToString());  
//    }

//    private void Test_Handles()
//    {
//        SceneTag scene = target as SceneTag;
//        Test_Color(scene);
//        //Test_Button(scene);  
//        Test_ArrowCap(scene);
//        Test_CircleCap(scene);
//        Test_ChangeValue(scene);
//        Test_DrawAAPolyLine(scene);
//        Test_DrawSolidArc(scene);
//        Test_ScaleValueHandle(scene);
//        Test_FreeRotateHandle(scene);
//        Test_FreeMoveHandle(scene);
//        Test_BeginGUI(scene);

//        if (GUI.changed)
//            EditorUtility.SetDirty(target);
//    }

//    private static void Test_FreeMoveHandle(SceneTag scene)
//    {
//        scene.vectorPoint = Handles.FreeMoveHandle(scene.vectorPoint,
//                                  Quaternion.identity,
//                                  2.0f,
//                                  Vector3.zero,
//                                  Handles.ArrowCap);
//    }

//    private static void Test_FreeRotateHandle(SceneTag scene)
//    {
//        scene.transform.rotation = Handles.FreeRotateHandle(scene.transform.rotation, scene.transform.position, 0.5f);
//    }

//    private static void Test_ScaleValueHandle(SceneTag scene)
//    {
//        scene.shieldArea
//                  = Handles.ScaleValueHandle(scene.shieldArea,
//                                  scene.transform.position + scene.transform.forward * scene.shieldArea,
//                                  scene.transform.rotation,
//                                  1,
//                                  Handles.ConeCap,
//                                  1);
//    }

//    private static void Test_DrawSolidArc(SceneTag scene)
//    {
//        Handles.color = new Color(1, 1, 1, 0.2f);
//        Handles.DrawSolidArc(scene.transform.position,
//                scene.transform.up,
//                -scene.transform.right,
//                270,
//                scene.shieldArea);
//        Handles.color = Color.white;
//        scene.shieldArea =
//        Handles.ScaleValueHandle(scene.shieldArea,
//                        scene.transform.position + scene.transform.forward * scene.shieldArea,
//                        scene.transform.rotation,
//                        1,
//                        Handles.ConeCap,
//                        1);
//    }

//    private static void Test_DrawAAPolyLine(SceneTag scene)
//    {
//        Vector3[] positions = new Vector3[]  
//        {  
//            new Vector3(2,0,0),  
//            new Vector3(2,1,0),  
//            new Vector3(2,1,1),  
//            new Vector3(1,2,1),  
//            new Vector3(1,2,2),  
//        };
//        for (int i = 0; i < positions.Length; ++i)
//        {
//            positions[i] += scene.transform.position;
//        }
//        Handles.DrawAAPolyLine(positions);
//    }

//    private static void Test_ChangeValue(SceneTag scene)
//    {
//        scene.rot =
//                     Handles.Disc(scene.rot,
//                             scene.transform.position,
//                             new Vector3(1, 1, 0),
//                             5,
//                             false,
//                             1);
//        scene.vectorPoint = Handles.DoPositionHandle(scene.vectorPoint, Quaternion.identity);
//        scene.vectorPoint2 = Handles.DoPositionHandle(scene.vectorPoint2, Quaternion.identity);
//    }

//    private static void Test_CircleCap(SceneTag scene)
//    {
//        float circleSize = 1;
//        Handles.color = Color.red;
//        Handles.CircleCap(0,
//                scene.transform.position + new Vector3(5, 0, 0),
//                scene.transform.rotation,
//                circleSize);
//        Handles.color = Color.green;
//        Handles.CircleCap(0,
//                scene.transform.position + new Vector3(0, 5, 0),
//                scene.transform.rotation,
//                circleSize);
//        Handles.color = Color.blue;
//        Handles.CircleCap(0,
//                scene.transform.position + new Vector3(0, 0, 5),
//                scene.transform.rotation,
//                circleSize);

//        Handles.color = Color.red;
//        Vector3 newpos = scene.transform.position + new Vector3(5, 0, 0);
//        circleSize = HandleUtility.GetHandleSize(newpos);
//        Handles.CircleCap(0,
//                newpos,
//                scene.transform.rotation,
//                circleSize);
//        Handles.color = Color.green;
//        newpos = scene.transform.position + new Vector3(0, 5, 0);
//        circleSize = HandleUtility.GetHandleSize(newpos);
//        Handles.CircleCap(0,
//                newpos,
//                scene.transform.rotation,
//                circleSize);
//        Handles.color = Color.blue;
//        newpos = scene.transform.position + new Vector3(0, 0, 5);
//        circleSize = HandleUtility.GetHandleSize(newpos);
//        Handles.CircleCap(0,
//                newpos,
//                scene.transform.rotation,
//                circleSize);

//    }

//    //note by kun 2014.2.18  
//    // 这玩意有啥用？巨难操作！;  
//    // 3D按钮还会因为视角问题呈现不一样的大小。;  
//    // 而且按钮的当前状态也更新不及时，逗么？;  
//    private static void Test_Button(SceneTag scene)
//    {
//        Handles.Button(scene.transform.position + new Vector3(0, 2, 0),
//                              Quaternion.identity,
//                              3,
//                              3,
//                              Handles.RectangleCap);
//    }

//    private static void Test_BeginGUI(SceneTag scene)
//    {
//        Handles.color = Color.blue;
//        Handles.Label(scene.transform.position + Vector3.up * 2,
//                scene.transform.position.ToString() + "\nShieldArea: " +
//                scene.shieldArea.ToString());

//        Handles.color = Color.red;
//        Handles.DrawWireArc(scene.transform.position,
//                scene.transform.up,
//                -scene.transform.right,
//                180,
//                scene.shieldArea);
//        scene.shieldArea =
//        Handles.ScaleValueHandle(scene.shieldArea,
//                        scene.transform.position + scene.transform.forward * scene.shieldArea,
//                        scene.transform.rotation,
//                        1,
//                        Handles.ConeCap,
//                        1);

//        //comment by kun 2014.2.18  
//        // GUI相关的绘制需要在Handles的绘制之后，否则会被覆盖掉;  
//        // 使用Handles.BeginGUI会导致无法旋转摄像机，原因不详;  
//        GUILayout.BeginArea(new Rect(Screen.width - 100, Screen.height - 80, 90, 50));
//        //Handles.BeginGUI(new Rect(Screen.width - 100, Screen.height - 80, 90, 50));  
//        try
//        {
//            float a = float.Parse(GUILayout.TextField(scene.shieldArea.ToString()));
//            scene.shieldArea = a;
//        }
//        catch (System.Exception ex)
//        {

//        }
//        if (GUILayout.Button("Reset Area"))
//            scene.shieldArea = 5;
//        //Handles.EndGUI();  
//        GUILayout.EndArea();
//    }

//    private static void Test_ArrowCap(SceneTag scene)
//    {
//        float arrowSize = 1;
//        Handles.color = Color.red;
//        Handles.ArrowCap(0,
//                scene.transform.position + new Vector3(5, 0, 0),
//                scene.transform.rotation,
//                arrowSize);
//        Handles.color = Color.green;
//        Handles.ArrowCap(0,
//                scene.transform.position + new Vector3(0, 5, 0),
//                scene.transform.rotation,
//                arrowSize);
//        Handles.color = Color.blue;
//        Handles.ArrowCap(0,
//                scene.transform.position + new Vector3(0, 0, 5),
//                scene.transform.rotation,
//                arrowSize);
//    }

//    private void Test_Color(SceneTag scene)
//    {
//        Handles.color = Color.magenta;
//        scene.vectorPoint = Handles.Slider(scene.vectorPoint,
//                                Vector3.zero - scene.transform.position);
//    }

//}