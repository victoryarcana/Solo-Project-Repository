using UnityEngine;

public class MoveGameObject : MonoBehaviour
{
    // The speed that the GameObject will move
    private float _speed = 3;
    
    // Update is called once per frame
    void Update()
    {
        // Move the GameObject to the right this frame
        transform.position += (Vector3.right * _speed) * Time.deltaTime;
             
    }
}
