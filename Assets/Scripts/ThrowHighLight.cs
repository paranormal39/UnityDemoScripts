using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowHighLight : MonoBehaviour
{
    public Material shader, material;
    Renderer rend;
    public GameObject player;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();

    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.gameObject.transform.position, player.transform.position);
        if (distance < 20)
        {
            rend.material = shader;
        }
        else if (distance > 20)
        {
            rend.material = material;
        }
        
    }
}
