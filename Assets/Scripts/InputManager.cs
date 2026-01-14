using UnityEngine;

public class InputManager : MonoBehaviour
{

    public GameObject effect;


    void Update()
    {
        // Old Input Method
        // to get Touch as Input
        if (Input.touchCount > 0)
        {

            // get values as (720,1600)pixel in (x,y)
            Touch touch = Input.GetTouch(0);
            
            // converts pixel to vector3 (x,y,z);
            Vector3 pos = Camera.main.ScreenToWorldPoint(touch.position);
            
            pos.z = 0f;
            Instantiate(effect, pos, Quaternion.identity);
            
        }
    }
}
