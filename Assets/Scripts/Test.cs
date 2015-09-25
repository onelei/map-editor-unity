using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Test : MonoBehaviour
{
    //public Vector3 vectorPoint = Vector3.zero;
    //public bool checkButton = true;
    public int x = 28;
    public int y = 28;
    public int distance = 100;
    public int getTotalX()
    {
        return x;
    }

    public int getTotalY()
    {
        return y;
    }

    public int getDistance()
    {
        return distance;
    }
    //void Update()
    //{
    //    transform.position = vectorPoint;
    //    if (checkButton)
    //        Debug.Log("The handle button has been pressed!");
    //}
}