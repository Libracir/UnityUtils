using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class 2DDynamicSortingOrder : MonoBehaviour
{

    SpriteRenderer renderer;

    private void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
    }
}