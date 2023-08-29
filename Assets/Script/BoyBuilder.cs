using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoyBuilder : Builder
{
    public CharacterBuild Boy;
    public GameObject ObjeTransform;

    public override void PrepareChasis()
    {
        
        if (characterBuild != null)
        {
            Destroy(Boy);
        }

        characterBuild = Instantiate(Boy);
        characterModel = Instantiate(Boy.BoyPrefab,ObjeTransform.transform);
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
    {Debug.Log(characterBuild);
        if (Input.GetKeyDown(KeyCode.A))
        {
            PrepareChasis();
            BuildHair(1);
            BuildGlass(1);
            BuildPants(1);
        }
    }
}