using UnityEngine;

public class FaceMouse2D : MonoBehaviour
{
    void Update()
    {
		//Gets the world position of the gameObject this is attached to and converts it to a screen position
        Vector3 pos = Camera.main.WorldToScreenPoint(transform.position);
		
		//Gets the vector between the mouse and the gameObject
        Vector3 dir = Input.mousePosition - pos;
		
		//Maths stuff to figure out the direction (for nerds)
        float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;	
		
		//sets the rotation of the gameObject to the calculated angle (the -90 can be adjusted if your gameobject is misaligned, this is just what works for me)
        transform.rotation = Quaternion.AngleAxis(angle-90, Vector3.forward);
    }
}
