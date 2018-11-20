using System;
using System.Collections.Generic;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionUniforme : IDistribucion
    {
        public double A { get; protected set; }
        public double B { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; protected set; }
        public double random { get; set; }

        public DistribucionUniforme(double a, double b)
        {
            if (b <= a)
                throw new NotSupportedException("A debe ser menor que B");
            A = a;
            B = b;
            Generador = new GeneradorDelSistema();
            random = 0;
        }

        public DistribucionUniforme(double a, double b, IGeneradorNumerosAleatorios generador)
        {
            if (b <= a)
                throw new NotSupportedException("A debe ser menor que B");
            A = a;
            B = b;
            Generador = generador;
            random = 0;
        }

        public void AsignarGenerador(IGeneradorNumerosAleatorios generador)
        {
            Generador = generador;
        }

        public double Generar()
        {
            var aleatorio = Generador.Generar();
            random = aleatorio;
            var variable = A + aleatorio * (B - A);
            return variable;
        }

        public List<double> Generar(int cantidad)
        {
            var variables = new List<double>(cantidad);
            for (int i = 0; i < cantidad; i++)
            {
                variables.Add(Generar());
            }
            return variables;
        }

        public double GetRandomGenerador()
        {
            return random;
        }
    }
}