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
    public bool rojo = false;
    // Start is called before the first frame update
    void Start()
    {
        objetoCreado = Instantiate(prefabCube, Vector3.zero, Quaternion.identity);
        objetoCreado2 = Instantiate(prefabCube2, Vector3.zero, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.R))
        {
            rojo = true;
        }

        if (Input.GetKey(KeyCode.B))
        {
            rojo = false;
        }

        ////////////////////////////////////////////////////////////////////////////

        if (rojo == true)
        {
            objetoCreado2.SetActive(false);
            objetoCreado.SetActive(false);
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                objetoCreado.transform.position = hit.point;
            }
            objetoCreado.SetActive(true);
        }
        if (rojo == false)
        {
            objetoCreado.SetActive(false);
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
