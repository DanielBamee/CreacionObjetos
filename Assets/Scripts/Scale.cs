using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    float speedScale = 5.0f;

    // Update is called once per frame
    void Update()
    {
        Vector3 newScale = transform.localScale;
        newScale += Vector3.one * Input.mouseScrollDelta.y * speedScale * Time.deltaTime;
        transform.localScale = newScale;
    }
}
