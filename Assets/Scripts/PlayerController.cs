using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float velocidadPlayer = 10f;
    [SerializeField] private float giroPlayer = 0f;


    private Rigidbody rbPlayer;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        Mover();
    }

    private void Mover()
    {

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Girando con A");
            giroPlayer -= Time.deltaTime * velocidadPlayer * 10;
            transform.rotation = Quaternion.Euler(0, giroPlayer, 0);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Debug.Log("Girando con D");
            giroPlayer += Time.deltaTime * velocidadPlayer * 10;
            transform.rotation = Quaternion.Euler(0, giroPlayer, 0);
        }



        float ejeVertical = Input.GetAxisRaw("Vertical");
        transform.Translate(velocidadPlayer * Time.deltaTime * new Vector3(0, 0, ejeVertical));
    }


}
