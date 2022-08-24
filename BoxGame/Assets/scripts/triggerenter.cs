using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class triggerenter : MonoBehaviour
{
    
    public Text scoretext;
    private int x;


   
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag =="food")
        {   
            
            x++;
            scoretext.text = x.ToString();
            

        }
        
    }
}
