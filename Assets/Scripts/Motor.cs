using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Motor : MonoBehaviour
{
    public TextMeshProUGUI precioacciones1;
    public TextMeshProUGUI cantidadacciones1;
    public TextMeshProUGUI precioacciones2;
    public TextMeshProUGUI cantidadacciones2;
    public TextMeshProUGUI TotalPlazoFijo;
    public TextMeshProUGUI IngresoPlazoFijo;
    public GameObject ScreenAcciones;
    public GameObject ScreenPlazoFijo;
    public GameObject PantallaBase;
    public TextMeshProUGUI ValorEntry;
    public TextMeshProUGUI CarteraTXT;
    public TextMeshProUGUI CarteraDolarTXT;
    public TextMeshProUGUI DolarVenta;
    public TextMeshProUGUI DolarCompra;
    private float Dolarcompra;
    private float Dolarventa;
    private float Dolar;
    private float Peso;
    private float Acciones;
    private float Plazofijo;
    private float tiempohora;
    private float tiempodia;
    private float DineroCambioDolar;
    private float DineroCambioPesos;
    private float Cartera;
    private float CarteraDolar;
    private float ValorKey;
    private float timer;
    private float horas;
    private float plazofijoainvertir;
    private float interesplazofijo;
    private float plazofijoinvertido;
    private float plazo;
    private float valoraccionesmanzana;
    private float valoraccionesventanas;
    private float accionesmanzana;
    private float accionesventanas;

    // Start is called before the first frame update
    void Start()
    {
        tiempodia = 10 * tiempohora;
        tiempohora = 30;
        Cartera = 100;
        Dolarventa = 1;
        Dolarcompra = Dolarventa * 0.75f;
        ValorKey = 0.1f;
        ScreenAcciones.SetActive(false);
        ScreenPlazoFijo.SetActive(false);
        PantallaBase.SetActive(true);
        timer = 30;
        interesplazofijo = 1.004f;

        valoraccionesmanzana = 40;
        valoraccionesventanas = 35;

    }

    // Update is called once per frame
    void Update()
    {
        precioacciones1.text = "$" + valoraccionesmanzana;
        precioacciones2.text = "$" + valoraccionesventanas;
        cantidadacciones1.text = "" + accionesmanzana;
        cantidadacciones2.text = "" + accionesventanas;
        ValorEntry.text = "$" + ValorKey;
        CarteraTXT.text = "$" + Cartera;
        CarteraDolarTXT.text = "U$D" + CarteraDolar;
        DolarVenta.text = "$" + Dolarventa;
        DolarCompra.text = "$" + Dolarcompra;
        TotalPlazoFijo.text = "$" + plazofijoinvertido;
        IngresoPlazoFijo.text = "$" + plazofijoainvertir;

        Debug.Log(timer);
        Debug.Log(horas);
        Debug.Log(Time.time);

        if (timer < Time.time)
        {
            timer = Time.time + 30;
            horas++;
            plazofijoinvertido = interesplazofijo * plazofijoinvertido;
        }
        

        if (Input.anyKeyDown)
        {
            SumaEntry();
        }
    }

    public void ConvertirADolar(float cantidad)
    {
        DineroCambioDolar = cantidad / Dolarcompra;
    }

    public void ConvertirAPeso(float cantidad)
    {
        DineroCambioPesos = cantidad * Dolarventa;
    }

    public void ComprarDolar()
    {
        Cartera = Cartera - Dolarventa;
        CarteraDolar++;
    }

    public void VentaDolar()
    {
        Cartera = Cartera + Dolarcompra;
        CarteraDolar--;
    }

    public void SumaEntry()
    {
        Cartera = Cartera + ValorKey;
    }

    public void ScreenAccionesOn()
    {
        ScreenAcciones.SetActive(true);
        ScreenPlazoFijo.SetActive(false);
        PantallaBase.SetActive(false);
    }

    public void ScreenPlazofijoOn()
    {
        ScreenAcciones.SetActive(false);
        ScreenPlazoFijo.SetActive(true);
        PantallaBase.SetActive(false);
    }

    public void ScreenBaseOn()
    {
        ScreenAcciones.SetActive(false);
        ScreenPlazoFijo.SetActive(false);
        PantallaBase.SetActive(true);
    }

    public void PlazoFij()
    {
        plazofijoinvertido = plazofijoainvertir;
        Cartera = Cartera - plazofijoainvertir;
        plazofijoainvertir = 0;

    }

    public void SumarPlazoFijo()
    {
        plazofijoainvertir++;
    }

    public void RestarPlazoFijo()
    {
        plazofijoainvertir--;
    }

    public void RetirarPlazoFijo()
    {
        Cartera = Cartera + plazofijoinvertido;
        plazofijoinvertido = 0;
    }

    public void compraracciones2()
    {
        accionesmanzana++;
        Cartera = Cartera - valoraccionesmanzana;
    }

    public void venderracciones2()
    {
        accionesmanzana--;
        Cartera = Cartera + valoraccionesmanzana;
    }

    public void compraracciones1()
    {
        accionesventanas++;
        Cartera = Cartera - valoraccionesventanas;
    }

    public void venderracciones1()
    {
        accionesventanas--;
        Cartera = Cartera + valoraccionesventanas;
    }




}
