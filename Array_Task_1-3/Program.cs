namespace Array_Task_1_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Verilmis menfi ededleri musbete cevir.

            //Console.Write("Ededleri daxil edin: ");
            //string[] nums = Console.ReadLine().Split();
            //int[] numbers = new int[nums.Length];

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    numbers[i] = Math.Abs(int.Parse(nums[i]));
            //    Console.Write($"{numbers[i]} ");
            //}



            // 2. 0-i basa getir.

            //Console.Write("Ededleri daxil edin: ");
            //string[] nums = Console.ReadLine().Split();
            //int[] numbers = new int[nums.Length];
            //int forZero = 0;
            //int forOthers = 0;

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int num = int.Parse(nums[i]);
            //    if (num == 0)
            //    {
            //        numbers[forZero] = int.Parse(nums[i]);
            //        forZero++;
            //    }
            //}

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    int num = int.Parse(nums[i]);
            //    if (num != 0)
            //    {
            //        numbers[forZero + forOthers] = int.Parse(nums[i]);
            //        forOthers++;
            //    }
            //}

            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    Console.Write($"{numbers[i]} ");
            //};



            // 3. En uzun alt massivi tap.
            
            Console.Write("Ededleri daxil edin: ");
            string[] nums = Console.ReadLine().Split();
            int[] arr = new int[nums.Length];
            int[] newArr = new int[nums.Length];
            int curLength = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                arr[i] = int.Parse(nums[i]);
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (curLength == 0 || arr[i] > newArr[curLength - 1])
                {
                    newArr[curLength++] = arr[i];
                }
                else
                {
                    for (int j = 0; j < curLength; j++)
                    {
                        if (arr[i] <= newArr[j])
                        {
                            newArr[j] = arr[i];
                            break;
                        }
                    }
                }
            }

            for (int i = 0; i < curLength; i++)
            {
                Console.Write($"{newArr[i]} ");
            }

        }
    }

}
