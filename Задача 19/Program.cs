Console.WriteLine("Введите пятизначное число");
int i = int.Parse(Console.ReadLine());
int a = i/10000;
int b = i%10000/1000;
int c = i%10000%100/10;
int d = i%10000%100%10;

if(a==d && b==c){
    Console.WriteLine("да");

}
else{
   Console.WriteLine("нет"); 
}





