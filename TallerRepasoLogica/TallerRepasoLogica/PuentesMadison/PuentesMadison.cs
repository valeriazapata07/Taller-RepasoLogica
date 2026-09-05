
namespace TallerRepasoLogica.PuentesMadison
{
    public class PuentesMadison
    {
        public static bool EsValido(string puente)
        {
            if (puente.Length < 2)
            {
                return false;
            }

            if (puente[0] != '*' || puente[puente.Length - 1] != '*')
            {
                return false;
            }

            for (int i = 1; i < puente.Length - 1; i++)
            {
                if (puente[i] == '*')
                {
                    return false;
                }
            }

            foreach (char caracter in puente)
            {
                if (caracter != '*' && caracter != '=' && caracter != '+')
                {
                    return false;
                }
            }

            for (int i = 0; i < puente.Length / 2; i++)
            {
                if (puente[i] != puente[puente.Length - 1 - i])
                {
                    return false;
                }
            }

            int posicion = 1;
            int gruposDeTres = 0;

            while (posicion < puente.Length - 1)
            {
                if (puente[posicion] == '+')
                {
                    posicion++;
                    continue;
                }

                int inicio = posicion;
                int cantidadPlataformas = 0;

                while (posicion < puente.Length - 1 &&
                       puente[posicion] == '=')
                {
                    cantidadPlataformas++;
                    posicion++;
                }

                if (cantidadPlataformas != 2 &&
                    cantidadPlataformas != 3)
                {
                    return false;
                }

                if (cantidadPlataformas == 3)
                {
                    gruposDeTres++;

                    int final = posicion - 1;
                    int centro = (puente.Length - 1) / 2;

                    if (inicio > centro || final < centro)
                    {
                        return false;
                    }
                }
            }

            if (gruposDeTres > 1)
            {
                return false;
            }

            return true;
        }
    }
}