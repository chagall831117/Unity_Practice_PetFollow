using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet : MonoBehaviour
{
    public Transform Dragon;
    public Transform Spot;
    public Transform Man;
    // Start is called before the first frame update
    void Start()
    {
        Dragon = GetComponent<Transform>();
        Spot = GameObject.Find("Quad").GetComponent<Transform>();
        Man = GameObject.Find("野蠻人").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        Tracking();
        transform.LookAt(Man);
    }
    public void Tracking()
    {
        Dragon.position = Vector3.Lerp(Dragon.position, Spot.position,
            1f*Time.deltaTime);
    }
}
