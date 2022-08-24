using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorescript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text scoretext;
    int x = 0;
    // Update is called once per frame
    void Update()
    {
        scoretext.text = x.ToString();
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "food")
        {
            x++;
            Destroy(gameObject);
        }

    }
}
