using UnityEngine;

public class Planet2 : Planet
{
    void Start()
    {
        gravity = 10f;
    }

    public override void AttractMoons(){}
}
