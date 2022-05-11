using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class 2DStaticSortingOrder : MonoBehaviour
{
	//This script will make sure things render on top of each other the right way
	//for example something further up will render behind
	//and something further down will render in front
	
	//This Version will only run once, meaning it should be used for Objects that don't move in your scene
	
    SpriteRenderer renderer;

    private void Start()
    {
        renderer = this.GetComponent<SpriteRenderer>();
		renderer.sortingOrder = (int)(renderer.transform.position.y * -100);
    }
}