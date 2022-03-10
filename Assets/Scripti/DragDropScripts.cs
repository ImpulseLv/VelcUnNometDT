using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragDropScripts : MonoBehaviour , IPointerDownHandler, IBeginDragHandler, IDragHandler, IEndDragHandler {
	//Velkamajam objektam piestiprinata komponente
	private CanvasGroup kanvasGrupa;
	//Prieks parvietojama objekta atrasanas vietas uzglabsana
	private RectTransform velkObjRectTransf;
	//Norada uz objekta skriptu
	public Objekti objektuSkripts;

	// Use this for initialization
	void Start () {
		//Pieklust objekta piestiprinataja CanvasGroup komponentei
		kanvasGrupa = GetComponent<CanvasGroup> ();
		//Pieklust objekta RectTransform komponentei
		velkObjRectTransf = GetComponent<RectTransform>();

	}

	public void OnPointerDown(PointerEventData notikums){
		Debug.Log ("Uzklikstinats uz velkama objekta");

	}
	public void OnBeginDrag(PointerEventData notikums){
		Debug.Log ("Uzsakta vilksana!");

		//Velkot objektu tas paliek caurspidigs
		kanvasGrupa.alpha = 0.6f;
		//Lai objektam velkot iet cauri raycast stari
		kanvasGrupa.blocksRaycasts = false;
	}
	public void OnDrag(PointerEventData notikums){
		Debug.Log ("Notiek viksana!");
		//Nometot objektu atceras to ka pedejo vilkto
		objektuSkripts.pedejaisVilktais = notikums.pointerDrag;
		//Maina objekta x,y koordinates
		velkObjRectTransf.anchoredPosition += notikums.delta / objektuSkripts.kanva.scaleFactor;
	}
	public void OnEndDrag(PointerEventData notikums){
		Debug.Log ("Beigta objektu vilksana");
		kanvasGrupa.alpha = 1f;
		if (objektuSkripts.vaiIstajaVieta == false) {
			kanvasGrupa.blocksRaycasts = true;
		} else {
			//Aizmirst pedejo objektu,kas vilkts
			objektuSkripts.pedejaisVilktais = null;
		}
		//Ja viens objekts nolikts istaja vieta, tad lai varetu turpinat vilkt parejos iestata false
		objektuSkripts.vaiIstajaVieta = false;
}
}