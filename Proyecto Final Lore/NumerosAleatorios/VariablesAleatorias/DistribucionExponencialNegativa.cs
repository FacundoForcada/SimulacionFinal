using System;
using System.Collections.Generic;
using NumerosAleatorios.NumerosAleatorios;

namespace NumerosAleatorios.VariablesAleatorias
{
    public class DistribucionExponencialNegativa : IDistribucion
    {
        public double Lambda { get; protected set; }
        public IGeneradorNumerosAleatorios Generador { get; set; }
        public double random { get; set; }

        public DistribucionExponencialNegativa(double lambda)
        {
            random = 0;
            if (lambda <= 0)
                throw new NotSupportedException("Lambda debe ser un número positivo");
            Lambda = lambda;
            Generador = new GeneradorDelSistema();
        }

        public DistribucionExponencialNegativa(double lambda, IGeneradorNumerosAleatorios generador)
        {
            random = 0;
            if (lambda <= 0)
                throw new NotSupportedException("Lambda debe ser un número positivo");
            Lambda = lambda;
            Generador = generador;
        }

        public void AsignarGenerador(IGeneradorNumerosAleatorios generador)
        {
            Generador = generador;
        }

        public double Generar()
        {
            var aleatorio = Generador.Generar();
            random = aleatorio;
            var variable = (-1 / Lambda) * Math.Log(1 - aleatorio);
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