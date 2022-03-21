using System.Collections;
using System.Collections.Generic;
//Importe,lai varetu ieladet ainas
using UnityEngine.SceneManagement;
using UnityEngine;

public class IzvelneScript : MonoBehaviour {
	//Izdarot klikski uz pogas "UzAinu", tiks atverta aina "1"
	public void uzIzvelni(){
		SceneManager.LoadScene ("Pilseta", LoadSceneMode.Single);
		//Drikst nosaukuma izmantot ari kartas indeksu

	}
}
