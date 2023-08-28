using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyBuilder : Builder
{
    public CharacterBuild Boy;

    public override void PrepareChasis()
    {
        if (characterBuild != null)
        {
            Destroy(Boy.gameObject);
        }

        characterBuild = Instantiate(Boy);
    }

    public override void BuildHair(int type)
    {
        characterBuild.AddHair(type);
    }

    public override void BuildGlass(int type)
    {
        characterBuild.AddGlass(type);
    }

    public override void BuildPants(int type)
    {
        characterBuild.AddPants(type);
    }

    public override CharacterBuild GetProduct()
    {
        return characterBuild;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            PrepareChasis();
            BuildHair(1);
            BuildGlass(1);
            BuildPants(1 );
        }
    }
}