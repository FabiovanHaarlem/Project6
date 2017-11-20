using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Unit))]
public class UnitEditor : Editor
{
    public override void OnInspectorGUI()
    {
        GUILayout.Label("");
    }
}
