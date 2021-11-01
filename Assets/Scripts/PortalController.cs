using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalController : MonoBehaviour
{


    private bool crecer;

    // Start is called before the first frame update
    void Start()
    {
        crecer = true;
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log(other.gameObject.name);
        GameObject Objeto = other.gameObject;

        AccionPortal(Objeto);
    }

    private void AccionPortal(GameObject Objeto)
    {

        Debug.Log(crecer);
        Vector3 tam = Objeto.transform.localScale;

        if (crecer)
        {
            Objeto.transform.localScale = tam * 2;
            Objeto.transform.Translate(Objeto.transform.localScale.z * new Vector3(0, 0, Input.GetAxisRaw("Vertical")));
        }
        else
        {
            Objeto.transform.localScale = tam / 2;
            Objeto.transform.Translate(Objeto.transform.localScale.z * new Vector3(0, 0, Input.GetAxisRaw("Vertical")));
        }
    
        crecer = !crecer;
    }




}
