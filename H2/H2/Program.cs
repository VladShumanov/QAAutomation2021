using System;
using System.Text;

namespace H2
{
    class Program
    {
        //concatenates an array of strings coming from the command line into one line
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

        //finds the largest substring where no character is repeated with adjacent characters
        private static int[] NoRepetitionsSideBySide( string line )
        {
            //the bounds substring where no character is repeated with adjacent characters
            int leftBoundary = 0;
            int rightBoundary = 0;

            //the bounds of the largest found substring
            int leftPosition = 0;
            int rightPosition = 0;

            //iterates over the string from left to right
            while ( rightBoundary < line.Length - 1 )
            {
                //compare of adjacent characters for equality
                if ( line[rightBoundary] == line[rightBoundary + 1] )
                {
                    //compare the found substring with the maximum found substring
                    if ( rightBoundary - leftBoundary > rightPosition - leftPosition )
                    {
                        leftPosition = leftBoundary;
                        rightPosition = rightBoundary;
                    }

                    //moving left border to find new substring
                    leftBoundary = rightBoundary + 1;
                }

                //trying to increment a substring by one character
                rightBoundary++;
            }

            //checking: the maximum substring is at the end of the string?
            if ( line.Length - 1 - leftBoundary > rightPosition - leftPosition )
            {
                leftPosition = leftBoundary;
                rightPosition = line.Length - 1;
            }

            int[] positions = { leftPosition, rightPosition };

            return positions;
        }

        //finds the largest substring where no character is repeated
        private static int[] NoRepetitionsInPrinciple( string line )
        {
            //the bounds substring where no character is repeated with other characters
            int leftBoundary = 0;
            int rightBoundary = 0;

            //the bounds of the largest found substring
            int leftPosition = 0;
            int rightPosition = 0;

            //iterates over the string from left to right
            while ( rightBoundary < line.Length )
            {
                //compare the new character in the substring with the previous characters
                for ( int i = leftBoundary; i < rightBoundary; i++ )
                {
                    if ( line[i] == line[rightBoundary] )
                    {
                        //compare the found substring with the maximum found substring
                        if ( rightBoundary - 1 - leftBoundary > rightPosition - leftPosition )
                        {
                            leftPosition = leftBoundary;
                            rightPosition = rightBoundary - 1;
                        }

                        //to exit the loop
                        i = rightBoundary - 1;

                        //moving left border to find new substring
                        rightBoundary = ++leftBoundary;
                    }
                }

                //trying to increment a substring by one character
                rightBoundary++;
            }

            //checking: the maximum substring is at the end of the string?
            if ( line.Length - 1 - leftBoundary > rightPosition - leftPosition )
            {
                leftPosition = leftBoundary;
                rightPosition = line.Length - 1;
            }

            int[] positions = { leftPosition, rightPosition };

            return positions;
        }

        //outputs the substring along with the number of characters in the substring
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
                //outputs an array of strings coming from the command line
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