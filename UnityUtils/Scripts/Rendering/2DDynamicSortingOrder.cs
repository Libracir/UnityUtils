using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class 2DDynamicSortingOrder : MonoBehaviour
{
	//This script will make sure things render on top of each other the right way
	//for example something further up will render behind
	//and something further down will render in front
	
	//Don't have too many of these running at once, it might be a good idea to disable it when you're a certain distance away
	//Too many Update methods bad

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