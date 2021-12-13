using Unity.LEGO.Game;
using LEGOMaterials;
using LEGOModelImporter;
using System.Collections.Generic;
using Unity.LEGO.Behaviours.Triggers;
    
using Unity.LEGO.Minifig;
using UnityEngine;

namespace Unity.LEGO.Gameplay
{
    public class GroundHazard : MonoBehaviour
    {
        void OnTriggerEnter(Collider other) 
        {
            if(other.gameObject.CompareTag("Player"))
            {
                var minifigController = other.GetComponent<MinifigController>();
                if (minifigController)
                {
                    minifigController.Explode();
                }
                


                Debug.Log("player hitting");
                GameOverEvent evt = Events.GameOverEvent;
                evt.Win = false;
                EventManager.Broadcast(evt);
            }
        }
    }
}