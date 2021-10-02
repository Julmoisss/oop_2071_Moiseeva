using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop2
{
    class Rational
    {
        public int numerator;
        public int denominator;

        public Rational(int num, int den)
        {
            numerator = num;
            denominator = den;
        }

        public static int Nod(int num, int den)
        {
            while (num != den)
            {
                if (num < den)
                {
                    den -= num;
                }
                else
                {
                    num -= den;
                }
            }
            int nod = num;
            return nod;
        }

        public Rational Sum(Rational other)
        {
            Rational r1 = this;
            Rational r2 = other;

            int num;
            int den;
            int nod;

            num = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            den = r1.denominator + r2.denominator;
            nod = Rational.Nod(num, den);
            num = num / nod;
            den = den / nod;

            Rational result = new Rational(num, den);
            return result;
        }

        public Rational Subtrac(Rational other)
        {
            Rational r1 = this;
            Rational r2 = other;

            int num;
            int den;
            int nod;

            num = r1.numerator * r2.denominator + r2.numerator * r1.denominator;
            den = r1.denominator - r2.denominator;
            nod = Rational.Nod(num, den);
            num = num / nod;
            den = den / nod;

            Rational result = new Rational(num, den);
            return result;
        }

        public Rational Multiply(Rational other)
        {
            Rational r1 = this;
            Rational r2 = other;

            int num;
            int den;
            int nod;

            num = r1.numerator * r2.numerator;
            den = r1.denominator * r2.denominator;
            nod = Rational.Nod(num, den);
            num = num / nod;
            den = den / nod;

            Rational result = new Rational(num, den);
            return result;
        }

        public Rational Divide(Rational other)
        {
            Rational r1 = this;
            Rational r2 = other;

            int num;
            int den;
            int nod;

            num = r1.numerator * r2.denominator;
            den = r1.denominator * r2.numerator;
            nod = Rational.Nod(num, den);
            num = num / nod;
            den = den / nod;

            Rational result = new Rational(num, den);
            return result;
        }

        public static Rational operator +(Rational r1, Rational r2)
        {
            return r1.Sum(r2);
        }
        public static Rational operator -(Rational r1, Rational r2)
        {
            return r1.Subtrac(r2);
        }
        public static Rational operator *(Rational r1, Rational r2)
        {
            return r1.Multiply(r2);
        }
        public static Rational operator /(Rational r1, Rational r2)
        {
            return r1.Divide(r2);
        }
    }
}
