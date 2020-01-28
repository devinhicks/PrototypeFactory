using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public Organism SpawnType(Organism prototype)
    {
        iCopyable m_Copy = prototype.Copy();
        return (Organism)m_Copy;
    }
}