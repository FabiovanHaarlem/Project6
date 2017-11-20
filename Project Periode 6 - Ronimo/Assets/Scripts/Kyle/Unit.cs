using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    string m_unitchoice;
    string m_unittype;

    public void SetUnitChoice(string choice)
    {
        m_unitchoice = choice;
    }

    public void SetUnitType(string choice)
    {
        m_unittype = choice;
    }
}
