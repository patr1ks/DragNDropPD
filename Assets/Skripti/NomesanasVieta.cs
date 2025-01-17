﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NomesanasVieta : MonoBehaviour, 
	IDropHandler{
	private float vietasZRot, velkObjZRot, rotacijasStarpiba;
	private Vector2 vietasIzm, velkObjIzm;
	private float xIzmStarpiba, yIzmStarpiba;
	public Objekti objektuSkripts;

    public void OnDrop(PointerEventData eventData)
    {
		if (eventData.pointerDrag != null)
		{
			if (eventData.pointerDrag.tag.Equals(tag))
			{
				vietasZRot =
				eventData.pointerDrag.
				GetComponent<RectTransform>().transform.eulerAngles.z;

				velkObjZRot =
				GetComponent<RectTransform>().transform.eulerAngles.z;

				rotacijasStarpiba =
				Mathf.Abs(vietasZRot - velkObjZRot);

				vietasIzm =
				eventData.pointerDrag.
				GetComponent<RectTransform>().localScale;

				velkObjIzm =
					GetComponent<RectTransform>().localScale;

				xIzmStarpiba = Mathf.Abs(vietasIzm.x - velkObjIzm.x);
				yIzmStarpiba = Mathf.Abs(vietasIzm.y - velkObjIzm.y);

				Debug.Log("Objektu rotācijas starpība: " + rotacijasStarpiba
					+ "\nPlatuma starpība: " + xIzmStarpiba +
					"\nAugstuma starpība: " + yIzmStarpiba);


				if ((rotacijasStarpiba <= 6 ||
					(rotacijasStarpiba >= 354 && rotacijasStarpiba <= 360))
					&& (xIzmStarpiba <= 0.1 && yIzmStarpiba <= 0.1))
				{
					Debug.Log("Nomests pareizajā vietā!");
                    objektuSkripts.vaiIstajaVieta = true;
                    eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition
						= GetComponent<RectTransform>().anchoredPosition;

					eventData.pointerDrag.GetComponent<RectTransform>().localRotation =
						GetComponent<RectTransform>().localRotation;

					eventData.pointerDrag.GetComponent<RectTransform>().localScale =
						GetComponent<RectTransform>().localScale;

					switch (eventData.pointerDrag.tag) {
					case "atkritumi":
						objektuSkripts.skanasAvots.PlayOneShot (
							objektuSkripts.skanasKoAtskanot [1]);
							objektuSkripts.NoliktasMasinas++;
							break;

						case "atrie":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[2]);
								objektuSkripts.NoliktasMasinas++;
							break;

						case "buss":
							objektuSkripts.skanasAvots.PlayOneShot(
								objektuSkripts.skanasKoAtskanot[3]);
								objektuSkripts.NoliktasMasinas++;
							break;

					case "b2":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[4]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "CementMasin":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[5]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "e46":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[6]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "e61":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[7]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "Ekskavators":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[8]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "Policija":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[9]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "Traktors1":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[10]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "Traktors5":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[11]);
							objektuSkripts.NoliktasMasinas++;
						break;

					case "Ugunsdzeseji":
						objektuSkripts.skanasAvots.PlayOneShot(
							objektuSkripts.skanasKoAtskanot[12]);
							objektuSkripts.NoliktasMasinas++;
						break;

						default:
							Debug.Log("Tags nav definēts!");
							break;
					}
				}

				//Ja tagi nesakrīt, tātad nepareizajā vietā
			} else	{
				objektuSkripts.vaiIstajaVieta = false;
				objektuSkripts.skanasAvots.PlayOneShot(
					objektuSkripts.skanasKoAtskanot[0]);

                switch (eventData.pointerDrag.tag){
                    case "atkritumi":
						objektuSkripts.atkritumuMasina.
						GetComponent<RectTransform>().localPosition =
						objektuSkripts.atkrMKoord;
                        break;

                    case "atrie":
                        objektuSkripts.atraPalidziba.
                        GetComponent<RectTransform>().localPosition =
                        objektuSkripts.atrPKoord;
                        break;

                    case "buss":
                        objektuSkripts.autobuss.
                         GetComponent<RectTransform>().localPosition =
                         objektuSkripts.bussKoord;
                        break;

				case "b2":
					objektuSkripts.b2.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.b2Koord;
					break;

				case "CementMasin":
					objektuSkripts.CementaMasina.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.CementaKoord;
					break;

				case "e46":
					objektuSkripts.e46.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.e46Koord;
					break;

				case "e61":
					objektuSkripts.e61.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.e61Koord;
					break;

				case "Ekskavators":
					objektuSkripts.Ekskavators.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.EkskavatorsKoord;
					break;

				case "Policija":
					objektuSkripts.Policija.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.PolicijaKoord;
					break;

				case "Traktors1":
					objektuSkripts.Traktors1.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.Traktors1Koord;
					break;

				case "Traktors5":
					objektuSkripts.Traktors5.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.Traktors5Koord;
					break;

				case "Ugunsdzeseji":
					objektuSkripts.Ugunsdzeseji.
					GetComponent<RectTransform>().localPosition =
						objektuSkripts.UgunsdzesejiKoord;
					break;

                    default:
                        Debug.Log("Tags nav definēts!");
                        break;
                }
            }
		}
		
	}
}
