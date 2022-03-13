using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour,IDropHandler {
	//Uzglabas velkama objekta un nomesana lauka z rotaciju, ka ari rotacijas un izmeru pielaujamo starpibu
	private float vietasZrot,velkObjZrot,rotacijasStarpiba;
	private Vector2 vietasIzm,velkObjIzm;
	private float xIzmeruStarp,yIzmeruStarp;
	//Norade uz Objekti skriptu
	public Objekti objektuSkripts;

	//Nostradas, ja objektu censas nomest uz jebkuras nomesanas vietas
	public void OnDrop(PointerEventData notikums){
		//Parbauda vai tika vilkt un atlaists vispar kads objekts
		if(notikums.pointerDrag != null){
			//Ja nomesanas vietas tags sakrit ar vilkta obektu tagu
			if (notikums.pointerDrag.tag.Equals (tag)) {
				//Iegust objekta rotaciju grados
				vietasZrot = notikums.pointerDrag.GetComponent<RectTransform> ().eulerAngles.z;
				velkObjZrot = GetComponent<RectTransform> ().eulerAngles.z;
				//Aprekina abu objekta z rotacijas starpibu
				rotacijasStarpiba = Mathf.Abs (vietasZrot - velkObjZrot);
				//Lidzigi ka ar Z rotaciju japiefikse objektu izmeri pa x un y asim,ka ari starpiba
				vietasIzm = notikums.pointerDrag.GetComponent<RectTransform> ().localScale;
				velkObjIzm = GetComponent<RectTransform> ().localScale;
				xIzmeruStarp = Mathf.Abs (vietasIzm.x - velkObjIzm.x);
				yIzmeruStarp = Mathf.Abs (vietasIzm.y - velkObjIzm.y);


				//Parbauda vai objektu rotacijas un izmeru starpiba ir pielaujams robezas
				if ((rotacijasStarpiba <= 6 || (rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360)) && (xIzmeruStarp <= 0.1 && yIzmeruStarp <= 0.1)) {
					objektuSkripts.vaiIstajaVieta = true;
					//Noliktais objekts iecentrejas nomesana lauka
					notikums.pointerDrag.GetComponent<RectTransform> ().anchoredPosition = GetComponent<RectTransform> ().anchoredPosition;
					notikums.pointerDrag.GetComponent<RectTransform> ().localRotation = GetComponent<RectTransform> ().localRotation;
					notikums.pointerDrag.GetComponent<RectTransform> ().localScale = GetComponent<RectTransform> ().localScale;

					//Parbauda tagu un atskano atbilstosu skanas efektu
					switch (notikums.pointerDrag.tag) {
					case "Atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [1]);
						break;
					case "Slimnica":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [2]);
						break;
					case "Skola":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [3]);
						break;
					case "Traktors2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [7]);
						break;
					case "Traktors1":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [6]);
						break;
					case "Cements":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [3]);
						break;
					case "B2":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [8]);
						break;
					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [8]);
						break;
					case "Eskavators":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [9]);
						break;
					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [8]);
						break;
					case "UgunsDzesejs":
						objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [9]);
						break;
					default:
						Debug.Log ("nederigs tags!");
						break;
					}
				}
				//Ja objekt nomest nepareizaja vieta
			} else {
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot (objektuSkripts.skanasKoAtskanot [0]);

				switch (notikums.pointerDrag.tag) {
				case "Atkritumi":
					objektuSkripts.atkritumuMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.atkrKoord;
					break;
				case "Slimnica":
					objektuSkripts.atraPalidziba.GetComponent<RectTransform> ().localPosition = objektuSkripts.atroKoord;
					break;
				case "Skola":
					objektuSkripts.autobuss.GetComponent<RectTransform> ().localPosition = objektuSkripts.bussKoord;
					break;
				case "Traktors2":
					objektuSkripts.Traktors2.GetComponent<RectTransform> ().localPosition = objektuSkripts.traktors2Koord;
					break;
				case "Traktors1":
					objektuSkripts.Traktors1.GetComponent<RectTransform> ().localPosition = objektuSkripts.traktors1Koord;
					break;
				case "Cements":
					objektuSkripts.cementaMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.cementKoord;
					break;
				case "B2":
					objektuSkripts.b2.GetComponent<RectTransform> ().localPosition = objektuSkripts.b2Koord;
					break;
				case "e46":
					objektuSkripts.e46.GetComponent<RectTransform> ().localPosition = objektuSkripts.e46Koord;
					break;
				case "Eskavators":
					objektuSkripts.Eskavators.GetComponent<RectTransform> ().localPosition = objektuSkripts.eskavatorsKoord;
					break;
				case "Policija":
					objektuSkripts.policijasAuto.GetComponent<RectTransform> ().localPosition = objektuSkripts.policijasAutoKoord;
					break;
				case "UgunsDzesejs":
					objektuSkripts.ugunsDzesejMasina.GetComponent<RectTransform> ().localPosition = objektuSkripts.dzesejaKoord;
					break;
				default:
					Debug.Log ("nederigs tags!");
					break;
				}
			}
		}
	}
}
