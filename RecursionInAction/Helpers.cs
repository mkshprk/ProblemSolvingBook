namespace RecursionInAction
{
    public static class Helpers
    {
        public static void SwapArrayElements(int[] arr, int first, int second)
        {
            arr[first] += arr[second];
            arr[second] = arr[first] - arr[second];
            arr[first] -= arr[second];
        }
    }
}
