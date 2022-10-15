using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class gunScript : MonoBehaviour
{

    [SerializeField] private GameObject losePanel;


  
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "barrel")
        {
            Time.timeScale = 0;
            losePanel.SetActive(true);
           
        }

       
    }

  
}
