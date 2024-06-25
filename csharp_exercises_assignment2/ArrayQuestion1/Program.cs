int[] arr1 = new int[10];

for (int i = 0; i < 10; i++) {
    arr1[i] = i;
}

int[] arr2 = new int[arr1.Length];

for (int i = 0; i < arr1.Length; i++) {
    arr2[i] = arr1[i];
}

for (int i = 0; i < arr2.Length; i++) {
    Console.Write(arr1[i]);
    Console.Write(" ");
    Console.WriteLine(arr2[i]);
}