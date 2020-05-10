using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_Solving
{
    public class ZombieMatrix
    {
        
        public static int CalculateZombieMatrixTime(int[,] zombieMatrix)
        {
            int Zombied = 5;
            bool isHumanityExist = false;
            List<KeyValue> abc = new List<KeyValue>();

            int x = zombieMatrix.GetLength(0);
            int y = zombieMatrix.GetLength(1);

            int iteration = 1;
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (zombieMatrix[i, j] == 0)
                    {
                        isHumanityExist = true;
                        abc.Add(new KeyValue(i, j));
                    }
                    else if (zombieMatrix[i, j] == 1 )
                    {
                        MakeZombie(i, j, zombieMatrix, Zombied);
                    }
                }
            }

            if (!isHumanityExist || abc.Count == (x*y)) return 0;

            int z = 0;
            bool zombied = false;
            Zombied++;
            while (abc.Count >0)
            {
                if(zombieMatrix[abc[z].index1, abc[z].index2] == 0)
                {
                    if(CanBeZombie(abc[z].index1, abc[z].index2, zombieMatrix, Zombied))
                    {
                        zombied = true;
                        abc.Remove(abc[z]);
                    }
                    else
                    {
                        z++;
                    }
                }
                else
                {
                    abc.Remove(abc[z]);
                }

                if(z>= abc.Count)
                {
                    z = 0;
                    if (zombied)
                    {
                        iteration++;
                        Zombied++;
                    }
                }
            }
             

            return iteration;
        }

        private static bool CanBeZombie(int i, int j, int[,] zombieMatrix, int Zombied)
        {
          
            if ((i != 0 && zombieMatrix[i - 1, j] > 0 && zombieMatrix[i - 1, j] < Zombied) ||
                (i < zombieMatrix.GetLength(0) - 1 && zombieMatrix[i + 1, j] > 0 && zombieMatrix[i + 1, j] < Zombied) ||
                (j != 0 && zombieMatrix[i, j - 1] > 0 && zombieMatrix[i, j - 1] < Zombied) ||
                (j < zombieMatrix.GetLength(1) - 1 && zombieMatrix[i, j + 1] > 0 && zombieMatrix[i, j + 1] < Zombied))
            {
                zombieMatrix[i, j] = Zombied;
                return true;
            }
            return false;
        }

        private static void MakeZombie(int i, int j, int[,] zombieMatrix, int Zombied)
        {
            if (i != 0 && zombieMatrix[i - 1, j] != 1)
            {
                zombieMatrix[i - 1, j] = Zombied;
            }
            if (i < zombieMatrix.GetLength(0) - 1 && zombieMatrix[i + 1, j] != 1)
            {
                zombieMatrix[i + 1, j] = Zombied;
            }

            if (j != 0 && zombieMatrix[i, j - 1] != 1)
            {
                zombieMatrix[i, j - 1] = Zombied;
            }
            if (j < zombieMatrix.GetLength(1) - 1 && zombieMatrix[i, j + 1] != 1)
            {
                zombieMatrix[i, j + 1] = Zombied;
            }
        }

    }

    public struct KeyValue
    {
        public int index1;
        public int index2;
        public KeyValue(int k, int v)
        {
            index1 = k;
            index2 = v;
        }
        
    }
  

}
