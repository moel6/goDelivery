//Program for lifting and alerting when object is getting stolen

void lifting()
{
	bool ricardo = true;
	bool nathan = true;
	bool test = true;


while (test == true) //Test loop
{
	while (ricardo == true) //Motor omhoog
{
	motor[motorD] = 20;
	delay(500);
	ricardo = false;
	nathan = true;
	}

	while (nathan == true) //Motor naar beneden
	{
		motor[motorD] = -20;
		delay(500);
		nathan = false;
		ricardo = true;
	}
}
}



task main()
{

lifting();




}
