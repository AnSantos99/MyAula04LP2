using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptTest : MonoBehaviour
{

    private Coroutine helloRot;

    WaitForSeconds wfs = new WaitForSeconds(4);

    WaitForSeconds wfss = new WaitForSeconds(1);

    private IEnumerator Hello() 
    {
        

        while (true) 
        {
            yield return wfs;

            Debug.Log("Hello");
        }
    }

    private IEnumerator Counter() 
    {
        WaitForSeconds wfss = new WaitForSeconds(1);
        int m = 0;

        while (true) 
        {
            Debug.Log(m);
            m++;

            if (m > 30)
                StopCoroutine(helloRot);
            yield return wfss;
        }
    }


    // Start is called before the first frame update
    private void Start()
    {
        helloRot = StartCoroutine(Hello());
        StartCoroutine(Counter());
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
}
