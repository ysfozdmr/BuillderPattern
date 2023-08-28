using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Builder : MonoBehaviour
{
    protected CharacterBuild characterBuild = null;

    public virtual void PrepareChasis()
    {
    }

    public virtual void BuildHair(int type)
    {
    }

    public virtual void BuildGlass(int type)
    {
    }

    public virtual void BuildPants(int type)
    {
    }

    public virtual CharacterBuild GetProduct()
    {
        return null;
    }
}