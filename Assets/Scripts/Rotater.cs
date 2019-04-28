using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater : MonoBehaviour {

    public float RotationSpeed = 1f;
    [SerializeField] private float RotationSpeed_2 = 1f;
    private Material myColor;

	// Use this for initialization
	void Start () {
        myColor = GetComponent<Renderer>().material;
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, Time.deltaTime * RotationSpeed, 0));
        myColor.color = new Color(Random.value, Random.value, Random.value);
    }
    
    void OnTriggerEnter(Collider other)
    {
        enabled = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }
}
