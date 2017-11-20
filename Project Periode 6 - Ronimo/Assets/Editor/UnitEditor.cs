using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(Unit))]
public class UnitEditor : Editor
{
    //Melee = 0, Ranged = 1;
    string[] m_unitrange = new string[] { "Melee", "Ranged" };
    string[] m_meleetypes = new string[] { "Collecter", "Swordmaster" };
    string[] m_rangedtypes = new string[] { "Spellcaster", "Archer" };

    string m_prefabname = "";

    int m_unitrangechoice = 0;
    int m_unitmeleetypechoice = 0;
    int m_unitrangetypechoice = 0;
    Unit m_unitscript;

    void OnEnable()
    {
        m_unitscript = (Unit)target;
    }

    [MenuItem("Editor/Unit Editor")]

    public override void OnInspectorGUI()
    {
        //Draw The Default Inspector
        DrawDefaultInspector();
        EditorGUILayout.LabelField("Unit Range");
        m_unitrangechoice = EditorGUILayout.Popup(m_unitrangechoice, m_unitrange);
        Unit unit = target as Unit;
        //Update The Selected Choice
        unit.SetUnitChoice(m_unitrange[m_unitrangechoice]);

        switch (m_unitrangechoice)
        {
            //Melee
            case 0:
                EditorGUILayout.LabelField("Melee Type");
                m_unitmeleetypechoice = EditorGUILayout.Popup(m_unitmeleetypechoice, m_meleetypes);
                unit.SetUnitType(m_meleetypes[m_unitmeleetypechoice]);
                EditorUtility.SetDirty(target);
                break;

            //Ranged
            case 1:
                EditorGUILayout.LabelField("Ranged Type");
                m_unitrangetypechoice = EditorGUILayout.Popup(m_unitrangetypechoice, m_rangedtypes);
                unit.SetUnitType(m_rangedtypes[m_unitrangetypechoice]);
                EditorUtility.SetDirty(target);
                break;
        }

        EditorGUILayout.LabelField("Prefab Name");
        m_prefabname = EditorGUILayout.TextField(m_prefabname);

        if (GUILayout.Button("Generate Unit"))
        {
            GameObject newunit = new GameObject();
            newunit.AddComponent<UnitStats>();
            //newunit.GetComponent<UnitStats>().m_rangetype = (UnitStats.RangeType)m_unitrangechoice;
            //newunit.GetComponent<UnitStats>().m_meleeunittype = (UnitStats.MeleeUnitType)m_unitmeleetypechoice;
            //newunit.GetComponent<UnitStats>().m_rangedunittype = (UnitStats.RangedUnitType)m_unitrangetypechoice;

            PrefabUtility.CreatePrefab("Assets/Resources/Prefabs/UnitPrefabs/" + m_prefabname + ".prefab", newunit);
        }
    }
}