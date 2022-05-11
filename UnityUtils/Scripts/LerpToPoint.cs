using UnityEngine;

public class LerpToPoint : MonoBehaviour
{
    public float speed;
    public Vector3 position;
    private Vector3 start;
    private float time;

    private void Update()
    {
        if (time < 1) 
        {
            transform.postion = Vector3.Lerp(start.position, position, speed);
            time += Time.deltaTime * speed;
        }
    }


    public void MoveToPosition(Vector3 position)
    {
        start = new Vector3(this.transform.position);
        time = 0f;
        this.position = position;
    }
}