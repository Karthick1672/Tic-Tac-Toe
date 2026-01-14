using UnityEngine;

public class Firework : MonoBehaviour
{
    public GameObject Fired;
    int i = 0;
    void Start()
    {
        i = Random.Range(0, 3);
        Invoke("fire", i);
    }

    
    void fire()
    {
        Instantiate(Fired,transform.position,Quaternion.identity);
        i = Random.Range(0, 3);
        Invoke("fire", i);
    }
}
