using System;
using System.Text;

namespace H2
{
    class Program
    {
        private static string ConcatenationOfArguments( string[] args )
        {
            StringBuilder line = new StringBuilder( );

            for ( int i = 0; i < args.Length; i++ )
            {
                line.Append( args[i] );

                if ( i != args.Length - 1 )
                {
                    line.Append( " " );
                }

            }

            return line.ToString( );
        }

        private static int[] NoRepetitionsSideBySide( string line )
        {
            int leftPosition = 0, rightPosition = 0, leftBoundary = 0, rightBoundary = 0;

            while ( rightBoundary < line.Length - 1 )
            {
                if ( line[rightBoundary] == line[rightBoundary + 1] )
                {
                    if ( rightBoundary - leftBoundary > rightPosition - leftPosition )
                    {
                        leftPosition = leftBoundary;
                        rightPosition = rightBoundary;
                    }

                    leftBoundary = rightBoundary + 1;
                }

                rightBoundary++;
            }

            if ( line.Length - 1 - leftBoundary > rightPosition - leftPosition )
            {
                leftPosition = leftBoundary;
                rightPosition = line.Length - 1;
            }

            int[] positions = { leftPosition, rightPosition };

            return positions;
        }

        private static int[] NoRepetitionsInPrinciple( string line )
        {
            int leftPosition = 0, rightPosition = 0, leftBoundary = 0, rightBoundary = 0;

            while ( rightBoundary < line.Length )
            {
                for ( int i = leftBoundary; i < rightBoundary; i++ )
                {
                    if ( line[i] == line[rightBoundary] )
                    {
                        if ( rightBoundary - 1 - leftBoundary > rightPosition - leftPosition )
                        {
                            leftPosition = leftBoundary;
                            rightPosition = rightBoundary - 1;
                        }

                        i = rightBoundary - 1;

                        rightBoundary = ++leftBoundary;
                    }
                }

                rightBoundary++;
            }

            if ( line.Length - 1 - leftBoundary > rightPosition - leftPosition )
            {
                leftPosition = leftBoundary;
                rightPosition = line.Length - 1;
            }

            int[] positions = { leftPosition, rightPosition };

            return positions;
        }

        private static void SequenceOutput( string line, int[] positions )
        {
            Console.Write( "{" );
            for ( int i = positions[0]; i <= positions[1]; i++ )
            {
                Console.Write( line[i] );
            }
            Console.WriteLine( "}=" + (positions[1] - positions[0] + 1) );
        }

        static void Main( string[] args )
        {
            if ( args.Length > 0 )
            {
                for ( int i = 0; i < args.Length; i++ )
                {
                    Console.Write( args[i] + " " );
                }

                Console.WriteLine();

                string line = ConcatenationOfArguments( args );

                int[] positions = NoRepetitionsSideBySide( line );

                Console.Write( "№1: " );
                SequenceOutput( line, positions );

                positions = NoRepetitionsInPrinciple( line );

                Console.Write( "№2: " );
                SequenceOutput( line, positions );
                Console.ReadKey( );
            }
            else
            {
                Console.WriteLine( "No Command Line Arguments" );

                Console.ReadKey( );
            }
        }
    }
}