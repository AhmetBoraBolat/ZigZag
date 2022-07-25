using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundColorController : MonoBehaviour
{
    [SerializeField] private Material groundMaterial;

    [SerializeField] private Color[] colors;

    private int ColorIndex = 0;

    [SerializeField] private float lerpValue;

    [SerializeField] private float time;

    private float currentTime;

    void Update()
    {
        SetColorChangeTimes();
        SetGroundChangeColor();
    }

    private void SetColorChangeTimes()
    {
        if(currentTime <= 0)
        {
            CheckColorIndex();
            currentTime = time;
        }
        else
        {
            currentTime -= Time.deltaTime;
        }
    }

    private void CheckColorIndex()
    {
        ColorIndex++;
        if(ColorIndex>= colors.Length)
        {
            ColorIndex = 0;
        }
    }

    private void SetGroundChangeColor() 
    {
        groundMaterial.color = Color.Lerp(groundMaterial.color, colors[ColorIndex], lerpValue * Time.deltaTime);
    }

    private void OnDestroy()
    {
        groundMaterial.color = colors[1];
    }
}
