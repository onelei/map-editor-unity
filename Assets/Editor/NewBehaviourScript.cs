
using UnityEngine;
using System.Collections;
using UnityEditor;
 
public class NewBehaviourScript : Editor {
 
	[DrawGizmo(GizmoType.SelectedOrChild | GizmoType.NotSelected)]
	static void DrawGameObjectName(Transform transform, GizmoType gizmoType)
	{   
		Handles.Label(transform.position, transform.gameObject.name);
	}
}