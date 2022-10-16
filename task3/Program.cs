
int[] CreateArr(){
    int[] array = new int[4];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(1, 100);
        Console.WriteLine(array[i]);
    }
    return array;
}

int MaxArr(int[] arr){
    int max = arr[0];
    for(int i=0; i<arr.Length; i++){
        if(max<arr[i]){
            max = arr[i];
        }
    }
    return max;
}

int MinArr(int[] arr){
    int min = arr[0];
    for(int i=0; i<arr.Length; i++){
        if(min>arr[i]){
            min = arr[i];
        }
    }
    return min;
}

void Showdiff(){
    int[] arr = CreateArr();
    int max = MaxArr(arr);
    int min = MinArr(arr);
    Console.WriteLine("Разница мужду максимальным и минимальным = " + (max-min));
}

Showdiff();

