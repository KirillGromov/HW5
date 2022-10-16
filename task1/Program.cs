
int[] CreateArr(){
    int[] array = new int[4];
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++){
        array[i] = rand.Next(100, 999);
    }
    return array;
}

void Chet(int[] arr){
    int count  = 0;
    foreach(int i in arr){
        Console.WriteLine(i);
        if(i%2 == 0){
            count++;
        }
    }
    Console.WriteLine(count);
}

Chet(CreateArr());

