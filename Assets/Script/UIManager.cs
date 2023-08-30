using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private BoyBuilder _boyBuilder;
    private int hairType = 0;
    private int glassType = 0;
    private int pantType = 0;

    public void TakeHairType(int type)
    {
        hairType = type;
    }

    public void TakeGlassType(int type)
    {
        glassType = type;
    }

    public void TakePantType(int type)
    {
        pantType = type;
    }

    public void Build()
    {
        _boyBuilder.PrepareChasis();
        _boyBuilder.BuildHair(hairType);
        _boyBuilder.BuildGlass(glassType);
        _boyBuilder.BuildPants(pantType);
    }
}