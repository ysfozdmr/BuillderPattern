using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBuild : MonoBehaviour
{
    public GameObject BoyPrefab;
    public GameObject[] HairPrefabs;
    public GameObject[] GlassPrefabs;
    public GameObject[] PantPrefabs;


    public void AddHair(int type,GameObject HairPlace)
    {
        Instantiate(HairPrefabs[type], HairPlace.transform);
    }

    public void AddGlass(int type,GameObject GlassPlace)
    {
        Instantiate(GlassPrefabs[type], GlassPlace.transform);
    }

    public void AddPants(int type,GameObject PantsPlace)
    {
        Instantiate(PantPrefabs[type], PantsPlace.transform);
    }

    public GameObject GetBoy()
    {
        return gameObject;
    }
}
