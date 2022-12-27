using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CajaCEMISAM.Formularios;
using System.Data.OleDb;
using System.Globalization;

namespace CajaCEMISAM.Utilerias
{
    class Herramientas
    {
        public static int sumarTotales(CrearRecibo fRec)
        {
            int sumatotal=0;
            sumatotal = int.Parse(fRec.txtSer1.Text) + int.Parse(fRec.txtSer2.Text) + int.Parse(fRec.txtSer3.Text);
            return sumatotal;
        }


        public string ConvertLetter(string _textNumber, string _currency)
        {
            string Words = string.Empty;
            string Number = string.Empty;
            string auxNumber = string.Empty;
            string decimalPart = string.Empty;
            string integerPart = string.Empty;
            string Fl = string.Empty;
            string Fl_II = string.Empty;
            int numberAlone = -1;

            auxNumber = _textNumber.Replace("$", "").Replace(",", "").Replace("+", "").Trim();

            if (isFloatNumber(auxNumber))
            {

                //-------Si es un número negativo
                if (auxNumber.Substring(0, 1).Equals("-"))
                {
                    Words = "MENOS ";
                    auxNumber = auxNumber.Substring(1);
                }

                //-------Si tiene ceros a la izquierda

                for (int i = 0; i < auxNumber.Length; i++)
                {
                    if (auxNumber.Substring(i, 1).Equals("0"))
                    {
                        Number = auxNumber.Substring(i + 1);
                    }
                    else
                    {
                        break;
                    }
                }

                if (string.IsNullOrEmpty(Number)) { Number = auxNumber; }

                //-------Separa la parte entera de la decimal 

                string[] arrayNumber = splitString(Number, '.');

                integerPart = arrayNumber[0];

                if (arrayNumber[1].Length > 2)
                {
                    decimalPart = arrayNumber[1].Substring(0, 2);
                }
                else if (arrayNumber[1].Length == 2)
                {
                    decimalPart = arrayNumber[1];
                }
                else if (arrayNumber[1].Length == 1)
                {
                    decimalPart = arrayNumber[1] + "0";
                }

                //-------Proceso de conversión

                if (float.Parse(Number) <= 1000000)
                {
                    int sbt = 0;

                    if (int.Parse(integerPart) != 0)
                    {

                        for (int i = integerPart.Length; i > 0; i--)
                        {

                            numberAlone = int.Parse(integerPart.Substring(sbt, 1));


                            switch (i)
                            {

                                //--------Arma las centenas
                                case 6:
                                case 3:

                                    switch (numberAlone)
                                    {
                                        case 1:
                                            if (integerPart.Substring(sbt + 1, 1).Equals("0") &&
                                            integerPart.Substring(sbt + 2, 1).Equals("0"))
                                            { Words = Words + "CIEN "; }
                                            else { Words = Words + "CIENTO "; }
                                            break;

                                        case 2:
                                            Words = Words + "DOSCIENTOS ";
                                            break;

                                        case 3:
                                            Words = Words + "TRESCIENTOS ";
                                            break;

                                        case 4:
                                            Words = Words + "CUATROCIENTOS ";
                                            break;

                                        case 5:
                                            Words = Words + "QUINIENTOS ";
                                            break;

                                        case 6:
                                            Words = Words + "SEISCIENTOS ";
                                            break;

                                        case 7:
                                            Words = Words + "SETECIENTOS ";
                                            break;

                                        case 8:
                                            Words = Words + "OCHOCIENTOS ";
                                            break;

                                        case 9:
                                            Words = Words + "NOVECIENTOS ";
                                            break;
                                    }

                                    break;
                                //--------Arma las decenas
                                case 5:
                                case 2:

                                    switch (numberAlone)
                                    {
                                        case 1:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "DIEZ "; Fl = "D"; if (i == 2) { Fl_II = "X"; } else { Fl_II = string.Empty; } }
                                            else if (integerPart.Substring(sbt + 1, 1).Equals("1"))
                                            { Words = Words + "ONCE "; Fl = "D"; if (i == 2) { Fl_II = "X"; } else { Fl_II = string.Empty; } }
                                            else if (integerPart.Substring(sbt + 1, 1).Equals("2"))
                                            { Words = Words + "DOCE "; Fl = "D"; if (i == 2) { Fl_II = "X"; } else { Fl_II = string.Empty; } }
                                            else if (integerPart.Substring(sbt + 1, 1).Equals("3"))
                                            { Words = Words + "TRECE "; Fl = "D"; if (i == 2) { Fl_II = "X"; } else { Fl_II = string.Empty; } }
                                            else if (integerPart.Substring(sbt + 1, 1).Equals("4"))
                                            { Words = Words + "CATORCE "; Fl = "D"; if (i == 2) { Fl_II = "X"; } else { Fl_II = string.Empty; } }
                                            else if (integerPart.Substring(sbt + 1, 1).Equals("5"))
                                            { Words = Words + "QUINCE "; Fl = "D"; if (i == 2) { Fl_II = "X"; } else { Fl_II = string.Empty; } }
                                            else
                                            { Words = Words + "DIECI"; }

                                            break;

                                        case 2:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "VEINTE "; }
                                            else
                                            { Words = Words + "VEINTI"; }

                                            break;

                                        case 3:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "TREINTA "; }
                                            else
                                            { Words = Words + "TREINTA Y "; }

                                            break;

                                        case 4:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "CUARENTA "; }
                                            else
                                            { Words = Words + "CUARENTA Y "; }

                                            break;

                                        case 5:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "CINCUENTA "; }
                                            else
                                            { Words = Words + "CINCUENTA Y "; }

                                            break;

                                        case 6:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "SESENTA "; }
                                            else
                                            { Words = Words + "SESENTA Y "; }

                                            break;

                                        case 7:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "SETENTA "; }
                                            else
                                            { Words = Words + "SETENTA Y "; }

