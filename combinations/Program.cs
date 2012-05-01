using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace combinations
{
        class Program
        {
                static void Main( string[] args )
                {

                        using ( StreamWriter file = new StreamWriter(
                            Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "combinations.csv"),
                            false ) )
                        {

                                CombinatoricsUtilities.GetCombinations( 
                                    new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, a => {
                                    file.WriteLine("{0}, {1}, {2}, {3}, {4}", a[0], a[1], a[2], a[3], a[4]);
                                }, 5, false );
                        }

                }
        }
}


