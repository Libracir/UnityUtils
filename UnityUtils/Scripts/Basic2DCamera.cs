using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basic2DCamera : MonoBehaviour
{
	//GameObject you want the Camera to follow
    public Transform lookAt;
	
	//Amount you can move in each direction before the camera starts to follow
    public float boundX = 0.15f;
    public float boundY = 0.05f;

    private void LateUpdate()
    {
        Vector3 temp = Vector3.zero;
		
		//X calculation
        float posX = lookAt.position.x - transform.position.x;
        if (posX > boundX || posX < -boundX)
        {
            if (transform.position.x < lookAt.position.x)
            {
                temp.x = posX - boundX;
            }
            else
            {
                temp.x = posX + boundX;
            }
        }
		
		//Y calculation
        float posY = lookAt.position.y - transform.position.y;
        if (posY > boundY || posY < -boundY)
        {
            if (transform.position.y < lookAt.position.y)
            {
                temp.y = posY - boundY;
            }
            else
            {
                temp.y = posY + boundY;
            }
        }

		//Moves the Camera
        transform.position =  new Vector3(temp.x += transform.position.x,temp.y += transform.position.y, transform.position.z);
    }
}