                                            break;

                                        case 8:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "OCHENTA "; }
                                            else
                                            { Words = Words + "OCHENTA Y "; }

                                            break;

                                        case 9:

                                            if (integerPart.Substring(sbt + 1, 1).Equals("0"))
                                            { Words = Words + "NOVENTA "; }
                                            else
                                            { Words = Words + "NOVENTA Y "; }

                                            break;

                                    }

                                    break;


                                //--------Arma las unidades
                                case 7:
                                case 4:
                                case 1:

                                    switch (numberAlone)
                                    {
                                        case 1:

                                            if (!Fl.Equals("D"))
                                            {
                                                if (i == 4)
                                                {
                                                    Words = Words + "UN ";
                                                }
                                                else
                                                {
                                                    Words = Words + "UN "; //UNO
                                                }
                                            }
                                            else if (Fl.Equals("D") && string.IsNullOrEmpty(Fl_II))
                                            { Words = Words + "UNO "; }

                                            break;

                                        case 2:

                                            if (!Fl.Equals("D"))
                                            {
                                                Words = Words + "DOS ";
                                            }
                                            else if (Fl.Equals("D") && string.IsNullOrEmpty(Fl_II))
                                            { Words = Words + "DOS "; }

                                            break;

                                        case 3:

                                            if (!Fl.Equals("D"))
                                            {
                                                Words = Words + "TRES ";
                                            }
                                            else if (Fl.Equals("D") && string.IsNullOrEmpty(Fl_II))
                                            { Words = Words + "TRES "; }

                                            break;

                                        case 4:

                                            if (!Fl.Equals("D"))
                                            {
                                                Words = Words + "CUATRO ";
                                            }
                                            else if (Fl.Equals("D") && string.IsNullOrEmpty(Fl_II))
                                            { Words = Words + "CUATRO "; }

                                            break;

                                        case 5:

                                            if (!Fl.Equals("D"))
                                            {
                                                Words = Words + "CINCO ";
                                            }
                                            else if (Fl.Equals("D") && string.IsNullOrEmpty(Fl_II))
                                            { Words = Words + "CINCO "; }

                                            break;

                                        case 6:
                                            Words = Words + "SEIS ";
                                            break;

                                        case 7:
                                            Words = Words + "SIETE ";
                                            break;

                                        case 8:
                                            Words = Words + "OCHO ";
                                            break;

                                        case 9:
                                            Words = Words + "NUEVE ";
                                            break;
                                    }

                                    break;

                            }
                            if (i == 4)
                            {
                                Words = Words + "MIL ";
                            }

                            if (i == 7 && integerPart.Substring(0, 1).Equals("1"))
                            {
                                Words = Words + "MILLÓN ";
                            }
                            else if (i == 7 && !integerPart.Substring(0, 1).Equals("1"))
                            {
                                Words = Words + "MILLONES ";
                            }

                            sbt += 1;
                        }
                    }
                    else
                    {
                        Words = "CERO ";
                    }

                    //-------Une la parte entera con la decimal y asigna la moneda

                    if (_currency.Equals("MX"))
                    {
                        Words = Words + " PESOS " + decimalPart + "/100 M.N.";
                    }
                    else
                    {
                        Words = Words + " USD " + decimalPart + "/100";
                    }


                }
                else
                {
                    Words = "NÚMERO FUERA DE RANGO [XXXXXXX.XX]";
                }

            }
            else
            {
                Words = "DATO NO NUMÉRICO";
            }

            return Words;
        }


        //-------El código anterior requiere de las siguientes funciones:

        public bool isFloatNumber(string _numberText)
        {
            float Result = 0;
            bool numberResult = false;

            if (float.TryParse(_numberText, out Result))
            {
                numberResult = true;
            }

            return numberResult;
        }


        public string[] splitString(string _textString, char _character)
        {
            string[] split = null;

            if (!string.IsNullOrEmpty(_textString))
            {
                if (_textString.Contains(_character.ToString()))
                {
                    split = _textString.Split(new char[] { _character });

                    if (string.IsNullOrEmpty(split[0])) { split[0] = "0"; }

                }
                else
                {
                    split = new string[2];
                    split[0] = _textString;
                    split[1] = "00";
                }
            }

            return split;
        }

        
    }

  


}
