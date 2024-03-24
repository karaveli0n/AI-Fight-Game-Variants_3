using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class can_gostergesi : MonoBehaviour
{
    public Image can_bari;
 
    public void can_bar_metodu(float can, float tam_can)
    {
        can_bari.fillAmount = can / tam_can;
    }
}
