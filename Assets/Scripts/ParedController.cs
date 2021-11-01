using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParedController : MonoBehaviour
{

    [SerializeField] float timerCambio = 0f;
    [SerializeField] GameObject[] respawnList;



    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay(Collider other)
    {

        Debug.Log(other.gameObject.name);

        if (other.tag.Equals("Player"))
        {

            timerCambio += Time.deltaTime;
            Debug.Log(timerCambio);
            if (timerCambio > 2)
            {
                Respawn();
                timerCambio = 0;
            }
        }
    }


    private void Respawn()
    {
        Debug.Log("Cambio de posicion!!");
        int i = Random.Range(0, respawnList.Length);

        gameObject.transform.position = respawnList[i].transform.position;
        gameObject.transform.rotation = respawnList[i].transform.rotation;

    }

}
