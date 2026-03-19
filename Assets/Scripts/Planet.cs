using System.Collections.Generic;
using UnityEngine;

public abstract class Planet : MonoBehaviour
{
    public float gravity = 9.8f;
    public List<Moon> moons = new List<Moon>();

    public virtual void AttractMoons(){}
}
