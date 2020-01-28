using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Client : MonoBehaviour
{
    public Spawner m_Spawner;

    // Update is called once per frame
    void Update()
    {
        //for (int i = 0; i < 599; i++)
        //{
        //    m_Spawner.SpawnForest();
        //    m_Spawner.count++;
        //}
        if (Input.GetKeyDown(KeyCode.S))
        {
            m_Spawner.SpawnForest();
            m_Spawner.count++;
        }
    }

}