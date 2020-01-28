using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Factory m_Factory;

    public Organism m_Mushroom;
    public Organism m_Plant;
    public Organism m_PineTree;
    public Organism m_BigTree;

    public int count = 0;

    public void SpawnForest()
    {
        m_Mushroom = (Organism)Resources.Load("Mushroom", typeof(Organism));
        m_Mushroom = m_Factory.SpawnType(m_Mushroom);
        m_Mushroom.name = "Mushroom_" + count;
        m_Mushroom.transform.Translate(getRand(), 0, getRand());

        m_Plant = (Organism)Resources.Load("Plant", typeof(Organism));
        m_Plant = m_Factory.SpawnType(m_Plant);
        m_Plant.name = "Plant_" + count;
        m_Plant.transform.Translate(getRand(), 0, getRand());

        m_PineTree = (Organism)Resources.Load("PineTree", typeof(Organism));
        m_PineTree = m_Factory.SpawnType(m_PineTree);
        m_PineTree.name = "PineTree_" + count;
        m_PineTree.transform.Translate(getRand(), 0, getRand());

        m_BigTree = (Organism)Resources.Load("Tree", typeof(Organism));
        m_BigTree = m_Factory.SpawnType(m_BigTree);
        m_BigTree.name = "BigTree_" + count;
        m_BigTree.transform.Translate(getRand(), 0, getRand());
    }

    public float getRand()
    {
        return Random.Range(-20.0f, 20.0f);
    }
}
