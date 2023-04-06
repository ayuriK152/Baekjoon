using System;
using System.Collections;
using System.Linq;

namespace AlgorithmStudy
{
    class boj7569
    {
        public static void Main(string[] args)
        {
            string[] temp = Console.ReadLine().Split();
            int m = int.Parse(temp[0]), n = int.Parse(temp[1]), h = int.Parse(temp[2]);
            Container container = new Container(m, n, h);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    temp = Console.ReadLine().Split();
                    for (int k = 0; k < m; k++)
                    {
                        container.SetTomato(k, j, i, int.Parse(temp[k]));
                    }
                }
            }
            Console.WriteLine(container.BFS());
        }

        class Container
        {
            Tomato[,,] tomatoes;
            int maxX, maxY, maxZ;
            Queue queue;
            public Container(int x, int y, int z)
            {
                tomatoes = new Tomato[x, y, z];
                Tomato.changedCnt = x * y * z;
                maxX = x; maxY = y; maxZ = z;
                queue = new Queue();
                Init();
            }

            void Init()
            {
                for (int z = 0; z < maxZ; z++)
                    for (int y = 0; y < maxY; y++)
                        for (int x = 0; x < maxX; x++)
                            tomatoes[x, y, z] = new Tomato();
            }

            public void SetTomato(int x, int y, int z, int value)
            {
                tomatoes[x, y, z].value = value;
                if (x != 0)
                    tomatoes[x, y, z].left = tomatoes[x - 1, y, z];
                if (x != maxX - 1)
                    tomatoes[x, y, z].right = tomatoes[x + 1, y, z];
                if (y != 0)
                    tomatoes[x, y, z].back = tomatoes[x, y - 1, z];
                if (y != maxY - 1)
                    tomatoes[x, y, z].front = tomatoes[x, y + 1, z];
                if (z != 0)
                    tomatoes[x, y, z].down = tomatoes[x, y, z - 1];
                if (z != maxZ - 1)
                    tomatoes[x, y, z].up = tomatoes[x, y, z + 1];
                if (value == 1)
                {
                    queue.Enqueue(tomatoes[x, y, z]);
                    Tomato.changedCnt--;
                }
                else if (value == -1)
                    Tomato.changedCnt--;
            }

            public int BFS()
            {
                int count = 0;
                int layerCnt = queue.Count;
                while (queue.Count > 0)
                {
                    layerCnt--;
                    bool isChanged = false;
                    Tomato t = (Tomato)queue.Dequeue();
                    if (t.left != null)
                    {
                        if (t.left.value == 0 && !t.left.isSearched)
                        {
                            queue.Enqueue(t.left);
                            t.left.value++;
                            t.left.isSearched = true;
                            isChanged = true;
                            Tomato.changedCnt--;
                        }
                    }
                    if (t.right != null)
                    {
                        if (t.right.value == 0 && !t.right.isSearched)
                        {
                            queue.Enqueue(t.right);
                            t.right.value++;
                            t.right.isSearched = true;
                            isChanged = true;
                            Tomato.changedCnt--;
                        }
                    }
                    if (t.back != null)
                    {
                        if (t.back.value == 0 && !t.back.isSearched)
                        {
                            queue.Enqueue(t.back);
                            t.back.value++;
                            t.back.isSearched = true;
                            isChanged = true;
                            Tomato.changedCnt--;
                        }
                    }
                    if (t.front != null)
                    {
                        if (t.front.value == 0 && !t.front.isSearched)
                        {
                            queue.Enqueue(t.front);
                            t.front.value++;
                            t.front.isSearched = true;
                            isChanged = true;
                            Tomato.changedCnt--;
                        }
                    }
                    if (t.down != null)
                    {
                        if (t.down.value == 0 && !t.down.isSearched)
                        {
                            queue.Enqueue(t.down);
                            t.down.value++;
                            t.down.isSearched = true;
                            isChanged = true;
                            Tomato.changedCnt--;
                        }
                    }
                    if (t.up != null)
                    {
                        if (t.up.value == 0 && !t.up.isSearched)
                        {
                            queue.Enqueue(t.up);
                            t.up.value++;
                            t.up.isSearched = true;
                            isChanged = true;
                            Tomato.changedCnt--;
                        }
                    }
                    if (queue.Count > 0 && layerCnt == 0)
                    {
                        count++;
                        layerCnt = queue.Count;
                    }
                }
                if (Tomato.changedCnt == 0)
                    return count;
                else
                    return -1;
            }
        }

        class Tomato
        {
            public static int changedCnt;
            public Tomato up, down, left, right, front, back;
            public bool isSearched;
            public int value;
            public Tomato()
            {
                up = down = left = right = front = back = null;
                isSearched = false;
                value = 0;
            }
        }
    }
}