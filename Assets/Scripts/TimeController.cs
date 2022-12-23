using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimeController : MonoBehaviour
{
    [SerializeField] int hour, min, seg;
    [SerializeField] TMP_Text tiempo;

    private float restante;
    private bool enMarcha;

    private void Awake()
    {
        restante = (hour * 3600) + (min * 60) + seg;
        enMarcha = true;
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enMarcha)
        {
            restante -= Time.deltaTime;

            if (restante < 1)
            {
                //Pasar a Game Over
                enMarcha = false;
            }
            int tempHour = Mathf.FloorToInt(restante / 3600);
            int tempMin = Mathf.FloorToInt((-1 * (tempHour * 3600) + restante) / 60);
            int tempSeg = Mathf.FloorToInt((-1 *(tempHour * 3600) + restante) % 60);

            tiempo.text = string.Format("{00:00}:{01:00}:{02:00}", tempHour, tempMin, tempSeg);
        }

    }
}
