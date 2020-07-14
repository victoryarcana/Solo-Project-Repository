using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class RotateGameObject : MonoBehaviour
{
    //A Vector3 is an array (list) of values, corresponding to X, Y, Z in 3D space
    private Vector3 _speed = new Vector3 (1, 0, 0);
    
    //Start is called once at the beginning of runtime
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_speed);
    }
}
