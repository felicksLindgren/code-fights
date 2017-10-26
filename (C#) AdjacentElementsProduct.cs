int adjacentElementsProduct(int[] inputArray) {
    int max = -2500;
    for (int i=1; i<inputArray.Length;) {
        max = Math.Max(max, inputArray[i-1] * inputArray[i++]);
    }
    return max; 
}
