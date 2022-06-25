//This Code contains function classwork

float playerSpeed = 5f;

float oldSpeed;

SetSpeed(7f);

CompareSpeed();


void SetSpeed(float inSpeed)
{
    Console.WriteLine(

        "The player speed is " + playerSpeed

        );
    oldSpeed = playerSpeed;
    playerSpeed = inSpeed;

    Console.WriteLine(

        "The player speed is " + playerSpeed

        );

}



void CompareSpeed ()

{

    if (playerSpeed == oldSpeed)



        Console.WriteLine(

        "The player speed before and after is " + playerSpeed
            );

    else if (playerSpeed > oldSpeed)

        Console.WriteLine(

        "The player Greatest speed is " + playerSpeed
            );
    else

        Console.WriteLine(

           "The player Greatest speed is " + oldSpeed
               );

}

