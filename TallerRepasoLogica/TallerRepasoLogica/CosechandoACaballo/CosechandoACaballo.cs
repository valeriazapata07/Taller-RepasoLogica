
using System;
using System.Collections.Generic;

namespace CosechandoACaballo
{
    public class CaballoCosecha
    {
        private char[,] tablero = new char[8, 8];
        private int filaActual;
        private int columnaActual;
        private List<char> frutosRecogidos = new List<char>();

        public CaballoCosecha(string frutos, string posicionInicial)
        {
            InicializarTablero(frutos);
            EstablecerPosicion(posicionInicial);
        }

        private void InicializarTablero(string frutos)
        {
            for (int fila = 0; fila < 8; fila++)
            {
                for (int columna = 0; columna < 8; columna++)
                {
                    tablero[fila, columna] = ' ';
                }
            }

            string[] listaFrutos = frutos.Split(',');

            foreach (string frutoOriginal in listaFrutos)
            {
                string fruto = frutoOriginal.Trim();

                if (fruto.Length < 3)
                {
                    continue;
                }

                char columna = char.ToUpper(fruto[0]);

                if (!char.IsDigit(fruto[1]))
                {
                    continue;
                }

                int fila = int.Parse(fruto[1].ToString());
                char simbolo = fruto[2];

                int columnaTablero = columna - 'A';
                int filaTablero = 8 - fila;

                if (filaTablero >= 0 && filaTablero < 8 &&
                    columnaTablero >= 0 && columnaTablero < 8)
                {
                    tablero[filaTablero, columnaTablero] = simbolo;
                }
            }
        }

        private void EstablecerPosicion(string posicion)
        {
            if (string.IsNullOrEmpty(posicion))
            {
                return;
            }

            posicion = posicion.Trim();

            if (posicion.Length < 2)
            {
                return;
            }

            char columna = char.ToUpper(posicion[0]);
            int fila = int.Parse(posicion[1].ToString());

            columnaActual = columna - 'A';
            filaActual = 8 - fila;
        }

        private void RecogerFruto()
        {
            if (tablero[filaActual, columnaActual] != ' ')
            {
                frutosRecogidos.Add(tablero[filaActual, columnaActual]);
                tablero[filaActual, columnaActual] = ' ';
            }
        }

        public void Mover(string movimiento)
        {
            int cambioFila = 0;
            int cambioColumna = 0;

            switch (movimiento.Trim().ToUpper())
            {
                case "UL":
                    cambioFila = -2;
                    cambioColumna = -1;
                    break;

                case "UR":
                    cambioFila = -2;
                    cambioColumna = 1;
                    break;

                case "LU":
                    cambioFila = -1;
                    cambioColumna = -2;
                    break;

                case "LD":
                    cambioFila = 1;
                    cambioColumna = -2;
                    break;

                case "RU":
                    cambioFila = -1;
                    cambioColumna = 2;
                    break;

                case "RD":
                    cambioFila = 1;
                    cambioColumna = 2;
                    break;

                case "DL":
                    cambioFila = 2;
                    cambioColumna = -1;
                    break;

                case "DR":
                    cambioFila = 2;
                    cambioColumna = 1;
                    break;

                default:
                    return;
            }

            int nuevaFila = filaActual + cambioFila;
            int nuevaColumna = columnaActual + cambioColumna;

            if (nuevaFila >= 0 && nuevaFila < 8 &&
                nuevaColumna >= 0 && nuevaColumna < 8)
            {
                filaActual = nuevaFila;
                columnaActual = nuevaColumna;

                RecogerFruto();
            }
        }

        public string ObtenerFrutosRecogidos()
        {
            return string.Join("", frutosRecogidos);
        }
    }
}