public class Solution {
       public int[] ClosestPrimes(int left, int right) {
        bool[] isPrime = SieveOfEratosthenes(right);
        List<int> primes = new List<int>();
        for (int i = left; i <= right; i++) {
            if (isPrime[i]) {
                primes.Add(i);
            }
        }
        if (primes.Count < 2) {
            return new int[] { -1, -1 };
        }
    
        int minDiff = int.MaxValue;
        int num1 = -1, num2 = -1;

        for (int i = 1; i < primes.Count; i++) {
            int diff = primes[i] - primes[i - 1];
            if (diff < minDiff) {
                minDiff = diff;
                num1 = primes[i - 1];
                num2 = primes[i];
            }
        }

        return new int[] { num1, num2 };
    }

  
    public bool[] SieveOfEratosthenes(int max) {
        bool[] isPrime = new bool[max + 1];
        Array.Fill(isPrime, true);
        isPrime[0] = isPrime[1] = false; 

        for (int i = 2; i * i <= max; i++) {
            if (isPrime[i]) {
                for (int j = i * i; j <= max; j += i) {
                    isPrime[j] = false;
                }
            }
        }

        return isPrime; 
    }
}
