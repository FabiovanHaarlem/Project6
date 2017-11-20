using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitSelectManager : MonoBehaviour
{
    private UnitPool m_UnitPool;
    private UnitSpawnerManager m_Spawner;

	void Start ()
    {
        m_UnitPool = GetComponent<UnitPool>();
        m_Spawner = GetComponent<UnitSpawnerManager>();
	}
	
    public void SpawnUnit(string unitName)
    {
        GameObject unit = m_UnitPool.GetSelectedUnit(unitName);
        m_Spawner.SpawnUnit(unit);
    }

    public void SetUIElements()
    {
        Vector3 mousePosition = 
    }
}
