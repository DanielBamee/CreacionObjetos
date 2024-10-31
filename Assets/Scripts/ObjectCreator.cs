using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectCreator : MonoBehaviour
{
    [SerializeField]
    GameObject prefabCube;
    GameObject objetoCreado;
    [SerializeField]
    GameObject prefabCube2;
    GameObject objetoCreado2;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("R"))
        {
            objetoCreado2.SetActive(false);
            objetoCreado = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
            objetoCreado.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                objetoCreado.transform.position = hit.point;
            }
            objetoCreado.SetActive(true);
        }

        if (Input.GetKeyDown("B"))
        {
            objetoCreado.SetActive(false);
            objetoCreado2 = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
            objetoCreado2.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                objetoCreado2.transform.position = hit.point;
            }
            objetoCreado2.SetActive(true);
        }
    }
}
