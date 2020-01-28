using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Organism : MonoBehaviour , iCopyable
{
    public virtual iCopyable Copy()
    {
        return (iCopyable)Instantiate(this);
    }
}
