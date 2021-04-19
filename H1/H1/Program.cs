using System;

namespace H1
{
    class Program
    {
        static void Main( string[] args )
        {
            //№1
            Console.WriteLine( "№1" + "\n" );

            int[] powersOfTwo = new int[10];
            powersOfTwo[0] = 1;
            Console.WriteLine( powersOfTwo[0] );

            for ( int i = 1; i < powersOfTwo.Length; i++ )
            {

                powersOfTwo[i] = powersOfTwo[i - 1] * 2;
                Console.WriteLine( powersOfTwo[i] );
            }

            //№2
            Console.WriteLine( "\n" + "№2" + "\n" );

            Random rnd2 = new Random( );

            int minNumber, maxNumber;
            int[] tenRandomNumbers = new int[10];
            tenRandomNumbers[0] = minNumber = maxNumber = rnd2.Next( 0, 9 );
            Console.WriteLine( "до" + "\n" + tenRandomNumbers[0] );

            for ( int i = 1; i < tenRandomNumbers.Length; i++ )
            {
                tenRandomNumbers[i] = rnd2.Next( 0, 9 );

                if ( tenRandomNumbers[i] > maxNumber )
                {
                    maxNumber = tenRandomNumbers[i];
                }
                else if ( tenRandomNumbers[i] < minNumber )
                {
                    minNumber = tenRandomNumbers[i];
                }

                Console.WriteLine( tenRandomNumbers[i] );
            }

            Console.WriteLine( "\n" + "min=" + minNumber + " " + "max=" + maxNumber + "\n\n" + "после" );

            for ( int i = 0; i < tenRandomNumbers.Length; i++ )
            {
                if ( tenRandomNumbers[i] == maxNumber )
                {
                    tenRandomNumbers[i] = minNumber;
                }
                else if ( tenRandomNumbers[i] == minNumber )
                {
                    tenRandomNumbers[i] = maxNumber;
                }

                Console.WriteLine( tenRandomNumbers[i] );
            }

            //№3
            Console.WriteLine( "\n" + "№3" + "\n\n" + "set array size" );

            int n = Convert.ToInt32( Console.ReadLine( ) );
            Console.WriteLine( );

            int[] nRandomNumbers = new int[n];

            float mean = 0;

            Random rnd3 = new Random( );

            for ( int i = 0; i < nRandomNumbers.Length; i++ )
            {
                nRandomNumbers[i] = rnd3.Next( 0, 100 );
                mean += nRandomNumbers[i];
                Console.WriteLine( nRandomNumbers[i] );
            }

            mean /= n;
            Console.WriteLine( "\n" + "среднее значение: " + mean );

            Console.ReadKey( );
        }
    }
}