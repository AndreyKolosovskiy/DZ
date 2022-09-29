// // Задача 2: Задайте две квадратные матрицы одного размера. Напишите программу, которая будет находить произведение двух матриц.


int[,] array1={{3,2},{4,1}};
int[,] array2={{2,5},{3,2}};
ArrayToConsole(MultiMatrix(array1, array2));
int[,] MultiMatrix(int[,] array1,int[,]array2){
    int[,] res =new int[array1.GetLength(0), array2.GetLength(1)];
    int sum=0;
    for(int i=0; i<array1.GetLength(0); i++){
        for(int j=0; j<array1.GetLength(1); j++){
            sum=0;
            for(int k=0; k<array1.GetLength(1); k++){
                sum+=array1[i,k]*array2[k,j];
            }
            res[i,j]=sum;
        }
    }
    return res;
}
void ArrayToConsole(int[,]array){
    int[]buf =new int[array.GetLength(1)];
    for(int i=0; i<array.GetLength(0); i++){
        for (int j=0; j<array.GetLength(0); j++){
            buf[j]=array[i,j];
        }
        System.Console.WriteLine("[{0}]",string.Join(",", buf));
    }
}

