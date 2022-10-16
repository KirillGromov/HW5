
int[] CreateArr(){
    int[] array = new int[4];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(-99, 99);
    }
    return array;
}

void SumNechet(int[] arr){
    int sum = 0;
    for(int i=0; i<arr.Length; i++){
        Console.WriteLine(arr[i]);
        if(i%2!=0){
            sum +=arr[i];
        }
    }
    Console.WriteLine("Сумма:");
    Console.WriteLine(sum);
    
}

SumNechet(CreateArr());