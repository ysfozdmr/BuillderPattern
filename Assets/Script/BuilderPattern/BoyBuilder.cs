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
            Destroy(characterBuild.gameObject);
        }

        characterBuild = Instantiate(Boy);
        characterModel = Instantiate(Boy.BoyPrefab,characterBuild.transform);
    }

    public override void BuildHair(int type)
    {
        characterBuild.AddHair(type,characterModel.GetComponent<Boy>().HairPlacement);
    }

    public override void BuildGlass(int type)
    {
        characterBuild.AddGlass(type,characterModel.GetComponent<Boy>().GlassPlacement);
    }

    public override void BuildPants(int type)
    {
        characterBuild.AddPants(type,characterModel.GetComponent<Boy>().PantsPlacement);
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
            BuildPants(1);
        }
    }
}