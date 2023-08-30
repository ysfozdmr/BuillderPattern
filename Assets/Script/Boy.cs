using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boy : MonoBehaviour
{
    public GameObject HairPlacement;
    public GameObject GlassPlacement;
    public GameObject PantsPlacement;
    
    
    private Vector3 firstMousePositon;
    private float currentMagnitude;

    private float _threshold;
    private int screenWidth;
    private Quaternion firstRotation;
    private Quaternion targetRotation;
    private float fullSwipeAngle=360;
    private float rotationSpeed=2;
    private float thresholdScreenDivider=40;

    private void Start()
    {
        screenWidth = Screen.width;
        _threshold = screenWidth / thresholdScreenDivider;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            firstMousePositon = Input.mousePosition;
            firstRotation = gameObject.transform.rotation;
        }
        else if (Input.GetMouseButton(0))
        {
            currentMagnitude = Input.mousePosition.x - firstMousePositon.x;
            if (Mathf.Abs(currentMagnitude) > _threshold)
            {
                targetRotation =
                    firstRotation * Quaternion.Euler(0, currentMagnitude * fullSwipeAngle / screenWidth,0 );
                transform.rotation =
                    Quaternion.Lerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            targetRotation = transform.rotation;
        }
    }
}
