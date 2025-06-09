using System;

// Clase Circulo encapsula su atributo radio y permite calcular área y perímetro
public class Circulo
{
    // radio es un valor privado que representa el radio del círculo
    private double radio;

    // Constructor que asigna el valor del radio al crear un objeto Circulo
    public Circulo(double radio)
    {
        this.radio = radio;
    }

    // CalcularArea devuelve un valor double y se utiliza para calcular el área del círculo
    public double CalcularArea()
    {
        return Math.PI * radio * radio;
    }

    // CalcularPerimetro devuelve el perímetro del círculo (también conocido como circunferencia)
    public double CalcularPerimetro()
    {
        return 2 * Math.PI * radio;
    }
}

// Clase Rectangulo encapsula sus atributos ancho y alto, y calcula área y perímetro
public class Rectangulo
{
    // ancho y alto son valores privados que representan las dimensiones del rectángulo
    private double ancho;
    private double alto;

    // Constructor que asigna el valor del ancho y alto al crear un objeto Rectangulo
    public Rectangulo(double ancho, double alto)
    {
        this.ancho = ancho;
        this.alto = alto;
    }

    // CalcularArea devuelve el área del rectángulo multiplicando ancho por alto
    public double CalcularArea()
    {
        return ancho * alto;
    }

    // CalcularPerimetro devuelve el perímetro sumando dos veces ancho y dos veces alto
    public double CalcularPerimetro()
    {
        return 2 * (ancho + alto);
    }
}
