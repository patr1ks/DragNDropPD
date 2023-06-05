using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objekti : MonoBehaviour {
	public GameObject atkritumuMasina;
	public GameObject atraPalidziba;
	public GameObject autobuss;
	public GameObject b2;
	public GameObject CementaMasina;
	public GameObject e46;
	public GameObject e61;
	public GameObject Ekskavators;
	public GameObject Policija;
	public GameObject Traktors1;
	public GameObject Traktors5;
	public GameObject Ugunsdzeseji;

	public int NoliktasMasinas = 0;

	[HideInInspector]
	public Vector2 atkrMKoord;
	[HideInInspector]
	public Vector2 atrPKoord;
	[HideInInspector]
	public Vector2 bussKoord;
	[HideInInspector]
	public Vector2 b2Koord;
	[HideInInspector]
	public Vector2 CementaKoord;
	[HideInInspector]
	public Vector2 e46Koord;
	[HideInInspector]
	public Vector2 e61Koord;
	[HideInInspector]
	public Vector2 EkskavatorsKoord;
	[HideInInspector]
	public Vector2 PolicijaKoord;
	[HideInInspector]
	public Vector2 Traktors1Koord;
	[HideInInspector]
	public Vector2 Traktors5Koord;
	[HideInInspector]
	public Vector2 UgunsdzesejiKoord;

	public Canvas kanva;

	public AudioSource skanasAvots;
	public AudioClip[] skanasKoAtskanot;

	[HideInInspector]
	public bool vaiIstajaVieta = false;

	public GameObject pedejaisVilktais = null;


	void Start() {
		atkrMKoord = atkritumuMasina.GetComponent<RectTransform>().localPosition;
        
		atrPKoord = atraPalidziba.GetComponent<RectTransform>().localPosition;

        bussKoord = autobuss.GetComponent<RectTransform>().localPosition;

		b2Koord = b2.GetComponent<RectTransform>().localPosition;

		CementaKoord = CementaMasina.GetComponent<RectTransform>().localPosition;

		e46Koord = e46.GetComponent<RectTransform>().localPosition;

		e61Koord = e61.GetComponent<RectTransform>().localPosition;

		EkskavatorsKoord = Ekskavators.GetComponent<RectTransform>().localPosition;

		PolicijaKoord = Policija.GetComponent<RectTransform>().localPosition;

		Traktors1Koord = Traktors1.GetComponent<RectTransform>().localPosition;

		Traktors5Koord = Traktors5.GetComponent<RectTransform>().localPosition;

		UgunsdzesejiKoord = Ugunsdzeseji.GetComponent<RectTransform>().localPosition;
    }
	void Update(){
		Debug.Log(NoliktasMasinas);
	}
}
