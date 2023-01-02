using UnityEngine;

public class tesztszkript : MonoBehaviour
{
    static uint a = 2;
    uint b = a << 3;
    void Start()
    {
        Debug.Log("A b erteke: "+b);
    }
}