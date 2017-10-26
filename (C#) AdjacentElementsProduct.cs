//Given an array of integers, find the pair of adjacent elements that has the largest product and return that product.

int adjacentElementsProduct(int[] inputArray) {
    int max = -2500;
    for (int i=1; i<inputArray.Length;) {
        max = Math.Max(max, inputArray[i-1] * inputArray[i++]);
    }
    return max; 
}
