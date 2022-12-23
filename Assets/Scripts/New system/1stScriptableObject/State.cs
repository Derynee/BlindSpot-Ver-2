using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Drawing;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    [SerializeField] Sprite storyImage;
    [SerializeField] State[] nextStates;
    [SerializeField] string Habitacion;
    [SerializeField] int Vista;

    public Sprite GetStateRoom()
    {
        return storyImage;
    }


    public State[] GetNextStates()
    {
        return nextStates;
    }

    public string GetHabitacion()
    {
        return Habitacion;
    }

    public int GetVista()
    {
        return Vista;
    }


}
