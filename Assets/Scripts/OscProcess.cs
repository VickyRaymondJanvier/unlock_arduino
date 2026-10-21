using extOSC;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class OscProcess : MonoBehaviour
{
    public OSCReceiver oscReceiver;
    public OSCTransmitter oscTransmitter;
    public Unlock unlock;
    // Start is called before the first frame update
    void Start()
    {
        oscReceiver.Bind("/valider", TraiterMessageAlpha);
        oscReceiver.Bind("/tourner", TraiterMessageAlpha);
    }

    // Update is called once per frame
    void TraiterMessageAlpha(OSCMessage message)
    {
        {
            // Traiter un entier booléen (évènement discret)

            // Récupérer la valeur du premier argument en taant qu’entier :
            int valeur = message.Values[0].IntValue;

            // Deboguer
            // Debug.Log("Reçu : " + message.Address + " " + valeur);

            // Traiter la valeur
            if (valeur == 0)
            {
                // Si nécéssaire, appeler une fonction ici
            }
            else
            {
                // Si nécéssaire, appeler une fonction ici
            }

        }


    }
}

