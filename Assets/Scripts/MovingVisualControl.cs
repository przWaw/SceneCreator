using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingVisualControl : MonoBehaviour
{
    [SerializeField] private GameObject move;
    [SerializeField] private GameObject scale;

    public void HideAll()
    {
        move.SetActive(false);
        scale.SetActive(false);
    }

    public void ShowMove()
    {
        HideAll();
        move.SetActive(true);
    }

    public void ShowScale()
    {
        HideAll();
        scale.SetActive(true);
    }
}
