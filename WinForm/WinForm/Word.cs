﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Xceed.Words.NET;

namespace WinForm
{
    class Word
    {
        private static readonly double RelPtaCm = 40;

        private static void agregarParrafo(DocX document, string texto, Font fuente, int tamaño)
        {
            document.InsertParagraph().Font(fuente).FontSize(tamaño).InsertText(texto);
        }

        private static void insertarImagen(DocX document, string pathImagen, int tamaño, Alignment alineacion, string textoExtra = "")
        {
            var image = document.AddImage(pathImagen);
            var picture = image.CreatePicture();
            double relacionAspecto = Convert.ToDouble(picture.Width) / Convert.ToDouble(picture.Height);
            picture.Height = Convert.ToInt32(tamaño*RelPtaCm);
            picture.Width = Convert.ToInt32(tamaño * relacionAspecto* RelPtaCm);
            Paragraph paragraph = document.InsertParagraph();
            paragraph.AppendPicture(picture);
            paragraph.InsertText(textoExtra);
            paragraph.Alignment = alineacion;
        }
        private static void agregarEncabezado(DocX document, string texto, Font fuente, int tamaño, Alignment alineacion)
        {
            document.Headers.Odd.InsertParagraph().Font(fuente).FontSize(tamaño).Append(texto).Alignment = alineacion;
        }

        private static void agregarEncabezadoNegrita(DocX document, string texto, Font fuente, int tamaño, Alignment alineacion)
        {
            document.Headers.Odd.InsertParagraph().Font(fuente).FontSize(tamaño).Append(texto).Bold().Alignment = alineacion;
        }

        private static void salvarArchivo(DocX document, string pathGuardar)
        {
            document.SaveAs(pathGuardar);
        }

        private static void encabezadoBEV(Plan plan, DocX document)
        {
            document.AddHeaders();
            agregarEncabezado(document, Textos.encabezadoBEV1(plan),new Font("Times New Roman") , 12, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoBEV2(plan), new Font("Times New Roman"), 12, Alignment.center);
        }

        private static void imagenesBEV(Plan plan, DocX document, string gantrySetUp1, string tamSetUp1, string gantrySetUp2, string tamSetUp2)
        {
            List<string> imagenes = IO.obtenerImagenes(plan.nombre);
            for (int i=0;i<plan.cantidadDeCampos;i++)
            {
                insertarImagen(document, imagenes[i], 11, Alignment.left, Textos.parametrosCampoTto(plan.listaCampos[i]));
            }
            insertarImagen(document, imagenes[plan.cantidadDeCampos], 11, Alignment.left, Textos.parametrosCampoSetUp(gantrySetUp1, tamSetUp1));
            insertarImagen(document, imagenes[plan.cantidadDeCampos+1], 11, Alignment.left, Textos.parametrosCampoSetUp(gantrySetUp2, tamSetUp2));
        }

        
        public static void crearArchivoBEV(Plan plan)
        {
            DocX document = DocX.Create("BEV.doc");
            document.DifferentFirstPage = false;
            document.DifferentFirstPage = false; //para que todos los encabezados sean iguales
            encabezadoBEV(plan, document);
            imagenesBEV(plan, document,"180","10x10","270","15x10");
            string aux = IO.pathDestino + plan.nombre[0] + ", " + plan.nombre[1] + " " + plan.ID + "\\BEV.doc";
            salvarArchivo(document, aux);
        }

        private static void encabezadoInforme(Plan plan, DocX document)
        {
            document.AddHeaders();
            agregarEncabezadoNegrita(document, Textos.encabezadoInformeLinea1(plan), new Font("Times New Roman"), 14, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoInformeLinea2(plan), new Font("Times New Roman"), 12, Alignment.left);
            agregarEncabezado(document, Textos.encabezadoInformeLinea3(plan), new Font("Times New Roman"), 12, Alignment.center);
        }

        public static void crearArchivoInforme(Plan plan)
        {
            DocX document = DocX.Create("BEV.doc");
            document.DifferentFirstPage = false;
            document.DifferentFirstPage = false; //para que todos los encabezados sean iguales
            encabezadoInforme(plan,document);
            string aux = IO.pathDestino + plan.nombre[0] + ", " + plan.nombre[1] + " " + plan.ID + "\\Informe.doc";
            salvarArchivo(document, aux);
        }
       
    }
}
