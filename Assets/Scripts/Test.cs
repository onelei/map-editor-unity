using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class Test : MonoBehaviour
{
    public Vector3 vectorPoint = Vector3.zero;
    public bool checkButton = true;

    void Update()
    {
        transform.position = vectorPoint;
        if (checkButton)
            Debug.Log("The handle button has been pressed!");
    }
}