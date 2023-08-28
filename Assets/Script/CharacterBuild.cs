using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuild : MonoBehaviour
{
    public GameObject BoyPrefab;
    public GameObject[] HairPrefabs;
    public GameObject[] GlassPrefabs;
    public GameObject[] PantPrefabs;

    public void AddHair(int type)
    {
        Instantiate(HairPrefabs[type], gameObject.transform);
    }

    public void AddGlass(int type)
    {
        Instantiate(GlassPrefabs[type], gameObject.transform);
    }

    public void AddPants(int type)
    {
        Instantiate(PantPrefabs[type], gameObject.transform);
    }

    public GameObject GetBoy()
    {
        return gameObject;
    }
}
