using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab04
{
    internal class Room
    {
        private Dictionary<int, char[]> room;
        private int SamRow;
        private int SamCol;
        private int NikoRow;
        public bool SamWon;

        public Room (Dictionary<int, char[]> room, int samRow, int samCol, int nikoRow)
        {
            this.room = room;
            SamCol = samCol;
            SamRow = samRow;
            NikoRow = nikoRow;
        }
        public int GetSamRow() { return SamRow; }
        public int GetSamCol() { return SamCol; }

        public bool moveUp()
        {
            moveEnemies();
            --SamRow;
            room[SamRow + 1][SamCol] = '.';
            room[SamRow][SamCol] = 'S';
            KeyValuePair<char, int> enemyPosition = HasEnemies(SamRow);
            return IfStepSuccessful(enemyPosition);
        }
        public bool moveDown()
        {
            moveEnemies();
            ++SamRow;
            room[SamRow - 1][SamCol] = '.';
            room[SamRow][SamCol] = 'S';
            KeyValuePair<char, int> enemyPosition = HasEnemies(SamRow);
            return IfStepSuccessful(enemyPosition);
        }
        public bool moveRight()
        {
            moveEnemies();
            ++SamCol;
            room[SamRow][SamCol - 1] = '.';
            room[SamRow][SamCol] = 'S';
            KeyValuePair<char, int> enemyPosition = HasEnemies(SamRow);
            return IfStepSuccessful(enemyPosition);
        }
        public bool moveLeft()
        {
            moveEnemies();
            --SamCol;
            room[SamRow][SamCol + 1] = '.';
            room[SamRow][SamCol] = 'S';
            KeyValuePair<char, int> enemyPosition = HasEnemies(SamRow);
            return IfStepSuccessful(enemyPosition);
        }
        public bool wait()
        {
            moveEnemies();
            KeyValuePair<char, int> enemyPosition = HasEnemies(SamRow);
            return IfStepSuccessful(enemyPosition);
        }
        private void moveEnemies()
        {
            char[] currentRow;
            foreach (KeyValuePair<int, char[]> pair in room)
            {
                currentRow = pair.Value;
                for (int i = 0; i < currentRow.Length; i++)
                {
                    if (currentRow[i] == 'b')
                    {
                        if (i == currentRow.Length - 1)
                        {
                            currentRow[i] = 'd';
                        }
                        else
                        {
                            currentRow[i] = '.';
                            currentRow[i + 1] = 'b';
                        }
                        break;
                    }
                    else if (currentRow[i] == 'd')
                    {
                        if (i == 0)
                        {
                            currentRow[i] = 'b';
                        }
                        else
                        {
                            currentRow[i] = '.';
                            currentRow[i - 1] = 'd';
                        }
                        break;
                    }
                }
            }
        }

        private KeyValuePair<char, int> HasEnemies(int row)
        {
            int index = -1;
            char enemyDir = '.';
            if (room[row].Contains('b'))
            {
                enemyDir = 'b';
                index = room[row].ToList().IndexOf(enemyDir);
            } else if (room[row].Contains('d'))
            {
                enemyDir = 'd';
                index = room[row].ToList().IndexOf(enemyDir);
            } else if (room[row].Contains('N')  || row == NikoRow)
            {
                enemyDir = 'N';
                index = room[row].ToList().IndexOf(enemyDir);
            }
            return new KeyValuePair<char, int>(enemyDir, index);
        }

        private bool IfStepSuccessful(KeyValuePair<char, int> enemyPosition)
        {
            if (SamRow == NikoRow)
            {
                SamWon = true;
                if(enemyPosition.Value == -1)
                {   
                    room[SamRow][SamCol] = 'X';
                    SamCol = SamCol + 1 == room[SamRow].Length ? SamCol - 1 : SamCol + 1;                    
                    room[SamRow][SamCol] = 'S';
                } else
                {
                    room[SamRow][enemyPosition.Value] = 'X';
                    return true;
                }
                
            }
            if (enemyPosition.Value == -1)
            {
                return true;
            }
            else if (enemyPosition.Value == SamCol)
            {
                return true;
            }
            if (enemyPosition.Key == 'b')
            {
                if (enemyPosition.Value > SamCol)
                {
                    return true;
                }
                else
                {
                    room[SamRow][SamCol] = 'X';
                    return false;
                }
            }
            else
            {
                if (enemyPosition.Value < SamCol)
                {
                    return true;
                }
                else
                {
                    room[SamRow][SamCol] = 'X';
                    return false;
                }
            }
        }

        public override string ToString()
        {
            string res = "";
            foreach(KeyValuePair<int, char[]> pair in room)
            {   
                foreach(char c in  pair.Value)
                {
                    res += c;
                }
                res += "\n";
            }
            return res;
        }
    }
}
