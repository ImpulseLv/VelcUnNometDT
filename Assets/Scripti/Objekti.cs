using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	//Uzglaa aina esoso kanvu
	public Canvas kanva;
	//GameObject kas uzglabas velkamos objektus
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject cementaMasina;
	public GameObject b2;
	public GameObject e46;
	public GameObject Eskavators;
	public GameObject policijasAuto;
	public GameObject Traktors1;
	public GameObject Traktors2;
	public GameObject ugunsDzesejMasina;

	//Uzglaba velkamo objektu sakotnekas atasanas vietas koordinates
	[HideInInspector]
	public Vector2 atkrKoord;
	[HideInInspector]
	public Vector2 atroKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 cementKoord;
	[HideInInspector]
	public Vector2 traktors1Koord;
	[HideInInspector]
	public Vector2 traktors2Koord;
	[HideInInspector]
	public Vector2 policijasAutoKoord;
	[HideInInspector]
	public Vector2 eskavatorsKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 b2Koord;

	//Uzglaba audio avotu, kura atskanot attelu skanas efektus
	public AudioSource skanasAvots;
	//Masivs kas uzglaba visas iespejamas skanas
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;

	// Use this for initialization
	void Start () {
		atkrKoord = atkritumuMasina.GetComponent<RectTransform> ().localPosition;
		atroKoord = atraPalidziba.GetComponent<RectTransform> ().localPosition;
		bussKoord = autobuss.GetComponent<RectTransform> ().localPosition;
		cementKoord = cementaMasina.GetComponent<RectTransform> ().localPosition;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
