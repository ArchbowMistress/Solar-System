using UnityEngine;

public class Planet1 : Planet
{
    void Start()
    {
        gravity = 5f;
    }

    public override void AttractMoons(){}
}
