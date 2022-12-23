using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActivePrueba : MonoBehaviour
{
    public GameObject activeGameObject;

    [SerializeField] string Habitacion;
    [SerializeField] int Vista;
    //[SerializeField] State startingState;
    //State state;
    public WallMain ReferenciaWallMain;


    // Start is called before the first frame update
    void Start()
    {
        //state = ReferenciaWallMain.state;


        //Debug.Log(ReferenciaWallMain.state.GetHabitacion());
    }
    private void Update()
    {
        if (Habitacion == ReferenciaWallMain.state.GetHabitacion() && Vista == ReferenciaWallMain.state.GetVista())
        {
            activeGameObject.SetActive(true);
        }
        else
        {
            activeGameObject.SetActive(false);  
        }
    }

    // Update is called once per frame
    public void ActivarColliders(int i)
    {
            if (Habitacion == ReferenciaWallMain.state.GetHabitacion() && Vista ==  ReferenciaWallMain.state.GetVista())
            {
                ReferenciaWallMain.ColliderState(i);
            }
    }
}
