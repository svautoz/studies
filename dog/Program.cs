double distance = 200;
int count = 0;
int speed_1 = 2;
int speed_2 = 3;
int dog_speed = 5;
int direction = 2;
double time = 0;

while(distance > 10)
{
    if(direction == 2)
    {
        time = distance / (speed_2 + dog_speed);
        direction = 1;
    }
    else
    {
        time = distance / (speed_1 + dog_speed);        
        direction = 2;
    }
    distance = distance - time * (speed_2 + speed_1);
    count++;
}

Console.Write("Собака пробежит ");
Console.Write(count);
Console.WriteLine(" раз.");
